using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace pooremma
{
	public class Randomizer : Form
	{
		private IContainer components = null;

		private Button button1;

		private CheckBox NormalChoice;

		private CheckBox BossesChoice;

		private PictureBox pictureBox1;

		private TextBox enemyBossChance;

		private TextBox bossBossChance;

		private Label enemyBossChanceLabel;
		private Label label1;
		private Label bossBossChanceLabel;


		public Randomizer()
		{
			this.InitializeComponent();
		}

		private void BossesChoice_CheckedChanged(object sender, EventArgs e)
		{
			if (BossesChoice.Checked)
			{
				bossBossChance.Text = "100";
			}
			else
			{
				bossBossChance.Text = "80";
			}
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			int num;
			int num1;
			int enemyBoss;
			int bossBoss;
			num = (!this.NormalChoice.Checked ? 0 : 1);
			num1 = (!this.BossesChoice.Checked ? 0 : 1);
			enemyBoss = Int16.Parse(this.enemyBossChance.Text);
			bossBoss = Int16.Parse(this.bossBossChance.Text);
			RandomizerForEnemy.Randomwriter(num, num1, enemyBoss, bossBoss);
			MessageBox.Show("Enemy Randomization Complete!");
		}

		protected override void Dispose(bool disposing)
		{
			if ((!disposing ? false : this.components != null))
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.NormalChoice = new System.Windows.Forms.CheckBox();
			this.BossesChoice = new System.Windows.Forms.CheckBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.enemyBossChance = new System.Windows.Forms.TextBox();
			this.enemyBossChanceLabel = new System.Windows.Forms.Label();
			this.bossBossChanceLabel = new System.Windows.Forms.Label();
			this.bossBossChance = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
			this.button1.ForeColor = System.Drawing.Color.Black;
			this.button1.Location = new System.Drawing.Point(262, 237);
			this.button1.Margin = new System.Windows.Forms.Padding(2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(239, 36);
			this.button1.TabIndex = 0;
			this.button1.Text = "Run Randomizer";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// NormalChoice
			// 
			this.NormalChoice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NormalChoice.AutoSize = true;
			this.NormalChoice.Checked = true;
			this.NormalChoice.CheckState = System.Windows.Forms.CheckState.Checked;
			this.NormalChoice.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
			this.NormalChoice.ForeColor = System.Drawing.Color.DarkGray;
			this.NormalChoice.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.NormalChoice.Location = new System.Drawing.Point(199, 97);
			this.NormalChoice.Margin = new System.Windows.Forms.Padding(2);
			this.NormalChoice.Name = "NormalChoice";
			this.NormalChoice.Size = new System.Drawing.Size(316, 22);
			this.NormalChoice.TabIndex = 1;
			this.NormalChoice.Text = "All regular enemeies can be bosses.";
			this.NormalChoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.NormalChoice.UseVisualStyleBackColor = true;
			this.NormalChoice.CheckedChanged += new System.EventHandler(this.NormalChoice_CheckedChanged);
			// 
			// BossesChoice
			// 
			this.BossesChoice.AutoSize = true;
			this.BossesChoice.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
			this.BossesChoice.ForeColor = System.Drawing.Color.DarkGray;
			this.BossesChoice.Location = new System.Drawing.Point(199, 167);
			this.BossesChoice.Margin = new System.Windows.Forms.Padding(2);
			this.BossesChoice.Name = "BossesChoice";
			this.BossesChoice.Size = new System.Drawing.Size(407, 22);
			this.BossesChoice.TabIndex = 2;
			this.BossesChoice.Text = "Bosses can only be replaced with other bosses.";
			this.BossesChoice.UseVisualStyleBackColor = true;
			this.BossesChoice.CheckedChanged += new System.EventHandler(this.BossesChoice_CheckedChanged);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(0, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(784, 89);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// enemyBossChance
			// 
			this.enemyBossChance.BackColor = System.Drawing.Color.DarkGray;
			this.enemyBossChance.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold);
			this.enemyBossChance.Location = new System.Drawing.Point(226, 124);
			this.enemyBossChance.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.enemyBossChance.Name = "enemyBossChance";
			this.enemyBossChance.Size = new System.Drawing.Size(37, 23);
			this.enemyBossChance.TabIndex = 8;
			this.enemyBossChance.Text = "8";
			this.enemyBossChance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// enemyBossChanceLabel
			// 
			this.enemyBossChanceLabel.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold);
			this.enemyBossChanceLabel.ForeColor = System.Drawing.Color.DarkGray;
			this.enemyBossChanceLabel.Location = new System.Drawing.Point(268, 127);
			this.enemyBossChanceLabel.Name = "enemyBossChanceLabel";
			this.enemyBossChanceLabel.Size = new System.Drawing.Size(370, 65);
			this.enemyBossChanceLabel.TabIndex = 9;
			this.enemyBossChanceLabel.Text = "Percent chance of enemies becoming bosses.";
			// 
			// bossBossChanceLabel
			// 
			this.bossBossChanceLabel.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold);
			this.bossBossChanceLabel.ForeColor = System.Drawing.Color.DarkGray;
			this.bossBossChanceLabel.Location = new System.Drawing.Point(268, 197);
			this.bossBossChanceLabel.Name = "bossBossChanceLabel";
			this.bossBossChanceLabel.Size = new System.Drawing.Size(370, 65);
			this.bossBossChanceLabel.TabIndex = 9;
			this.bossBossChanceLabel.Text = "Percent chance of bosses becoming bosses.";
			// 
			// bossBossChance
			// 
			this.bossBossChance.BackColor = System.Drawing.Color.DarkGray;
			this.bossBossChance.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold);
			this.bossBossChance.Location = new System.Drawing.Point(226, 194);
			this.bossBossChance.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.bossBossChance.Name = "bossBossChance";
			this.bossBossChance.Size = new System.Drawing.Size(37, 23);
			this.bossBossChance.TabIndex = 8;
			this.bossBossChance.Text = "80";
			this.bossBossChance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.DarkGray;
			this.label1.Location = new System.Drawing.Point(12, 244);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(229, 65);
			this.label1.TabIndex = 10;
			this.label1.Text = "Note: If you want to re-randomize your enemies, you only need to go to the title " +
    "screen. Restarting the game is not necessary";
			// 
			// Randomizer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(766, 318);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.BossesChoice);
			this.Controls.Add(this.NormalChoice);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.enemyBossChance);
			this.Controls.Add(this.enemyBossChanceLabel);
			this.Controls.Add(this.bossBossChance);
			this.Controls.Add(this.bossBossChanceLabel);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Randomizer";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Dark Souls 3 Enemy Randomizer";
			this.Load += new System.EventHandler(this.Randomizer_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private void NormalChoice_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
		}

		private void progressBar1_Click(object sender, EventArgs e)
		{
		}

		private void Randomizer_Load(object sender, EventArgs e)
		{
			this.pictureBox1.Image = Image.FromFile("files\\picture\\ds3randobanner.png");
		}
	}
}