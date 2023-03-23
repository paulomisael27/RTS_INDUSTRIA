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
    public partial class CadMaquina : Form
    {
        private string _strSQL = @"Data Source=TI\RTSSERVER;Initial Catalog=RTS INDUSTRIA;User ID=administrador;Password=154154";
        SqlConnection conn = new SqlConnection(@"Data Source=TI\RTSSERVER;Initial Catalog=RTS INDUSTRIA;User ID=administrador;Password=154154");
        SqlCommand comando = new SqlCommand();
        SqlConnection objConect = null;
        SqlCommand objCommand = null;
        public CadMaquina()
        {
            InitializeComponent();
        }

        private void CarregarLista()
        {
            //ATUALIZA A LISTA DE REGISTRO

            string strConexao = "select * from CadastroMaquina";
            objConect = new SqlConnection(_strSQL);
            objCommand = new SqlCommand(strConexao, objConect);
            try
            {
                SqlDataAdapter objAdp = new SqlDataAdapter(objCommand);
                DataTable dtlista = new DataTable();
                objAdp.Fill(dtlista);
                dgvMaquinas.DataSource = dtlista;
            }
            catch
            {
                MessageBox.Show("Erro!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtCodMaquina.Text = "";
            txtItemMaquina.Text = "";
            txtPrecoMaquina.Text = "";
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            //REGISTRA NA TABELA CadastroProduto
            if (txtCodMaquina.Text != "" & txtItemMaquina.Text != "" & txtPrecoMaquina.Text != "")
            {
                conn.Open();
                comando.Connection = conn;
                comando.CommandText = "INSERT INTO CadastroMaquina (COD_MAQUINA, ITEM_MAQUINA, PRECO) VALUES ('" + txtCodMaquina.Text + "', '" + txtItemMaquina.Text + "', '" + txtPrecoMaquina.Text + "')";
                comando.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Cadastrado com sucesso!", "Sucesso");

                txtID.Text = "";
                txtCodMaquina.Text = "";
                txtItemMaquina.Text = "";
                txtPrecoMaquina.Text = "";
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //DELETE NO DATABASE
            if (txtID.Text != "" & txtCodMaquina.Text != "" & txtItemMaquina.Text != "" & txtPrecoMaquina.Text != "")
            {
                conn.Open();
                comando.Connection = conn;
                comando.CommandText = "DELETE FROM CadastroMaquina WHERE ID = '" + txtID.Text + "' AND COD_MAQUINA = '" + txtCodMaquina.Text + "' AND ITEM_MAQUINA = '" + txtItemMaquina.Text + "' AND PRECO = '" + txtPrecoMaquina.Text + "'";
                comando.ExecuteNonQuery();
                conn.Close();

                CarregarLista();

                txtCodMaquina.Text = "";
                txtItemMaquina.Text = "";
                txtPrecoMaquina.Text = "";
                MessageBox.Show("Item excluido!", "Deletado");
            }
        }

        private void dgvMaquinas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtID.Text = dgvMaquinas.SelectedRows[0].Cells[0].Value.ToString();
            txtCodMaquina.Text = dgvMaquinas.SelectedRows[0].Cells[1].Value.ToString();
            txtItemMaquina.Text = dgvMaquinas.SelectedRows[0].Cells[2].Value.ToString();
            txtPrecoMaquina.Text = dgvMaquinas.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void CadMaquina_Load(object sender, EventArgs e)
        {
            CarregarLista();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //UPDATE NO DATABASE
            //PROBLEMA NA COLUNA ID
            if (txtID.Text != "" & txtCodMaquina.Text != "" & txtItemMaquina.Text != "" & txtPrecoMaquina.Text != "")
            {
                comando = new SqlCommand("UPDATE CadastroMaquina SET COD_MAQUINA=@COD_MAQUINA, ITEM_MAQUINA=@ITEM_MAQUINA, PRECO=@PRECO WHERE ID=@ID", conn);
                conn.Open();
                comando.Parameters.AddWithValue("@ID", txtID.Text);
                comando.Parameters.AddWithValue("@COD_MAQUINA", txtCodMaquina.Text);
                comando.Parameters.AddWithValue("@ITEM_MAQUINA", txtItemMaquina.Text);
                comando.Parameters.AddWithValue("@PRECO", txtPrecoMaquina.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show("Atualizado com sucesso!");
                conn.Close();

                CarregarLista();
            }
        }
    }
}