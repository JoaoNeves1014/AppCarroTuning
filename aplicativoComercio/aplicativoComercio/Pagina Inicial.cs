/*
 * Created by SharpDevelop.
 * User: 1068441
 * Date: 02/03/2026
 * Time: 16:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace aplicativoComercio
{
	/// <summary>
	/// Description of Pagina_Inicial.
	/// </summary>
	public partial class Pagina_Inicial : Form
	{
		public Pagina_Inicial()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void PictureBox1Click(object sender, EventArgs e)
		{
	
		}
		void Panel2Paint(object sender, PaintEventArgs e)
		{
	
		}
		void Panel9Paint(object sender, PaintEventArgs e)
		{
	
		}
		void Panel15Paint(object sender, PaintEventArgs e)
		{
	
		}
		void Label11Click(object sender, EventArgs e)
		{
	
		}
		void Button5Click(object sender, EventArgs e)
		{
	
			Gerenciador tela = new Gerenciador();
			tela.Show();
			this.Hide();
		}
		void Button1Click(object sender, EventArgs e)
		{
	
			Cadastrados tela = new Cadastrados();
			tela.Show();
			this.Hide();
		}
		void Button3Click(object sender, EventArgs e)
		{
	
			Cadastrados tela = new Cadastrados();
			tela.Show();
			this.Hide();
		}
		void Button2Click(object sender, EventArgs e)
		{
	
			Cadastrados tela = new Cadastrados();
			tela.Show();
			this.Hide();
		}
		void Button4Click(object sender, EventArgs e)
		{
	
			Favoritados tela = new Favoritados();
			tela.Show();
			this.Hide();
		}
		void Label13Click(object sender, EventArgs e)
		{
	
		}
	}
}
