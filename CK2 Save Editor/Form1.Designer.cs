
namespace CK2_Save_Editor
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
			this.lblDiplomacy = new System.Windows.Forms.Label();
			this.lblMartial = new System.Windows.Forms.Label();
			this.lblStewardship = new System.Windows.Forms.Label();
			this.lblIntrigue = new System.Windows.Forms.Label();
			this.lblLearning = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblDiplomacy
			// 
			this.lblDiplomacy.AutoSize = true;
			this.lblDiplomacy.Location = new System.Drawing.Point(22, 45);
			this.lblDiplomacy.Name = "lblDiplomacy";
			this.lblDiplomacy.Size = new System.Drawing.Size(56, 13);
			this.lblDiplomacy.TabIndex = 0;
			this.lblDiplomacy.Text = "Diplomacy";
			this.lblDiplomacy.Click += new System.EventHandler(this.label1_Click);
			// 
			// lblMartial
			// 
			this.lblMartial.AutoSize = true;
			this.lblMartial.Location = new System.Drawing.Point(94, 45);
			this.lblMartial.Name = "lblMartial";
			this.lblMartial.Size = new System.Drawing.Size(38, 13);
			this.lblMartial.TabIndex = 1;
			this.lblMartial.Text = "Martial";
			// 
			// lblStewardship
			// 
			this.lblStewardship.AutoSize = true;
			this.lblStewardship.Location = new System.Drawing.Point(149, 45);
			this.lblStewardship.Name = "lblStewardship";
			this.lblStewardship.Size = new System.Drawing.Size(65, 13);
			this.lblStewardship.TabIndex = 2;
			this.lblStewardship.Text = "Stewardship";
			// 
			// lblIntrigue
			// 
			this.lblIntrigue.AutoSize = true;
			this.lblIntrigue.Location = new System.Drawing.Point(234, 45);
			this.lblIntrigue.Name = "lblIntrigue";
			this.lblIntrigue.Size = new System.Drawing.Size(42, 13);
			this.lblIntrigue.TabIndex = 3;
			this.lblIntrigue.Text = "Intrigue";
			// 
			// lblLearning
			// 
			this.lblLearning.AutoSize = true;
			this.lblLearning.Location = new System.Drawing.Point(307, 45);
			this.lblLearning.Name = "lblLearning";
			this.lblLearning.Size = new System.Drawing.Size(48, 13);
			this.lblLearning.TabIndex = 4;
			this.lblLearning.Text = "Learning";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblLearning);
			this.Controls.Add(this.lblIntrigue);
			this.Controls.Add(this.lblStewardship);
			this.Controls.Add(this.lblMartial);
			this.Controls.Add(this.lblDiplomacy);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblDiplomacy;
		private System.Windows.Forms.Label lblMartial;
		private System.Windows.Forms.Label lblStewardship;
		private System.Windows.Forms.Label lblIntrigue;
		private System.Windows.Forms.Label lblLearning;
	}
}

