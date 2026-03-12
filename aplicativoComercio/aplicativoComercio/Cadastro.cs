/*
 * Created by SharpDevelop.
 * User: 1068441
 * Date: 02/03/2026
 * Time: 14:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace aplicativoComercio
{
	/// <summary>
	/// Description of Cadastro.
	/// </summary>
	public partial class Cadastro : Form
	{
		public Cadastro()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Label6Click(object sender, EventArgs e)
		{
	
			Login2 tela = new Login2();
			tela.Show();
			this.Hide();
		}
		void Button1Click(object sender, EventArgs e)
		{
	
			if(txtSenha.Text.Length < 4)
			{
				MessageBox.Show("A senha deve conter no minimo 4 caracteres");
				txtSenha.Focus();
				return;
			}
			
			if(txtEmail.Text == "")
			{
				MessageBox.Show("Digite o email");
				txtSenha.Focus();
				return;
			}
			
			
			if(!txtEmail.Text.Contains("@gmail.com"))
			{
			   	MessageBox.Show("Digite um email válido");
			   	txtEmail.Focus();
			   	return;
			}
			   	
			  
		}
		void Label3Click(object sender, EventArgs e)
		{
	
		}
		void CheckMostrarCheckedChanged(object sender, EventArgs e)
		{
	
			char caractere = checkMostrar.Checked ? '\0' : '*';
			
			txtSenha.PasswordChar = caractere;
			txtConfirmar.PasswordChar = caractere;
		}
	}
}
