/*
 * Created by SharpDevelop.
 * User: 1068441
 * Date: 10/03/2026
 * Time: 13:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace aplicativoComercio
{
	/// <summary>
	/// Description of Login2.
	/// </summary>
	public partial class Login2 : Form
	{
		public Login2()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		
		
		
	    
		}
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{

		}
		void Label3Click(object sender, EventArgs e)
		{
	
		}
		int tentativas = 3;
		void BtnLoginClick(object sender, EventArgs e)
		{
	
			if(txtEmail.Text == "" || txtSenha.Text == ""){
			
				MessageBox.Show("Digite o Email: ");
				txtEmail.Focus();
				txtSenha.Focus();
				return;
			}
			
			else if (!txtEmail.Text.Contains("@gmail.com")){
			MessageBox.Show("Digite um email válido");
			    txtEmail.Focus();
			   	return;

			}
			
			else if (txtEmail.Text == "admin@gmail.com" && txtSenha.Text == "1234"){
				MessageBox.Show("Login Realizado com sucesso!");
				Pagina_Inicial pf = new Pagina_Inicial();
				pf.Show();
				this.Hide();
			}
			
			else{
			tentativas --;
				MessageBox.Show("Login invalido");
				
				if(tentativas == 0)
				{
					MessageBox.Show("Sistema Bloqueado!");
					btnLogin.Enabled = false;
				}
			}
			
			
		}
		void Label4Click(object sender, EventArgs e)
		{
	
			Cadastro janela = new Cadastro();
			janela.Show();
			this.Hide();
		}
		void CheckBox1CheckedChanged(object sender, EventArgs e)
		{
	
			char caractere = checkBox1.Checked ? '\0' : '*';
		
			txtSenha.PasswordChar = caractere;
		}
	}
}
