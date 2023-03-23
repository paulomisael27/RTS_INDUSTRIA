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

namespace FQXAutoMec.Módulos
{
    public partial class HoraIndividual : Form
    {
        //CONEXAO COM O SQL
        private string _strSQL = @"Data Source=TI\RTSSERVER;Initial Catalog=RTS INDUSTRIA;User ID=administrador;Password=154154";
        SqlConnection conn = new SqlConnection(@"Data Source=TI\RTSSERVER;Initial Catalog=RTS INDUSTRIA;User ID=administrador;Password=154154");
        SqlCommand comando = new SqlCommand();
        SqlConnection objConect = null;
        SqlCommand objCommand = null;

        public HoraIndividual()
        {
            InitializeComponent();
        }
        public HoraIndividual(string valor1, string valor2, string valor3, string valor4, string valor5, string valor6)
        {
            InitializeComponent();
            txtPuxarPedido.Text = valor1;
            txtPuxarVendedor.Text = valor2;
            txtPuxarCliente.Text = valor3;
            txtPuxarProduto.Text = valor4;
            txtPuxarMaquina.Text = valor5;
            txtPuxarInsumoDetalhe.Text = valor6;
        }

        private void AtualizarLista()
        {
            //ATUALIZA A LISTA DE REGISTRO
            string strConexao = "SELECT * FROM HorarioIndividualColab";
            objConect = new SqlConnection(_strSQL);
            objCommand = new SqlCommand(strConexao, objConect);
            try
            {
                SqlDataAdapter objAdp = new SqlDataAdapter(objCommand);
                DataTable dtlista = new DataTable();
                objAdp.Fill(dtlista);
                dgvRegistroHoraInd.DataSource = dtlista;
            }
            catch
            {
                MessageBox.Show("Erro!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalcHorasTrab()
        {
            //FAZ O CALCULO DA HORA INICIAL E HORA FINAL
            try
            {
                MKTBHorasTrab.Text =
                    (Convert.ToDecimal(MKTBHoraFinal.Text)
                    -
                    Convert.ToDecimal(MKTBHoraInicial.Text)).ToString();
            }
            catch
            {

            }
        }
        private void CalTotalHoraIndividual()
        {
            try
            {
                txtTotalHI.Text =
                    (Convert.ToDecimal(MKTBTempAjuste.Text)
                    +
                    Convert.ToDecimal(MKTBTempRegulag.Text)
                    -
                    Convert.ToDecimal(MKTBHoraAlmoco.Text)
                    +
                    Convert.ToDecimal(MKTBHorasTrab.Text)).ToString();
            }
            catch
            {

            }
        }

        private void HoraIndividual_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'rTS_INDUSTRIADataSet2.tbl_FUNCAO'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_FUNCAOTableAdapter.Fill(this.rTS_INDUSTRIADataSet2.tbl_FUNCAO);
            // TODO: esta linha de código carrega dados na tabela 'rTS_INDUSTRIAData.Cadastro_Colaborador'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastro_ColaboradorTableAdapter.Fill(this.rTS_INDUSTRIAData.Cadastro_Colaborador);
            // TODO: esta linha de código carrega dados na tabela 'rTS_HorarioIndividualColab.HorarioIndividualColab'. Você pode movê-la ou removê-la conforme necessário.
            this.horarioIndividualColabTableAdapter.Fill(this.rTS_HorarioIndividualColab.HorarioIndividualColab);
        }
        private void btnInserirDados_Click(object sender, EventArgs e)
        {
            //REGISTRA OS DADOS NO BANCO DE DADOS
            if (MKTBDataInicio.Text != "" & MKTBHoraInicial.Text != "" & MKTBDataFinal.Text != "" & MKTBHoraFinal.Text != "" & cbxOperador.Text != "" & cbxFuncao.Text != "" & MKTBTempAjuste.Text != "" & MKTBTempRegulag.Text != "" & MKTBHoraAlmoco.Text != "" & MKTBHorasTrab.Text != "" & txtTotalHI.Text != "" & txtPuxarPedido.Text != "" & txtPuxarVendedor.Text != "" & txtPuxarCliente.Text != "" & txtPuxarProduto.Text != "" & txtPuxarMaquina.Text != "" & txtPuxarInsumoDetalhe.Text != "")
            {
                conn.Open();
                comando.CommandText = "INSERT INTO HorarioIndividualColab (DATAINICIO, HORAINICIO, DATAFINAL, HORAFINAL, COLABORADOR, FUNCAO, TEMPO_AJUSTE, TEMPO_REGULAGEM, HORA_ALMOÇO, HORA_TRAB, TOTAL_HORA, NPEDIDO, VENDEDOR, CLIENTE, PRODUTO, MAQUINA, INSUMO) VALUES ('" + MKTBDataInicio.Text + "', '" + MKTBHoraInicial.Text + "', '" + MKTBDataFinal.Text + "', '" + MKTBHoraFinal.Text + "', '" + cbxOperador.Text + "', '" + cbxFuncao.Text + "', '" + MKTBTempAjuste.Text + "', '" + MKTBTempRegulag.Text + "', '" + MKTBHoraAlmoco.Text + "', '" + MKTBHorasTrab.Text + "', '" + txtTotalHI.Text + "', '" + txtPuxarPedido.Text + "', '" + txtPuxarVendedor.Text + "', '" + txtPuxarCliente.Text + "', '" + txtPuxarProduto.Text + "', '" + txtPuxarMaquina.Text + "', '" + txtPuxarInsumoDetalhe.Text + "')";
                comando.ExecuteNonQuery();
                conn.Close();
                AtualizarLista();

                MKTBDataInicio.Text = "";
                MKTBHoraInicial.Text = "";
                MKTBDataFinal.Text = "";
                MKTBHoraFinal.Text = "";
                cbxOperador.Text = "";
                cbxFuncao.Text = "";
                MKTBTempAjuste.Text = "";
                MKTBTempRegulag.Text = "";
                MKTBHoraAlmoco.Text = "";
                MKTBHorasTrab.Text = "";
                txtTotalHI.Text = "";
                txtPuxarPedido.Text = "";
                txtPuxarVendedor.Text = "";
                txtPuxarCliente.Text = "";
                txtPuxarProduto.Text = "";
                txtPuxarMaquina.Text = "";
                txtPuxarInsumoDetalhe.Text = "";
            }
        }

        private void MKTBHoraInicial_TextChanged(object sender, EventArgs e)
        {
            CalcHorasTrab();
        }

        private void MKTBHoraFinal_TextChanged(object sender, EventArgs e)
        {
            CalcHorasTrab();
        }

        private void MKTBTempAjuste_TextChanged(object sender, EventArgs e)
        {
            CalTotalHoraIndividual();
        }

        private void MKTBTempRegulag_TextChanged(object sender, EventArgs e)
        {
            CalTotalHoraIndividual();
        }

        private void MKTBHoraAlmoco_TextChanged(object sender, EventArgs e)
        {
            CalTotalHoraIndividual();
        }

        private void MKTBHorasTrab_TextChanged(object sender, EventArgs e)
        {
            CalTotalHoraIndividual();
        }

        private void txtTotalHI_TextChanged(object sender, EventArgs e)
        {
            CalTotalHoraIndividual();
        }
        private void dgvRegistroHoraInd_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MKTBCOD.Text = dgvRegistroHoraInd.SelectedRows[0].Cells[0].Value.ToString();
            MKTBDataInicio.Text = dgvRegistroHoraInd.SelectedRows[0].Cells[1].Value.ToString();
            MKTBHoraInicial.Text = dgvRegistroHoraInd.SelectedRows[0].Cells[2].Value.ToString();
            MKTBDataFinal.Text = dgvRegistroHoraInd.SelectedRows[0].Cells[3].Value.ToString();
            MKTBHoraFinal.Text = dgvRegistroHoraInd.SelectedRows[0].Cells[4].Value.ToString();
            cbxOperador.Text = dgvRegistroHoraInd.SelectedRows[0].Cells[5].Value.ToString();
            cbxFuncao.Text = dgvRegistroHoraInd.SelectedRows[0].Cells[6].Value.ToString();
            MKTBTempAjuste.Text = dgvRegistroHoraInd.SelectedRows[0].Cells[7].Value.ToString();
            MKTBTempRegulag.Text = dgvRegistroHoraInd.SelectedRows[0].Cells[8].Value.ToString();
            MKTBHoraAlmoco.Text = dgvRegistroHoraInd.SelectedRows[0].Cells[9].Value.ToString();
            MKTBHorasTrab.Text = dgvRegistroHoraInd.SelectedRows[0].Cells[10].Value.ToString();
            txtTotalHI.Text = dgvRegistroHoraInd.SelectedRows[0].Cells[11].Value.ToString();
            txtPuxarPedido.Text = dgvRegistroHoraInd.SelectedRows[0].Cells[12].Value.ToString();
            txtPuxarVendedor.Text = dgvRegistroHoraInd.SelectedRows[0].Cells[13].Value.ToString();
            txtPuxarCliente.Text = dgvRegistroHoraInd.SelectedRows[0].Cells[14].Value.ToString();
            txtPuxarProduto.Text = dgvRegistroHoraInd.SelectedRows[0].Cells[15].Value.ToString();
            txtPuxarMaquina.Text = dgvRegistroHoraInd.SelectedRows[0].Cells[16].Value.ToString();
            txtPuxarInsumoDetalhe.Text = dgvRegistroHoraInd.SelectedRows[0].Cells[17].Value.ToString();
        }
        private void btnAlterarDados_Click(object sender, EventArgs e)
        {
            //UPDATE NO DATABASE
            if (MKTBCOD.Text != "" & MKTBDataInicio.Text != "" & MKTBHoraInicial.Text != "" & MKTBDataFinal.Text != "" & MKTBHoraFinal.Text != "" & cbxOperador.Text != "" & cbxFuncao.Text != "" & MKTBTempAjuste.Text != "" & MKTBTempRegulag.Text != "" & MKTBHoraAlmoco.Text != "" & MKTBHorasTrab.Text != "" & txtTotalHI.Text != "")
            {
                comando = new SqlCommand("UPDATE HorarioIndividualColab SET DATAINICIO=@DATAINICIO, HORAINICIO=@HORAINICIO, DATAFINAL=@DATAFINAL, HORAFINAL=@HORAFINAL, COLABORADOR=@COLABORADOR, FUNCAO=@FUNCAO, TEMPO_AJUSTE=@TEMPO_AJUSTE, TEMPO_REGULAGEM=@TEMPO_REGULAGEM, HORA_ALMOÇO=@HORA_ALMOÇO, HORA_TRAB=@HORA_TRAB, TOTAL_HORA=@TOTAL_HORA, NPEDIDO=@NPEDIDO, VENDEDOR=@VENDEDOR, CLIENTE=@CLIENTE, PRODUTO=@PRODUTO, MAQUINA=@MAQUINA, INSUMO=@INSUMO WHERE ID=@ID", conn);
                conn.Open();
                comando.Parameters.AddWithValue("@ID", MKTBCOD.Text);
                comando.Parameters.AddWithValue("@DATAINICIO", MKTBDataInicio.Text);
                comando.Parameters.AddWithValue("@HORAINICIO", MKTBHoraInicial.Text);
                comando.Parameters.AddWithValue("@DATAFINAL", MKTBDataFinal.Text);
                comando.Parameters.AddWithValue("@HORAFINAL", MKTBHoraFinal.Text);
                comando.Parameters.AddWithValue("@COLABORADOR", cbxOperador.Text);
                comando.Parameters.AddWithValue("@FUNCAO", cbxFuncao.Text);
                comando.Parameters.AddWithValue("@TEMPO_AJUSTE", MKTBTempAjuste.Text);
                comando.Parameters.AddWithValue("@TEMPO_REGULAGEM", MKTBTempRegulag.Text);
                comando.Parameters.AddWithValue("@HORA_ALMOÇO", MKTBHoraAlmoco.Text);
                comando.Parameters.AddWithValue("@HORA_TRAB", MKTBHorasTrab.Text);
                comando.Parameters.AddWithValue("@TOTAL_HORA", txtTotalHI.Text);
                comando.Parameters.AddWithValue("@NPEDIDO", txtPuxarPedido.Text);
                comando.Parameters.AddWithValue("@VENDEDOR", txtPuxarVendedor.Text);
                comando.Parameters.AddWithValue("@CLIENTE", txtPuxarCliente.Text);
                comando.Parameters.AddWithValue("@PRODUTO", txtPuxarProduto.Text);
                comando.Parameters.AddWithValue("@MAQUINA", txtPuxarMaquina.Text);
                comando.Parameters.AddWithValue("@INSUMO", txtPuxarInsumoDetalhe.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show("Atualizado com sucesso!");
                conn.Close();
                AtualizarLista();

                MKTBCOD.Text = "";
                MKTBDataInicio.Text = "";
                MKTBHoraInicial.Text = "";
                MKTBDataFinal.Text = "";
                MKTBHoraFinal.Text = "";
                cbxOperador.Text = "";
                cbxFuncao.Text = "";
                MKTBTempAjuste.Text = "";
                MKTBTempRegulag.Text = "";
                MKTBHoraAlmoco.Text = "";
                MKTBHorasTrab.Text = "";
                txtTotalHI.Text = "";
                txtPuxarPedido.Text = "";
                txtPuxarCliente.Text = "";
                txtPuxarProduto.Text = "";
                txtPuxarMaquina.Text = "";
                txtPuxarInsumoDetalhe.Text = "";
            }
        }
        private void btnExcluirDados_Click(object sender, EventArgs e)
        {
            //DELETE NO DATABASE
            if (MKTBCOD.Text != "" & MKTBDataInicio.Text != "" & MKTBHoraInicial.Text != "" & MKTBDataFinal.Text != "" & MKTBHoraFinal.Text != "" & cbxOperador.Text != "" & cbxFuncao.Text != "" & MKTBTempAjuste.Text != "" & MKTBTempRegulag.Text != "" & MKTBHoraAlmoco.Text != "" & MKTBHorasTrab.Text != "" & txtTotalHI.Text != "" & txtPuxarPedido.Text != "" & txtPuxarVendedor.Text != "" & txtPuxarCliente.Text != "" & txtPuxarProduto.Text != "" & txtPuxarMaquina.Text != "" & txtPuxarInsumoDetalhe.Text != "")
            {
                conn.Open();
                comando.CommandText = "DELETE FROM HorarioIndividualColab where ID = '" + MKTBCOD.Text + "' AND DATAINICIO = '" + MKTBDataInicio.Text + "' AND HORAINICIO = '" + MKTBHoraInicial.Text + "' AND DATAFINAL = '" + MKTBDataFinal.Text + "' AND HORAFINAL = '" + MKTBHoraFinal.Text + "' AND COLABORADOR = '" + cbxOperador.Text + "' AND FUNCAO = '" + cbxFuncao.Text + "' AND TEMPO_AJUSTE = '" + MKTBTempAjuste.Text + "' AND TEMPO_REGULAGEM = '" + MKTBTempRegulag.Text + "' AND HORA_ALMOÇO = '" + MKTBHoraAlmoco.Text + "' AND HORA_TRAB = '" + MKTBHorasTrab.Text + "' AND TOTAL_HORA = '" + txtTotalHI.Text + "' AND NPEDIDO = '" + txtPuxarPedido.Text + "' AND VENDEDOR = '" + txtPuxarVendedor.Text + "' AND CLIENTE = '" + txtPuxarCliente.Text + "' AND PRODUTO = '" + txtPuxarProduto.Text + "' AND MAQUINA = '" + txtPuxarMaquina.Text + "' AND INSUMO = '" + txtPuxarInsumoDetalhe.Text + "'";
                comando.ExecuteNonQuery();
                conn.Close();
                AtualizarLista();

                MKTBCOD.Text = "";
                MKTBDataInicio.Text = "";
                MKTBHoraInicial.Text = "";
                MKTBDataFinal.Text = "";
                MKTBHoraFinal.Text = "";
                cbxOperador.Text = "";
                cbxFuncao.Text = "";
                MKTBTempAjuste.Text = "";
                MKTBTempRegulag.Text = "";
                MKTBHoraAlmoco.Text = "";
                MKTBHorasTrab.Text = "";
                txtTotalHI.Text = "";
                txtPuxarPedido.Text = "";
                txtPuxarVendedor.Text = "";
                txtPuxarCliente.Text = "";
                txtPuxarProduto.Text = "";
                txtPuxarMaquina.Text = "";
                txtPuxarInsumoDetalhe.Text = "";
            }
        }
    }
}