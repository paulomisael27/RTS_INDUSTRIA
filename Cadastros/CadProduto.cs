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

namespace FQXAutoMec.Cadastros
{
    public partial class CadProduto : Form
    {
        //CONEXAO COM O SQL
        private string _strSQL = @"Data Source=TI\RTSSERVER;Initial Catalog=RTS INDUSTRIA;User ID=administrador;Password=154154";
        SqlConnection conn = new SqlConnection(@"Data Source=TI\RTSSERVER;Initial Catalog=RTS INDUSTRIA;User ID=administrador;Password=154154");
        SqlCommand comando = new SqlCommand();
        SqlConnection objConect = null;
        SqlCommand objCommand = null;

        public CadProduto()
        {
            InitializeComponent();       
        }

        private void CarregarLista()
        {
            //ATUALIZA A LISTA DE REGISTRO

            string strConexao = "select * from CadastroProduto";
            objConect = new SqlConnection(_strSQL);
            objCommand = new SqlCommand(strConexao, objConect);
            try
            {
                SqlDataAdapter objAdp = new SqlDataAdapter(objCommand);
                DataTable dtlista = new DataTable();
                objAdp.Fill(dtlista);
                dgvUltimosProd.DataSource = dtlista;
            }
            catch
            {
                MessageBox.Show("Erro!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtCadProduto.Text = "";
            txtCodProduto.Text = "";
            txtFioTela.Text = "";
            txtMalhaTela.Text = "";
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            //REGISTRA NA TABELA CadastroProduto

            if (txtCadProduto.Text != "" & cbxModeloTela.Text != "" & cbxTipoFio.Text != "" & txtFioTela.Text != "" & txtMalhaTela.Text != "")
            {
                conn.Open();
                comando.Connection = conn;
                comando.CommandText = "INSERT INTO CadastroProduto (NOME_PRODUTO, MODELO_TELA, TIPO_FIO, FIO_TELA, MALHA) VALUES ('" + txtCadProduto.Text + "', '" + cbxModeloTela.Text + "', '" + cbxTipoFio.Text + "', '" + txtFioTela.Text + "', '" + txtMalhaTela.Text + "')";
                comando.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Cadastrado com sucesso!");

                
            }
        }

        private void CadProduto_Load(object sender, EventArgs e)
        {
            CarregarLista();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //DELETE NO DATABASE
            if (txtCodProduto.Text !="" & txtCadProduto.Text != "" & txtFioTela.Text != "" & txtMalhaTela.Text != "")
            {
                conn.Open();
                comando.Connection = conn;
                comando.CommandText = "DELETE FROM CadastroProduto WHERE CODPROD = '" + txtCodProduto.Text + "' AND NOME_PRODUTO = '" + txtCadProduto.Text + "' AND FIO_TELA = '" + txtFioTela.Text + "' AND MALHA = '" + txtMalhaTela.Text + "'";
                comando.ExecuteNonQuery();
                conn.Close();

                txtCadProduto.Text = "";
                txtMalhaTela.Text = "";
                txtFioTela.Text = "";               
                MessageBox.Show("Item excluido!", "Deletado");
            }
        }

        private void dgvUltimosProd_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtCodProduto.Text = dgvUltimosProd.SelectedRows[0].Cells[0].Value.ToString();
            txtCadProduto.Text = dgvUltimosProd.SelectedRows[0].Cells[1].Value.ToString();
            cbxModeloTela.Text = dgvUltimosProd.SelectedRows[0].Cells[2].Value.ToString();
            cbxTipoFio.Text = dgvUltimosProd.SelectedRows[0].Cells[3].Value.ToString();
            txtFioTela.Text = dgvUltimosProd.SelectedRows[0].Cells[4].Value.ToString();
            txtMalhaTela.Text = dgvUltimosProd.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //UPDATE NO DATABASE
            if (txtCodProduto.Text != "" & txtCadProduto.Text != "" & cbxModeloTela.Text != "" & cbxTipoFio.Text != "" & txtFioTela.Text != "" & txtMalhaTela.Text != "")
            {
                comando = new SqlCommand("UPDATE CadastroProduto SET NOME_PRODUTO=@NOME_PRODUTO, MODELO_TELA=@MODELO_TELA, TIPO_FIO=@TIPO_FIO, FIO_TELA=@FIO_TELA, MALHA=@MALHA WHERE CODPROD=@CODPROD", conn);
                conn.Open();
                comando.Parameters.AddWithValue("@CODPROD", txtCodProduto.Text);
                comando.Parameters.AddWithValue("@NOME_PRODUTO", txtCadProduto.Text);
                comando.Parameters.AddWithValue("@MODELO_TELA", cbxModeloTela.Text);
                comando.Parameters.AddWithValue("@TIPO_FIO", cbxTipoFio.Text);
                comando.Parameters.AddWithValue("@FIO_TELA", txtFioTela.Text);
                comando.Parameters.AddWithValue("@MALHA", txtMalhaTela.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show("Atualizado com sucesso!");
                conn.Close();
                CarregarLista();
            }
        }
    }
}