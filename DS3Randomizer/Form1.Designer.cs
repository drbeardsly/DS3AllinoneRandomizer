namespace DS3Randomizer
{
    partial class Form1
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
            if (disposing && (components != null))
            {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_ItemRandoStart = new System.Windows.Forms.Button();
            this.btn_EnemyRandoStart = new System.Windows.Forms.Button();
            this.lbl_Version = new System.Windows.Forms.Label();
            this.btn_EnemyRandoInstall = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_SetInstallDir = new System.Windows.Forms.Button();
            this.lbl_EnemyRando = new System.Windows.Forms.Label();
            this.lbl_ItemRando = new System.Windows.Forms.Label();
            this.lbl_EnemyRandoInstallStatus = new System.Windows.Forms.Label();
            this.lbl_ItemRandoInstallStatus = new System.Windows.Forms.Label();
            this.btn_ItemRandoInstall = new System.Windows.Forms.Button();
            this.lbl_ModEngine = new System.Windows.Forms.Label();
            this.lbl_ModEngineInstallStatus = new System.Windows.Forms.Label();
            this.btn_ModEngineInstall = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.lbl_ItemRandoWarning = new System.Windows.Forms.Label();
            this.chkb_OnlyEnemyRando = new System.Windows.Forms.CheckBox();
            this.chkb_OnlyItemRando = new System.Windows.Forms.CheckBox();
            this.btn_DisableSound = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ItemRandoStart
            // 
            this.btn_ItemRandoStart.Location = new System.Drawing.Point(15, 108);
            this.btn_ItemRandoStart.Name = "btn_ItemRandoStart";
            this.btn_ItemRandoStart.Size = new System.Drawing.Size(67, 23);
            this.btn_ItemRandoStart.TabIndex = 0;
            this.btn_ItemRandoStart.Text = "Configure";
            this.btn_ItemRandoStart.UseVisualStyleBackColor = true;
            this.btn_ItemRandoStart.Click += new System.EventHandler(this.btn_ItemRandoStart_Click);
            // 
            // btn_EnemyRandoStart
            // 
            this.btn_EnemyRandoStart.Location = new System.Drawing.Point(15, 30);
            this.btn_EnemyRandoStart.Name = "btn_EnemyRandoStart";
            this.btn_EnemyRandoStart.Size = new System.Drawing.Size(67, 23);
            this.btn_EnemyRandoStart.TabIndex = 1;
            this.btn_EnemyRandoStart.Text = "Configure";
            this.btn_EnemyRandoStart.UseVisualStyleBackColor = true;
            this.btn_EnemyRandoStart.Click += new System.EventHandler(this.btn_EnemyRandoStart_Click);
            // 
            // lbl_Version
            // 
            this.lbl_Version.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Version.AutoSize = true;
            this.lbl_Version.Location = new System.Drawing.Point(247, 9);
            this.lbl_Version.Name = "lbl_Version";
            this.lbl_Version.Size = new System.Drawing.Size(35, 13);
            this.lbl_Version.TabIndex = 3;
            this.lbl_Version.Text = "label1";
            // 
            // btn_EnemyRandoInstall
            // 
            this.btn_EnemyRandoInstall.Location = new System.Drawing.Point(89, 30);
            this.btn_EnemyRandoInstall.Name = "btn_EnemyRandoInstall";
            this.btn_EnemyRandoInstall.Size = new System.Drawing.Size(65, 23);
            this.btn_EnemyRandoInstall.TabIndex = 4;
            this.btn_EnemyRandoInstall.Text = "Install";
            this.btn_EnemyRandoInstall.UseVisualStyleBackColor = true;
            this.btn_EnemyRandoInstall.Click += new System.EventHandler(this.btn_EnemyRandoInstall_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 289);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(347, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // btn_SetInstallDir
            // 
            this.btn_SetInstallDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SetInstallDir.Location = new System.Drawing.Point(207, 258);
            this.btn_SetInstallDir.Name = "btn_SetInstallDir";
            this.btn_SetInstallDir.Size = new System.Drawing.Size(128, 23);
            this.btn_SetInstallDir.TabIndex = 7;
            this.btn_SetInstallDir.Text = "Set DS3 Install location";
            this.btn_SetInstallDir.UseVisualStyleBackColor = true;
            this.btn_SetInstallDir.Click += new System.EventHandler(this.btn_SetInstallDir_Click);
            // 
            // lbl_EnemyRando
            // 
            this.lbl_EnemyRando.AutoSize = true;
            this.lbl_EnemyRando.Location = new System.Drawing.Point(12, 14);
            this.lbl_EnemyRando.Name = "lbl_EnemyRando";
            this.lbl_EnemyRando.Size = new System.Drawing.Size(101, 13);
            this.lbl_EnemyRando.TabIndex = 8;
            this.lbl_EnemyRando.Text = "Enemy Randomizer:";
            // 
            // lbl_ItemRando
            // 
            this.lbl_ItemRando.AutoSize = true;
            this.lbl_ItemRando.Location = new System.Drawing.Point(12, 92);
            this.lbl_ItemRando.Name = "lbl_ItemRando";
            this.lbl_ItemRando.Size = new System.Drawing.Size(89, 13);
            this.lbl_ItemRando.TabIndex = 9;
            this.lbl_ItemRando.Text = "Item Randomizer:";
            // 
            // lbl_EnemyRandoInstallStatus
            // 
            this.lbl_EnemyRandoInstallStatus.AutoSize = true;
            this.lbl_EnemyRandoInstallStatus.Location = new System.Drawing.Point(119, 14);
            this.lbl_EnemyRandoInstallStatus.Name = "lbl_EnemyRandoInstallStatus";
            this.lbl_EnemyRandoInstallStatus.Size = new System.Drawing.Size(35, 13);
            this.lbl_EnemyRandoInstallStatus.TabIndex = 10;
            this.lbl_EnemyRandoInstallStatus.Text = "label1";
            // 
            // lbl_ItemRandoInstallStatus
            // 
            this.lbl_ItemRandoInstallStatus.AutoSize = true;
            this.lbl_ItemRandoInstallStatus.Location = new System.Drawing.Point(107, 92);
            this.lbl_ItemRandoInstallStatus.Name = "lbl_ItemRandoInstallStatus";
            this.lbl_ItemRandoInstallStatus.Size = new System.Drawing.Size(35, 13);
            this.lbl_ItemRandoInstallStatus.TabIndex = 11;
            this.lbl_ItemRandoInstallStatus.Text = "label1";
            // 
            // btn_ItemRandoInstall
            // 
            this.btn_ItemRandoInstall.Location = new System.Drawing.Point(88, 108);
            this.btn_ItemRandoInstall.Name = "btn_ItemRandoInstall";
            this.btn_ItemRandoInstall.Size = new System.Drawing.Size(65, 23);
            this.btn_ItemRandoInstall.TabIndex = 12;
            this.btn_ItemRandoInstall.Text = "Install";
            this.btn_ItemRandoInstall.UseVisualStyleBackColor = true;
            this.btn_ItemRandoInstall.Click += new System.EventHandler(this.btn_ItemRandoInstall_Click);
            // 
            // lbl_ModEngine
            // 
            this.lbl_ModEngine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_ModEngine.AutoSize = true;
            this.lbl_ModEngine.Location = new System.Drawing.Point(4, 242);
            this.lbl_ModEngine.Name = "lbl_ModEngine";
            this.lbl_ModEngine.Size = new System.Drawing.Size(64, 13);
            this.lbl_ModEngine.TabIndex = 13;
            this.lbl_ModEngine.Text = "ModEngine:";
            // 
            // lbl_ModEngineInstallStatus
            // 
            this.lbl_ModEngineInstallStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_ModEngineInstallStatus.AutoSize = true;
            this.lbl_ModEngineInstallStatus.Location = new System.Drawing.Point(74, 242);
            this.lbl_ModEngineInstallStatus.Name = "lbl_ModEngineInstallStatus";
            this.lbl_ModEngineInstallStatus.Size = new System.Drawing.Size(35, 13);
            this.lbl_ModEngineInstallStatus.TabIndex = 14;
            this.lbl_ModEngineInstallStatus.Text = "label2";
            // 
            // btn_ModEngineInstall
            // 
            this.btn_ModEngineInstall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_ModEngineInstall.Location = new System.Drawing.Point(7, 258);
            this.btn_ModEngineInstall.Name = "btn_ModEngineInstall";
            this.btn_ModEngineInstall.Size = new System.Drawing.Size(75, 23);
            this.btn_ModEngineInstall.TabIndex = 15;
            this.btn_ModEngineInstall.Text = "Install";
            this.btn_ModEngineInstall.UseVisualStyleBackColor = true;
            this.btn_ModEngineInstall.Click += new System.EventHandler(this.btn_ModEngineInstall_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save.Location = new System.Drawing.Point(250, 30);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(85, 23);
            this.btn_Save.TabIndex = 16;
            this.btn_Save.Text = "Save and Exit";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // lbl_ItemRandoWarning
            // 
            this.lbl_ItemRandoWarning.AutoSize = true;
            this.lbl_ItemRandoWarning.Location = new System.Drawing.Point(12, 157);
            this.lbl_ItemRandoWarning.Name = "lbl_ItemRandoWarning";
            this.lbl_ItemRandoWarning.Size = new System.Drawing.Size(35, 13);
            this.lbl_ItemRandoWarning.TabIndex = 17;
            this.lbl_ItemRandoWarning.Text = "label1";
            // 
            // chkb_OnlyEnemyRando
            // 
            this.chkb_OnlyEnemyRando.AutoSize = true;
            this.chkb_OnlyEnemyRando.Location = new System.Drawing.Point(15, 59);
            this.chkb_OnlyEnemyRando.Name = "chkb_OnlyEnemyRando";
            this.chkb_OnlyEnemyRando.Size = new System.Drawing.Size(96, 17);
            this.chkb_OnlyEnemyRando.TabIndex = 18;
            this.chkb_OnlyEnemyRando.Text = " Only  Enemies";
            this.chkb_OnlyEnemyRando.UseVisualStyleBackColor = true;
            this.chkb_OnlyEnemyRando.CheckStateChanged += new System.EventHandler(this.chkb_OnlyEnemyRando_CheckStateChanged);
            // 
            // chkb_OnlyItemRando
            // 
            this.chkb_OnlyItemRando.AutoSize = true;
            this.chkb_OnlyItemRando.Location = new System.Drawing.Point(15, 137);
            this.chkb_OnlyItemRando.Name = "chkb_OnlyItemRando";
            this.chkb_OnlyItemRando.Size = new System.Drawing.Size(78, 17);
            this.chkb_OnlyItemRando.TabIndex = 19;
            this.chkb_OnlyItemRando.Text = " Only Items";
            this.chkb_OnlyItemRando.UseVisualStyleBackColor = true;
            this.chkb_OnlyItemRando.CheckStateChanged += new System.EventHandler(this.chkb_OnlyItemRando_CheckStateChanged);
            // 
            // btn_DisableSound
            // 
            this.btn_DisableSound.Location = new System.Drawing.Point(227, 166);
            this.btn_DisableSound.Name = "btn_DisableSound";
            this.btn_DisableSound.Size = new System.Drawing.Size(108, 23);
            this.btn_DisableSound.TabIndex = 20;
            this.btn_DisableSound.Text = "Disable Sound";
            this.btn_DisableSound.UseVisualStyleBackColor = true;
            this.btn_DisableSound.Click += new System.EventHandler(this.btn_DisableSound_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 311);
            this.Controls.Add(this.btn_DisableSound);
            this.Controls.Add(this.chkb_OnlyItemRando);
            this.Controls.Add(this.chkb_OnlyEnemyRando);
            this.Controls.Add(this.lbl_ItemRandoWarning);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_ModEngineInstall);
            this.Controls.Add(this.lbl_ModEngineInstallStatus);
            this.Controls.Add(this.lbl_ModEngine);
            this.Controls.Add(this.btn_ItemRandoInstall);
            this.Controls.Add(this.lbl_ItemRandoInstallStatus);
            this.Controls.Add(this.lbl_EnemyRandoInstallStatus);
            this.Controls.Add(this.lbl_ItemRando);
            this.Controls.Add(this.lbl_EnemyRando);
            this.Controls.Add(this.btn_SetInstallDir);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btn_EnemyRandoInstall);
            this.Controls.Add(this.lbl_Version);
            this.Controls.Add(this.btn_EnemyRandoStart);
            this.Controls.Add(this.btn_ItemRandoStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Dark Souls 3 Randomizer Manager";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ItemRandoStart;
        private System.Windows.Forms.Button btn_EnemyRandoStart;
        private System.Windows.Forms.Label lbl_Version;
        private System.Windows.Forms.Button btn_EnemyRandoInstall;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btn_SetInstallDir;
        private System.Windows.Forms.Label lbl_EnemyRando;
        private System.Windows.Forms.Label lbl_ItemRando;
        private System.Windows.Forms.Label lbl_EnemyRandoInstallStatus;
        private System.Windows.Forms.Label lbl_ItemRandoInstallStatus;
        private System.Windows.Forms.Button btn_ItemRandoInstall;
        private System.Windows.Forms.Label lbl_ModEngine;
        private System.Windows.Forms.Label lbl_ModEngineInstallStatus;
        private System.Windows.Forms.Button btn_ModEngineInstall;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label lbl_ItemRandoWarning;
        private System.Windows.Forms.CheckBox chkb_OnlyEnemyRando;
        private System.Windows.Forms.CheckBox chkb_OnlyItemRando;
        private System.Windows.Forms.Button btn_DisableSound;
    }
}

