/*
 * Created by SharpDevelop.
 * User: 1068441
 * Date: 04/03/2026
 * Time: 14:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace aplicativoComercio
{
	/// <summary>
	/// Description of Favoritados.
	/// </summary>
	public partial class Favoritados : Form
	{
		public Favoritados()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Label2Click(object sender, EventArgs e)
		{
	
		}
		void Label3Click(object sender, EventArgs e)
		{
	
		}
		void Label4Click(object sender, EventArgs e)
		{
	
		}
		void HScrollBar1Scroll(object sender, ScrollEventArgs e)
		{
	
		}
		void Label8Click(object sender, EventArgs e)
		{
	
			Pagina_Inicial tela = new Pagina_Inicial();
			tela.Show();
			this.Hide();
		}
	}
}
