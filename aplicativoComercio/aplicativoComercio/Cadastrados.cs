/*
 * Created by SharpDevelop.
 * User: 1068441
 * Date: 04/03/2026
 * Time: 14:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace aplicativoComercio
{
	/// <summary>
	/// Description of Cadastrados.
	/// </summary>
	public partial class Cadastrados : Form
	{
		//informações do veículo
		public string ModeloVeiculoCadastrado;
		public string MotorizacaoVeiculoCadastrado;
		public string AnoVeiculoCadastrado;
		
		//informações da peça
		public string NomeUtilidadePecaCadastrada;
		public string LocalModeloPecaCadastrada;
		public string AnoPecaCadastrada;
		
		public Cadastrados()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void PictureBox3Click(object sender, EventArgs e)
		{
	
			Favoritados tela = new Favoritados();
			tela.Show();
			this.Hide();
			
			
		}
		void Label8Click(object sender, EventArgs e)
		{
	
			Pagina_Inicial tela = new Pagina_Inicial();
			tela.Show();
			this.Hide();
		}
		void Label9Click(object sender, EventArgs e)
		{
	
			Favoritados tela = new Favoritados();
			tela.Show();
			this.Hide();
			
		}
		void CadastradosLoad(object sender, EventArgs e)
		{
			chamaDadosVeiculo();
		}

		void chamaDadosVeiculo()
		{
			
		}
		void PictureBox2Click(object sender, EventArgs e)
		{
	
			Favoritados tela = new Favoritados();
			tela.Show();
			this.Hide();
		}
	}
}
