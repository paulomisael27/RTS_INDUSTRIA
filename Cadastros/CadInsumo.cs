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
    public partial class CadInsumo : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=TI\RTSSERVER;Initial Catalog=RTS INDUSTRIA;User ID=administrador;Password=154154");
        SqlCommand comando = new SqlCommand();

        public CadInsumo()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCod.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtInsumo.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtPreco.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtCodInsumo.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void btnInserir_Click_1(object sender, EventArgs e)
        {
            //REGISTRA NA TABELA CadastroInsumo

            if (txtInsumo.Text != "" & txtPreco.Text != "" & txtCod.Text != "")
            {
                conn.Open();
                comando.Connection = conn;
                comando.CommandText = "INSERT INTO CadastroInsumo (INSUMO, PRECO_INSUMO, CODCADASTRO) VALUES ('" + txtInsumo.Text + "', '" + txtPreco.Text + "', '" + txtCod.Text + "')";
                comando.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Cadastrado com sucesso!", "Sucesso");
                txtInsumo.Clear();
                txtCodInsumo.Clear();
                txtPreco.Clear();
            }
        }
    }
}