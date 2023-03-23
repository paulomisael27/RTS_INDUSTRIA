using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using FQXAutoMec.TelaCarregamento;

namespace FQXAutoMec
{
    public partial class Home : Form
    {
        //referencia da conexao sql
        SqlConnection Conexao = new SqlConnection(@"Data Source=TI\RTSSERVER;Initial Catalog=RTS INDUSTRIA;User ID=administrador;Password=154154");
        public Home()
        {
            InitializeComponent();
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void btnLogar_Click(object sender, EventArgs e)
        {
            Conexao.Open();//abre conexao
            string query = "SELECT * FROM tbl_USUARIO where LOGIN = '" + txtUsuarioLogin.Text + "' AND SENHA = '" + txtSenhaLogin.Text + "'";
            SqlDataAdapter dp = new SqlDataAdapter(query, Conexao);
            DataTable dt = new DataTable();
            dp.Fill(dt);
            if(dt.Rows.Count == 1)
            {
                this.Hide();
                Welcome bemvindo = new Welcome();
                bemvindo.ShowDialog();
                Conexao.Close();
                MenuPrincipal MP = new MenuPrincipal(txtUsuarioLogin.Text,tbxCargo.Text);
                MP.Show();
            }
            else
            {
                MessageBox.Show("usuário ou senha incorreto", "Falha no login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUsuarioLogin_Click(object sender, EventArgs e)
        {
            txtUsuarioLogin.Text = "";
        }

        private void txtSenhaLogin_Click(object sender, EventArgs e)
        {
            txtSenhaLogin.Text = "";
        }

        private void txtUsuarioLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
        }

        private void btnFecharHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizarHome_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlVerificaStatus_DoubleClick(object sender, EventArgs e)
        {
            VerificaServer VS = new VerificaServer();
            VS.Show();
        }

        private string ObterFuncao(string login)
        {
            string funcao = "";
            SqlConnection conn = new SqlConnection(@"Data Source=TI\RTSSERVER;Initial Catalog=RTS INDUSTRIA;User ID=administrador;Password=154154");
            string query = "SELECT funcao FROM tbl_USUARIO WHERE LOGIN=@LOGIN";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@LOGIN", login);
            conn.Open();
            SqlDataReader ObterFuncao = cmd.ExecuteReader();
            if (ObterFuncao.HasRows)
            {
                ObterFuncao.Read();
                funcao = ObterFuncao["FUNCAO"].ToString();
            }
            conn.Close();
            return funcao;
        }

        private void txtUsuarioLogin_TextChanged(object sender, EventArgs e)
        {
            tbxCargo.Text = ObterFuncao(txtUsuarioLogin.Text);
        }
    }
}