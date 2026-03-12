/*
 * Created by SharpDevelop.
 * User: 1068441
 * Date: 04/03/2026
 * Time: 14:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace aplicativoComercio
{
	partial class Favoritados
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.HScrollBar hScrollBar1;
		private System.Windows.Forms.HScrollBar hScrollBar2;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.Label label8;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Favoritados));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label8 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
			this.label2 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.hScrollBar2 = new System.Windows.Forms.HScrollBar();
			this.label6 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Red;
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(1, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1018, 101);
			this.panel1.TabIndex = 0;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(418, 76);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(160, 25);
			this.label8.TabIndex = 13;
			this.label8.Text = "Voltar a pagina inicial";
			this.label8.Click += new System.EventHandler(this.Label8Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(834, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(148, 101);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(13, -31);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(242, 169);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Red;
			this.label1.Font = new System.Drawing.Font("Arial Black", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Yellow;
			this.label1.Location = new System.Drawing.Point(329, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(362, 56);
			this.label1.TabIndex = 0;
			this.label1.Text = "Meus Favoritados";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Silver;
			this.panel2.Controls.Add(this.pictureBox4);
			this.panel2.Controls.Add(this.pictureBox3);
			this.panel2.Controls.Add(this.hScrollBar1);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Location = new System.Drawing.Point(11, 110);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(456, 514);
			this.panel2.TabIndex = 1;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(371, 34);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(31, 29);
			this.pictureBox4.TabIndex = 9;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(408, 34);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(31, 32);
			this.pictureBox3.TabIndex = 8;
			this.pictureBox3.TabStop = false;
			// 
			// hScrollBar1
			// 
			this.hScrollBar1.Location = new System.Drawing.Point(446, 0);
			this.hScrollBar1.Name = "hScrollBar1";
			this.hScrollBar1.Size = new System.Drawing.Size(10, 514);
			this.hScrollBar1.TabIndex = 7;
			this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HScrollBar1Scroll);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Silver;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Yellow;
			this.label2.Location = new System.Drawing.Point(136, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(147, 33);
			this.label2.TabIndex = 4;
			this.label2.Text = "Veiculos Favoritos";
			this.label2.Click += new System.EventHandler(this.Label2Click);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.Silver;
			this.panel3.Controls.Add(this.pictureBox8);
			this.panel3.Controls.Add(this.pictureBox5);
			this.panel3.Controls.Add(this.hScrollBar2);
			this.panel3.Controls.Add(this.label6);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Location = new System.Drawing.Point(531, 110);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(475, 514);
			this.panel3.TabIndex = 2;
			// 
			// pictureBox8
			// 
			this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
			this.pictureBox8.Location = new System.Drawing.Point(421, 34);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(31, 32);
			this.pictureBox8.TabIndex = 12;
			this.pictureBox8.TabStop = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(384, 34);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(31, 29);
			this.pictureBox5.TabIndex = 10;
			this.pictureBox5.TabStop = false;
			// 
			// hScrollBar2
			// 
			this.hScrollBar2.Location = new System.Drawing.Point(465, 0);
			this.hScrollBar2.Name = "hScrollBar2";
			this.hScrollBar2.Size = new System.Drawing.Size(10, 514);
			this.hScrollBar2.TabIndex = 8;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(13, 34);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(283, 29);
			this.label6.TabIndex = 6;
			this.label6.Text = "- Kit turbo para Motor VTEC  1.6 4 Cilindros";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Silver;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Yellow;
			this.label3.Location = new System.Drawing.Point(190, 10);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(147, 33);
			this.label3.TabIndex = 5;
			this.label3.Text = "Peças Favoritas";
			this.label3.Click += new System.EventHandler(this.Label3Click);
			// 
			// Favoritados
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.ClientSize = new System.Drawing.Size(1018, 636);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "Favoritados";
			this.Text = "Favoritados";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
