namespace ArmorUpgradePhysicsPatcher
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.TbSourceActor = new System.Windows.Forms.TextBox();
            this._labelSourceActor = new System.Windows.Forms.Label();
            this.BtnBrowseSourceActor = new System.Windows.Forms.Button();
            this.BtnRun = new System.Windows.Forms.Button();
            this.BtnAuto = new System.Windows.Forms.Button();
            this._labelUpgradeNumbers = new System.Windows.Forms.Label();
            this.TbUpgradeIncrements = new System.Windows.Forms.TextBox();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // TbSourceActor
            // 
            this.TbSourceActor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbSourceActor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TbSourceActor.Location = new System.Drawing.Point(12, 55);
            this.TbSourceActor.Margin = new System.Windows.Forms.Padding(3, 5, 10, 3);
            this.TbSourceActor.Name = "TbSourceActor";
            this.TbSourceActor.Size = new System.Drawing.Size(654, 34);
            this.TbSourceActor.TabIndex = 0;
            this.ToolTip.SetToolTip(this.TbSourceActor, "Source ActorPack file");
            // 
            // _labelSourceActor
            // 
            this._labelSourceActor.AutoSize = true;
            this._labelSourceActor.Location = new System.Drawing.Point(12, 24);
            this._labelSourceActor.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this._labelSourceActor.Name = "_labelSourceActor";
            this._labelSourceActor.Size = new System.Drawing.Size(114, 25);
            this._labelSourceActor.TabIndex = 1;
            this._labelSourceActor.Text = "Source Actor";
            // 
            // BtnBrowseSourceActor
            // 
            this.BtnBrowseSourceActor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBrowseSourceActor.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.BtnBrowseSourceActor.FlatAppearance.BorderSize = 2;
            this.BtnBrowseSourceActor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.BtnBrowseSourceActor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.BtnBrowseSourceActor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnBrowseSourceActor.Location = new System.Drawing.Point(681, 54);
            this.BtnBrowseSourceActor.Margin = new System.Windows.Forms.Padding(5);
            this.BtnBrowseSourceActor.Name = "BtnBrowseSourceActor";
            this.BtnBrowseSourceActor.Size = new System.Drawing.Size(111, 38);
            this.BtnBrowseSourceActor.TabIndex = 2;
            this.BtnBrowseSourceActor.Text = "Browse";
            this.ToolTip.SetToolTip(this.BtnBrowseSourceActor, "Browse for an sbctorpack file.");
            this.BtnBrowseSourceActor.UseVisualStyleBackColor = true;
            this.BtnBrowseSourceActor.Click += new System.EventHandler(this.BtnBrowseSourceActor_Click);
            // 
            // BtnRun
            // 
            this.BtnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRun.Location = new System.Drawing.Point(681, 230);
            this.BtnRun.Margin = new System.Windows.Forms.Padding(5);
            this.BtnRun.Name = "BtnRun";
            this.BtnRun.Size = new System.Drawing.Size(111, 38);
            this.BtnRun.TabIndex = 3;
            this.BtnRun.Text = "Generate";
            this.BtnRun.UseVisualStyleBackColor = true;
            this.BtnRun.Click += new System.EventHandler(this.BtnRun_Click);
            // 
            // BtnAuto
            // 
            this.BtnAuto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAuto.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.BtnAuto.FlatAppearance.BorderSize = 2;
            this.BtnAuto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.BtnAuto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.BtnAuto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnAuto.Location = new System.Drawing.Point(681, 131);
            this.BtnAuto.Margin = new System.Windows.Forms.Padding(5);
            this.BtnAuto.Name = "BtnAuto";
            this.BtnAuto.Size = new System.Drawing.Size(111, 38);
            this.BtnAuto.TabIndex = 6;
            this.BtnAuto.Text = "Autofill";
            this.ToolTip.SetToolTip(this.BtnAuto, "Attempts to autofill the upgrade increments from the ActorInfo.");
            this.BtnAuto.UseVisualStyleBackColor = true;
            this.BtnAuto.Click += new System.EventHandler(this.BtnAuto_Click);
            // 
            // _labelUpgradeNumbers
            // 
            this._labelUpgradeNumbers.AutoSize = true;
            this._labelUpgradeNumbers.Location = new System.Drawing.Point(12, 103);
            this._labelUpgradeNumbers.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this._labelUpgradeNumbers.Name = "_labelUpgradeNumbers";
            this._labelUpgradeNumbers.Size = new System.Drawing.Size(173, 25);
            this._labelUpgradeNumbers.TabIndex = 5;
            this._labelUpgradeNumbers.Text = "Upgrade Increments";
            // 
            // TbUpgradeIncrements
            // 
            this.TbUpgradeIncrements.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbUpgradeIncrements.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TbUpgradeIncrements.Location = new System.Drawing.Point(12, 135);
            this.TbUpgradeIncrements.Margin = new System.Windows.Forms.Padding(3, 5, 10, 3);
            this.TbUpgradeIncrements.Name = "TbUpgradeIncrements";
            this.TbUpgradeIncrements.PlaceholderText = "### ; ### ; ###";
            this.TbUpgradeIncrements.Size = new System.Drawing.Size(654, 34);
            this.TbUpgradeIncrements.TabIndex = 4;
            this.ToolTip.SetToolTip(this.TbUpgradeIncrements, "List of armor upgrades to use or create.");
            this.TbUpgradeIncrements.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbUpgradeIncrements_KeyPress);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 282);
            this.Controls.Add(this.BtnAuto);
            this.Controls.Add(this._labelUpgradeNumbers);
            this.Controls.Add(this.TbUpgradeIncrements);
            this.Controls.Add(this.BtnRun);
            this.Controls.Add(this.BtnBrowseSourceActor);
            this.Controls.Add(this._labelSourceActor);
            this.Controls.Add(this.TbSourceActor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Dashboard";
            this.Text = "Botw - Armor Upgrade Physics Patcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbSourceActor;
        private System.Windows.Forms.Label _labelSourceActor;
        private System.Windows.Forms.Button BtnBrowseSourceActor;
        private System.Windows.Forms.Button BtnRun;
        private System.Windows.Forms.Button BtnAuto;
        private System.Windows.Forms.Label _labelUpgradeNumbers;
        private System.Windows.Forms.TextBox TbUpgradeIncrements;
        private System.Windows.Forms.ToolTip ToolTip;
    }
}