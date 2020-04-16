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

		private Label label1;

		private Label label2;

		private PictureBox pictureBox1;

		public Randomizer()
		{
			this.InitializeComponent();
		}

		private void BossesChoice_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			int num;
			int num1;
			num = (!this.NormalChoice.Checked ? 0 : 1);
			num1 = (!this.BossesChoice.Checked ? 0 : 1);
			RandomizerForEnemy.Randomwriter(num, num1);
			MessageBox.Show("Random Complete");
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Randomizer));
			this.button1 = new Button();
			this.NormalChoice = new CheckBox();
			this.BossesChoice = new CheckBox();
			this.label1 = new Label();
			this.label2 = new Label();
			this.pictureBox1 = new PictureBox();
			((ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.button1.Location = new Point(213, 582);
			this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(167, 38);
			this.button1.TabIndex = 0;
			this.button1.Text = "Start Random";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new EventHandler(this.Button1_Click);
			this.NormalChoice.AutoSize = true;
			this.NormalChoice.Checked = true;
			this.NormalChoice.CheckState = CheckState.Checked;
			this.NormalChoice.Location = new Point(23, 399);
			this.NormalChoice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.NormalChoice.Name = "NormalChoice";
			this.NormalChoice.Size = new System.Drawing.Size(437, 19);
			this.NormalChoice.TabIndex = 1;
			this.NormalChoice.Text = "Normal will be replaced with both Bosses and Normal";
			this.NormalChoice.UseVisualStyleBackColor = true;
			this.NormalChoice.CheckedChanged += new EventHandler(this.NormalChoice_CheckedChanged);
			this.BossesChoice.AutoSize = true;
			this.BossesChoice.Location = new Point(23, 491);
			this.BossesChoice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.BossesChoice.Name = "BossesChoice";
			this.BossesChoice.Size = new System.Drawing.Size(349, 19);
			this.BossesChoice.TabIndex = 2;
			this.BossesChoice.Text = "Bosses will be replaced with only Bosses";
			this.BossesChoice.UseVisualStyleBackColor = true;
			this.BossesChoice.CheckedChanged += new EventHandler(this.BossesChoice_CheckedChanged);
			this.label1.AutoSize = true;
			this.label1.Location = new Point(20, 440);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(495, 15);
			this.label1.TabIndex = 3;
			this.label1.Text = "If you cancel it,the Normal will be replaced with only Normal";
			this.label2.AutoSize = true;
			this.label2.Location = new Point(20, 528);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(559, 15);
			this.label2.TabIndex = 4;
			this.label2.Text = "If you cancel it ,Bosses will be replaced with both Bosses and Normal";
			this.pictureBox1.Location = new Point(0, 4);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(597, 376);
			this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			base.AutoScaleDimensions = new SizeF(8f, 15f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(597, 668);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.BossesChoice);
			base.Controls.Add(this.NormalChoice);
			base.Controls.Add(this.button1);
			base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			base.Name = "Randomizer";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Dark Souls 3 Enemy Randomizer";
			base.Load += new EventHandler(this.Randomizer_Load);
			((ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
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
			this.pictureBox1.Image = Image.FromFile("files\\picture\\runundead.png");
		}
	}
}