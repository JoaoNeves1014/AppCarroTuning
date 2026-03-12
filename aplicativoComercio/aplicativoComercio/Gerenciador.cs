/*
 * Created by SharpDevelop.
 * User: 1068441
 * Date: 06/03/2026
 * Time: 16:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace aplicativoComercio
{
	/// <summary>
	/// Description of Gerenciador.
	/// </summary>
	public partial class Gerenciador : Form
	{
		public Gerenciador()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button4Click(object sender, EventArgs e)
		{
	
			Pagina_Inicial tela = new Pagina_Inicial();
			tela.Show();
			this.Hide();
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
	
		}
		void Label4Click(object sender, EventArgs e)
		{
	
		}
		void Label12Click(object sender, EventArgs e)
		{
	
		}
	}
}
