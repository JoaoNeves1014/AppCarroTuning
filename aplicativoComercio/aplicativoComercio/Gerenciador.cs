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
		void Button1Click(object sender, EventArgs e)
		{
			string ModVeiculo = textBox1.Text;
			string MotVeiculo = textBox2.Text;
			MessageBox.Show("Veículo cadastrado com sucesso!");
			Cadastrados cad = new Cadastrados();
			cad.ModeloVeiculoCadastrado = textBox1.Text;
			cad.MotorizacaoVeiculoCadastrado = textBox2.Text;
			cad.AnoVeiculoCadastrado = maskedTextBox1.Text;
		}
		void Button3Click(object sender, EventArgs e)
		{
			MessageBox.Show("Peça cadastrada com sucesso!");
			Cadastrados cad = new Cadastrados();
			cad.NomeUtilidadePecaCadastrada = textBox3.Text;
			cad.LocalModeloPecaCadastrada = textBox4.Text;
			cad.AnoPecaCadastrada = maskedTextBox2.Text;
		}
	}
}
