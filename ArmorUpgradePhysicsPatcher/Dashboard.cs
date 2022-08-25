using Botw.Cryptohraphy;
using Nintendo.Aamp;
using Nintendo.Byml;
using Nintendo.Sarc;
using Nintendo.Yaz0;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArmorUpgradePhysicsPatcher
{
    public partial class Dashboard : Form
    {
        private readonly List<string> keys = new() { "hkcl", "bphysics", "bphyssb", "bxml" };

        public Dashboard()
        {
            InitializeComponent();
        }

        private void BtnBrowseSourceActor_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new() {
                Filter = "Actor Pack (*.sbactorpack)|*.sbactorpack"
            };
            openFileDialog.ShowDialog();

            TbSourceActor.Text = openFileDialog.FileName;
        }

        private async void BtnAuto_Click(object sender, EventArgs e)
        {
            if (TbSourceActor.Text != "") {
                var ids = await Auto(TbSourceActor.Text);
                TbUpgradeIncrements.Text = string.Join(" ; ", ids);
            }
            else {
                MessageBox.Show("No actor pack specified.", "Error");
            }
        }

        private async void BtnRun_Click(object sender, EventArgs e)
        {
            if (TbSourceActor.Text != "" && File.Exists(TbSourceActor.Text)) {
                await Generate();
                MessageBox.Show("Task completed!", "Notice");
            }
            else {
                MessageBox.Show("No actor pack specified.", "Error");
            }
        }

        private void TbUpgradeIncrements_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ' || e.KeyChar == ';' || e.KeyChar == (char)Keys.Enter) {
                if (TbUpgradeIncrements.Text != "" && TbUpgradeIncrements.Text.Last() != ' ') {
                    TbUpgradeIncrements.Text += " ; ";
                    int len = TbUpgradeIncrements.Text.Length;
                    TbUpgradeIncrements.Select(len, len);
                }
                e.Handled = true;
            }
            else if (e.KeyChar == (char)Keys.Back) {
                if (TbUpgradeIncrements.Text != "" && TbUpgradeIncrements.Text.Last() == ' ') {
                    int len = TbUpgradeIncrements.Text.Length - 1;
                    TbUpgradeIncrements.Text = TbUpgradeIncrements.Text[0..(len - 2)];
                    TbUpgradeIncrements.Select(TbUpgradeIncrements.Text.Length, TbUpgradeIncrements.Text.Length);
                    e.Handled = true;
                }
            }
        }

        private static Task<List<string>> Auto(string actorpack)
        {
            string actorinfo = $"{actorpack}\\..\\..\\ActorInfo.product.sbyml -- nope";

            if (!File.Exists(actorinfo)) {
                var bcml = new Bcml.Utils.Settings();
                actorinfo = $"{bcml.GetUpdate()}\\Actor\\ActorInfo.product.sbyml";
            }

            BymlFile byml = new(Yaz0.Decompress(actorinfo));
            BymlNode baseActor = new(new Dictionary<string, BymlNode>());
            Dictionary<string, BymlNode> hashedArray = new();
            var actorname = Path.GetFileNameWithoutExtension(actorpack);

            foreach (var actor in byml.RootNode.Hash["Actors"].Array) {
                string name = actor.Hash["name"].String;
                hashedArray.Add(CRC32.ComputeHash(actor.Hash["name"].String), actor);

                if (name == actorname) {
                    baseActor = actor;
                }
            }

            List<string> ids = new() { baseActor.Hash["name"].String.Split("_")[1] };
            while (baseActor.Hash.ContainsKey("armorNextRankName") && baseActor.Hash["armorNextRankName"].String != "") {
                string nextActorname = baseActor.Hash["armorNextRankName"].String;
                ids.Add(nextActorname.Split("_")[1]);
                baseActor = hashedArray[CRC32.ComputeHash(nextActorname)];
            }

            return Task.FromResult(ids);
        }

        private Task Generate()
        {
            SarcFile sarc = new(Yaz0.Decompress(File.ReadAllBytes(TbSourceActor.Text)));

            var baseFiles = GetFiles(sarc.Files);
            var type = Path.GetFileNameWithoutExtension(TbSourceActor.Text).Split("_")[2];
            var bcml = new Bcml.Utils.Settings();
            foreach (var id in TbUpgradeIncrements.Text.Split(" ; ")) {
                var actorpackFile = $"{bcml.GetUpdate()}\\Actor\\Pack\\Armor_{id}_{type}.sbactorpack";
                if (File.Exists(actorpackFile)) {
                    SarcFile actorpack = new(Yaz0.Decompress(actorpackFile));
                    var files = GetFiles(actorpack.Files);

                    foreach (var key in keys) {
                        if (baseFiles.ContainsKey(key)) {
                            if (key == "bxml") {

                                AampFile aamp = new(baseFiles[key].Value);
                                var basePhysicsUser = aamp.RootNode.ParamObjects[0].ParamEntries[17];

                                AampFile aampnew = new(files[key].Value);
                                aampnew.RootNode.ParamObjects[0].ParamEntries[17] = basePhysicsUser;
                                actorpack.Files[files[key].Key] = aampnew.ToBinary();
                            }
                            else if (key == "bphysics") {
                                actorpack.Files[files[key].Key] = baseFiles[key].Value;
                            }
                            else {
                                if (files.ContainsKey(key)) {
                                    actorpack.Files.Remove(files[key].Key);
                                }
                                actorpack.Files.Add(baseFiles[key].Key, baseFiles[key].Value);
                            }
                        }
                    }

                    File.WriteAllBytes($"{Path.GetDirectoryName(TbSourceActor.Text)}\\Armor_{id}_{type}.sbactorpack", Yaz0.Compress(actorpack.ToBinary()));
                }
            }

            return Task.CompletedTask;
        }

        private Dictionary<string, KeyValuePair<string, byte[]>> GetFiles(Dictionary<string, byte[]> files)
        {
            Dictionary<string, KeyValuePair<string, byte[]>> result = new();

            foreach (var file in files)
                foreach (var key in keys)
                    if (file.Key.EndsWith(key))
                        result.Add(key, file);

            return result;
        }
    }
}
