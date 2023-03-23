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
using FQXAutoMec.Visualização;

namespace FQXAutoMec.Módulos
{
    public partial class PedidoMenu : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=TI\RTSSERVER;Initial Catalog=RTS INDUSTRIA;User ID=administrador;Password=154154");
        SqlCommand comando = new SqlCommand();

        public PedidoMenu()
        {
            InitializeComponent();
        }

        private void ConferirQuantidadeM2()
        {
            //FAZ A CONFERÊNCIA DA QUANTIDADE DE M2
            if (Convert.ToDecimal(lblResultadoM2NFOP.Text) > 0)
                lblResultadoM2NFOP.BackColor = Color.Red;
            if (Convert.ToDecimal(lblResultadoM2NFOP.Text) < 0)
                lblResultadoM2NFOP.BackColor = Color.Red;
            if (Convert.ToDecimal(lblResultadoM2NFOP.Text) == 0)
                lblResultadoM2NFOP.BackColor = Color.Green;
        }

        private void ConferirQuantidadeKG()
        {
            //FAZ A CONFERÊNCIA DA QUANTIDADE DE KG
            if (Convert.ToDecimal(lblResultadoKG.Text) > 0)
                lblResultadoKG.BackColor = Color.Red;
            if (Convert.ToDecimal(lblResultadoKG.Text) < 0)
                lblResultadoKG.BackColor = Color.Red;
            if (Convert.ToDecimal(lblResultadoKG.Text) == 0)
                lblResultadoKG.BackColor = Color.Green;
        }

        private void CalculoM2NFOP()
        {
            //FAZ O CÁLCULO DO M2 NA NF
            try
            {
                    lblResultadoM2NFOP.Text =
                    (Convert.ToDecimal(txtQTDMNF.Text)
                    -
                    Convert.ToDecimal(txtQTDMOP.Text)).ToString();
            }
            catch
            {
                
            }
        }

        private void CalculoKGPROD()
        {
            //FAZ O CÁLCULO DO KG PRODUZIDO
            try
            {
                lblResultadoKG.Text =
                    (Convert.ToDecimal(txtQTDKG.Text)
                    -
                    Convert.ToDecimal(txtQtdKGProduzido.Text)).ToString();
            }
            catch
            {

            }
        }

        private void CalculoLinha1()
        {
            try
            {
                txtResultadoL1.Text = 
                    (Convert.ToDecimal(MKTBIntervalo.Text)
                    -
                    Convert.ToDecimal(MKTBHoraInicial.Text)
                    +
                    Convert.ToDecimal(MKTBHoraFinal.Text)
                    -
                    Convert.ToDecimal(MKTBRetorno.Text)
                    +
                    Convert.ToDecimal(MKTBRegulagem.Text)
                    +
                    Convert.ToDecimal(MKTBAjuste.Text)).ToString();
            }
            catch
            {

            }
        }

        private void CalculoLinha2()
        {
            try
            {
                txtResultadoL2.Text =
                    (Convert.ToDecimal(MKTBIntervalo2.Text)
                    -
                    Convert.ToDecimal(MKTBHoraInicial2.Text)
                    +
                    Convert.ToDecimal(MKTBHoraFinal2.Text)
                    -
                    Convert.ToDecimal(MKTBRetorno2.Text)).ToString();
            }
            catch
            {

            }
        }

        private void CalculoLinha3()
        {
            try
            {
                txtResultadoL3.Text =
                    (Convert.ToDecimal(MKTBIntervalo3.Text)
                    -
                    Convert.ToDecimal(MKTBHoraInicial3.Text)
                    +
                    Convert.ToDecimal(MKTBHoraFinal3.Text)
                    -
                    Convert.ToDecimal(MKTBRetorno3.Text)).ToString();
            }
            catch
            {

            }
        }

        private void CalculoLinha4()
        {
            try
            {
                txtResultadoL4.Text =
                    (Convert.ToDecimal(MKTBIntervalo4.Text)
                    -
                    Convert.ToDecimal(MKTBHoraInicial4.Text)
                    +
                    Convert.ToDecimal(MKTBHoraFinal4.Text)
                    -
                    Convert.ToDecimal(MKTBRetorno4.Text)).ToString();
            }
            catch
            {

            }
        }

        private void CalculoLinha5()
        {
            try
            {
                txtResultadoL5.Text =
                    (Convert.ToDecimal(MKTBIntervalo5.Text)
                    -
                    Convert.ToDecimal(MKTBHoraInicial5.Text)
                    +
                    Convert.ToDecimal(MKTBHoraFinal5.Text)
                    -
                    Convert.ToDecimal(MKTBRetorno5.Text)).ToString();
            }
            catch
            {

            }
        }

        private void CalculoLinha6()
        {
            try
            {
                txtResultadoL6.Text =
                    (Convert.ToDecimal(MKTBIntervalo6.Text)
                    -
                    Convert.ToDecimal(MKTBHoraInicial6.Text)
                    +
                    Convert.ToDecimal(MKTBHoraFinal6.Text)
                    -
                    Convert.ToDecimal(MKTBRetorno6.Text)).ToString();
            }
            catch
            {

            }
        }

        private void CalculoLinha7()
        {
            try
            {
                txtResultadoL7.Text =
                    (Convert.ToDecimal(MKTBIntervalo7.Text)
                    -
                    Convert.ToDecimal(MKTBHoraInicial7.Text)
                    +
                    Convert.ToDecimal(MKTBHoraFinal7.Text)
                    -
                    Convert.ToDecimal(MKTBRetorno7.Text)).ToString();
            }
            catch
            {

            }
        }

        private void CalculoTotalLinhas()
        {
            try
            {
                txtSaldoHoras.Text =
                    (Convert.ToDecimal(txtResultadoL1.Text)
                    +
                    Convert.ToDecimal(txtResultadoL2.Text)
                    +
                    Convert.ToDecimal(txtResultadoL3.Text)
                    +
                    Convert.ToDecimal(txtResultadoL4.Text)
                    +
                    Convert.ToDecimal(txtResultadoL5.Text)
                    +
                    Convert.ToDecimal(txtResultadoL6.Text)
                    +
                    Convert.ToDecimal(txtResultadoL7.Text)).ToString();
            }
            catch
            {

            }
        }

        private void btnClosePedido_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HoraIndividual HI = new HoraIndividual(txtNPedido.Text, cbxVendedorPed.Text, txtCliente.Text, txtProduto.Text, txtMaquina.Text, txtInsumoDetalhe.Text);
            if (Application.OpenForms.OfType<HoraIndividual>().Count() > 0)
            {
                HI.Focus();
                MessageBox.Show("A janela de Horários já está aberta", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                HI.Show();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            //HABILITA OS CAMPOS DA TELA PEDIDO
            txtPerdaKG.Enabled = true;
            txtNPedido.Enabled = true;
            cbxSituacaoPed.Enabled = true;
            txtCliente.Enabled = true;
            cbxVendedorPed.Enabled = true;
            txtCodigoProd.Enabled = true;
            cbxOperador.Enabled = true;
            cbxAux1.Enabled = true;
            cbxAux2.Enabled = true;
            txtCodInsumo.Enabled = true;
            txtCodigoMaq.Enabled = true;
            txtQTDKG.Enabled = true;
            txtQtdKGProduzido.Enabled = true;
            txtQTDMNF.Enabled = true;
            txtQTDMOP.Enabled = true;
            txtQtdRolos.Enabled = true;
            MKTBRegulagem.Enabled = true;
            MKTBAjuste.Enabled = true;
            MKTBData.Enabled = true;
            MKTBData2.Enabled = true;
            MKTBData3.Enabled = true;
            MKTBData4.Enabled = true;
            MKTBData5.Enabled = true;
            MKTBData6.Enabled = true;
            MKTBData7.Enabled = true;
            MKTBHoraInicial.Enabled = true;
            MKTBHoraInicial2.Enabled = true;
            MKTBHoraInicial3.Enabled = true;
            MKTBHoraInicial4.Enabled = true;
            MKTBHoraInicial5.Enabled = true;
            MKTBHoraInicial6.Enabled = true;
            MKTBHoraInicial7.Enabled = true;
            MKTBIntervalo.Enabled = true;
            MKTBIntervalo2.Enabled = true;
            MKTBIntervalo3.Enabled = true;
            MKTBIntervalo4.Enabled = true;
            MKTBIntervalo5.Enabled = true;
            MKTBIntervalo6.Enabled = true;
            MKTBIntervalo7.Enabled = true;
            MKTBRetorno.Enabled = true;
            MKTBRetorno2.Enabled = true;
            MKTBRetorno3.Enabled = true;
            MKTBRetorno4.Enabled = true;
            MKTBRetorno5.Enabled = true;
            MKTBRetorno6.Enabled = true;
            MKTBRetorno7.Enabled = true;
            MKTBHoraFinal.Enabled = true;
            MKTBHoraFinal2.Enabled = true;
            MKTBHoraFinal3.Enabled = true;
            MKTBHoraFinal4.Enabled = true;
            MKTBHoraFinal5.Enabled = true;
            MKTBHoraFinal6.Enabled = true;
            MKTBHoraFinal7.Enabled = true;
            txtCliente.Clear();
            txtCodigoMaq.Clear();
            txtCodigoProd.Clear();
            txtCodInsumo.Clear();
            txtIDPedido.Clear();
            txtInsumoDetalhe.Clear();
            txtMaquina.Clear();
            txtNPedido.Clear();
            txtPerdaKG.Clear();
            txtPrecoInsumo.Clear();
            txtProduto.Clear();
            txtQTDKG.Clear();
            txtQtdKGProduzido.Clear();
            txtQTDMNF.Clear();
            txtQTDMOP.Clear();
            txtQtdRolos.Clear();
            txtValorMaquina.Clear();
            txtResultadoL2.Text = "0";
            txtResultadoL3.Text = "0";
            txtResultadoL4.Text = "0";
            txtResultadoL5.Text = "0";
            txtResultadoL6.Text = "0";
            txtResultadoL7.Text = "0";
            MKTBData.Text = "00000000";
            MKTBData2.Text = "00000000";
            MKTBData3.Text = "00000000";
            MKTBData4.Text = "00000000";
            MKTBData5.Text = "00000000";
            MKTBData6.Text = "00000000";
            MKTBData7.Text = "00000000";
            MKTBHoraInicial.Text = "0000";
            MKTBHoraInicial2.Text = "0000";
            MKTBHoraInicial3.Text = "0000";
            MKTBHoraInicial4.Text = "0000";
            MKTBHoraInicial5.Text = "0000";
            MKTBHoraInicial6.Text = "0000";
            MKTBHoraInicial7.Text = "0000";
            MKTBIntervalo.Text = "0000";
            MKTBIntervalo2.Text = "0000";
            MKTBIntervalo3.Text = "0000";
            MKTBIntervalo4.Text = "0000";
            MKTBIntervalo5.Text = "0000";
            MKTBIntervalo6.Text = "0000";
            MKTBIntervalo7.Text = "0000";
            MKTBRetorno.Text = "0000";
            MKTBRetorno2.Text = "0000";
            MKTBRetorno3.Text = "0000";
            MKTBRetorno4.Text = "0000";
            MKTBRetorno5.Text = "0000";
            MKTBRetorno6.Text = "0000";
            MKTBRetorno7.Text = "0000";
            MKTBHoraFinal.Text = "0000";
            MKTBHoraFinal2.Text = "0000";
            MKTBHoraFinal3.Text = "0000";
            MKTBHoraFinal4.Text = "0000";
            MKTBHoraFinal5.Text = "0000";
            MKTBHoraFinal6.Text = "0000";
            MKTBHoraFinal7.Text = "0000";
            MKTBRegulagem.Text = "0000";
            MKTBAjuste.Text = "0000";
        }

        private void PedidoMenu_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'rTS_COLABOEADOR.Cadastro_Colaborador'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastro_ColaboradorTableAdapter.Fill(this.rTS_COLABOEADOR.Cadastro_Colaborador);
            // TODO: esta linha de código carrega dados na tabela 'rTS_VENDEDOR.Cadastro_Vendedor'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastro_VendedorTableAdapter.Fill(this.rTS_VENDEDOR.Cadastro_Vendedor);
            CalculoTotalLinhas();
        }

        private void txtQTDMNF_TextChanged(object sender, EventArgs e)
        {
            CalculoM2NFOP();
            ConferirQuantidadeM2();
        }

        private void txtQTDMOP_TextChanged(object sender, EventArgs e)
        {
            CalculoM2NFOP();
            ConferirQuantidadeM2();
        }

        private void txtQTDKG_TextChanged(object sender, EventArgs e)
        {
            CalculoKGPROD();
            ConferirQuantidadeKG();
        }

        private void txtQtdKGProduzido_TextChanged(object sender, EventArgs e)
        {
            CalculoKGPROD();
            ConferirQuantidadeKG();
        }

        private void txtCodigoProd_TextChanged(object sender, EventArgs e)
        {
            //ATUALIZA AS BUSCAS PELOS DADOS
            timer_BuscaDados.Enabled = false;
            timer_BuscaDados.Enabled = true;
            txtProduto.Text = ObterDadosProduto(txtCodigoProd.Text);
        }

        private void timer_BuscaDados_Tick(object sender, EventArgs e)
        {
            timer_BuscaDados.Enabled = false;
        }

        private string ObterDadosProduto(string codprod)
        {
            //BUSCA OS DADOS DO PRODUTO E COLOCA NA TEXTBOX
            string produto = "";
            SqlConnection conn = new SqlConnection(@"Data Source=TI\RTSSERVER;Initial Catalog=RTS INDUSTRIA;User ID=administrador;Password=154154");
            string query = "SELECT NOME_PRODUTO FROM CadastroProduto WHERE CODPROD=@CODPROD";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@CODPROD", codprod);
            conn.Open();
            SqlDataReader leitor1 = cmd.ExecuteReader();
            if (leitor1.HasRows)
            {
                leitor1.Read();
                produto = leitor1["NOME_PRODUTO"].ToString();
            }
            conn.Close();
            return produto;
        }

        private string ObterInsumo(string CODINSUMO)
        {
            //BUSCA O CÓDIGO DO INSUMO E COLOCA NA TEXTBOX
            string insumo = "";
            SqlConnection conn = new SqlConnection(@"Data Source=TI\RTSSERVER;Initial Catalog=RTS INDUSTRIA;User ID=administrador;Password=154154");
            string query = "SELECT INSUMO FROM CadastroInsumo WHERE CODCADASTRO=@CODCADASTRO";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@CODCADASTRO", CODINSUMO);
            conn.Open();
            SqlDataReader buscainsumo = cmd.ExecuteReader();
            if (buscainsumo.HasRows)
            {
                buscainsumo.Read();
                insumo = buscainsumo["INSUMO"].ToString();
            }
            conn.Close();
            return insumo;
        }

        private string ObterInsumo2(string CODINSUMO)
        {
            //BUSCA O CÓDIGO DO INSUMO E COLOCA NA TEXTBOX
            string insumo = "";
            SqlConnection conn = new SqlConnection(@"Data Source=TI\RTSSERVER;Initial Catalog=RTS INDUSTRIA;User ID=administrador;Password=154154");
            string query = "SELECT PRECO_INSUMO FROM CadastroInsumo WHERE CODCADASTRO=@CODCADASTRO";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@CODCADASTRO", CODINSUMO);
            conn.Open();
            SqlDataReader buscainsumo = cmd.ExecuteReader();
            if (buscainsumo.HasRows)
            {
                buscainsumo.Read();
                insumo = buscainsumo["PRECO_INSUMO"].ToString();
            }
            conn.Close();
            return insumo;
        }

        private string ObterMaquina(string COD_MAQUINA)
        {
            //BUSCA O CÓDIGO DA MAQUINA E COLOCA NA TEXTBOX
            string maquina = "";
            SqlConnection conn = new SqlConnection(@"Data Source=TI\RTSSERVER;Initial Catalog=RTS INDUSTRIA;User ID=administrador;Password=154154");
            string query = "SELECT ITEM_MAQUINA FROM CadastroMaquina WHERE COD_MAQUINA=@COD_MAQUINA";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@COD_MAQUINA", COD_MAQUINA);
            conn.Open();
            SqlDataReader buscamaquina = cmd.ExecuteReader();
            if (buscamaquina.HasRows)
            {
                buscamaquina.Read();
                maquina = buscamaquina["ITEM_MAQUINA"].ToString();
            }
            conn.Close();
            return maquina;
        }

        private string ObterMaquina2(string CODMAQUINA)
        {
            //BUSCA O PRECO DA MAQUINA E COLOCA NA TEXTBOX
            string maquina2 = "";
            SqlConnection conn = new SqlConnection(@"Data Source=TI\RTSSERVER;Initial Catalog=RTS INDUSTRIA;User ID=administrador;Password=154154");
            string query = "SELECT PRECO FROM CadastroMaquina WHERE COD_MAQUINA=@COD_MAQUINA";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@COD_MAQUINA", CODMAQUINA);
            conn.Open();
            SqlDataReader buscamaquina2 = cmd.ExecuteReader();
            if (buscamaquina2.HasRows)
            {
                buscamaquina2.Read();
                maquina2 = buscamaquina2["PRECO"].ToString();
            }
            conn.Close();
            return maquina2;
        }

        private void timer_BuscaPedido_Tick(object sender, EventArgs e)
        {
            timer_BuscaPedido.Enabled = false;
        }

        private void btnInserirPedido_Click(object sender, EventArgs e)
        {
            if (txtNPedido.Text != "" & txtCliente.Text != "" & cbxSituacaoPed.Text != "" & cbxVendedorPed.Text != "" & txtCodigoProd.Text != "" & txtProduto.Text != "" & cbxOperador.Text != "" & cbxAux1.Text != "" & cbxAux2.Text != "" & txtCodInsumo.Text != "" & txtInsumoDetalhe.Text != "" & txtPrecoInsumo.Text != "" & txtCodigoMaq.Text != "" & txtMaquina.Text != "" & txtValorMaquina.Text != "" & txtQTDMNF.Text != "" & txtQTDMOP.Text != "" & txtQtdRolos.Text != "" & txtQTDKG.Text != "" & txtQtdKGProduzido.Text != "" & txtPerdaKG.Text != "" & MKTBAjuste.Text != "" & MKTBRegulagem.Text != "" & txtSaldoHoras.Text != "")
            {
                conn.Open();
                comando.Connection = conn;
                comando.CommandText = "INSERT INTO tbl_REGISTRAPEDIDO (NPEDIDO, CLIENTE, SITUACAO, VENDEDOR, CODPROD, PRODUTO, OPERADOR, AUXILIAR1, AUXILIAR2, CODINSUMO, INSUMO, PRECOINSUMO, CODMAQUINA, MAQUINA, CUSTOMAQUINARIO, QTDM2_NF, QTDM2_OP, QTDROLOS, QTDKG, QTDKGPRODUZIDO, PERDAKG, TEMPO_AJUSTE, TEMPO_REGULAGEM, SALDO_HORAS) VALUES ('" + txtNPedido.Text + "', '" + txtCliente.Text + "', '" + cbxSituacaoPed.Text + "', '" + cbxVendedorPed.Text + "', '" + txtCodigoProd.Text + "', '" + txtProduto.Text + "', '" + cbxOperador.Text + "', '" + cbxAux1.Text + "', '" + cbxAux2.Text + "', '" + txtCodInsumo.Text + "', '" + txtInsumoDetalhe.Text + "', '" + txtPrecoInsumo.Text + "', '" + txtCodigoMaq.Text + "', '" + txtMaquina.Text + "', '" + txtValorMaquina.Text + "', '" + txtQTDMNF.Text + "', '" + txtQTDMOP.Text + "', '" + txtQtdRolos.Text + "', '" + txtQTDKG.Text + "', '" + txtQtdKGProduzido.Text + "', '" + txtPerdaKG.Text + "', '" + MKTBAjuste.Text + "', '" + MKTBRegulagem.Text + "', '" + txtSaldoHoras.Text + "')";
                comando.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Registrado com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNPedido.Text = "";
                txtCliente.Text = "";
                txtCodigoMaq.Text = "";
                txtCodigoProd.Text = "";
                txtCodInsumo.Text = "";
                txtQTDKG.Text = "";
                txtQtdKGProduzido.Text = "";
                txtPerdaKG.Text = "";
                txtQTDMNF.Text = "";
                txtQTDMOP.Text = "";
                txtQtdRolos.Text = "";
            }
        }

        private void txtCodigoMaq_TextChanged(object sender, EventArgs e)
        {
            //ATUALIZA AS BUSCAS PELOS DADOS
            timer_BuscaDados.Enabled = false;
            timer_BuscaDados.Enabled = true;
            txtMaquina.Text = ObterMaquina(txtCodigoMaq.Text);
            txtValorMaquina.Text = ObterMaquina2(txtCodigoMaq.Text);
        }

        private void txtCodInsumo_TextChanged(object sender, EventArgs e)
        {
            //ATUALIZA AS BUSCAS PELOS DADOS
            timer_BuscaDados.Enabled = false;
            timer_BuscaDados.Enabled = true;
            txtInsumoDetalhe.Text = ObterInsumo(txtCodInsumo.Text);
            txtPrecoInsumo.Text = ObterInsumo2(txtCodInsumo.Text);
        }

        private void btnAbrirLinha_Click(object sender, EventArgs e)
        {
            MKTBData2.Visible = true;
            MKTBHoraInicial2.Visible = true;
            MKTBIntervalo2.Visible = true;
            MKTBRetorno2.Visible = true;
            MKTBHoraFinal2.Visible = true;
            btnAbrirLinha2.Visible = true;
        }

        private void btnAbrirLinha2_Click(object sender, EventArgs e)
        {
            MKTBData3.Visible = true;
            MKTBHoraInicial3.Visible = true;
            MKTBIntervalo3.Visible = true;
            MKTBRetorno3.Visible = true;
            MKTBHoraFinal3.Visible = true;
            btnAbrirLinha3.Visible = true;
        }

        private void btnAbrirLinha3_Click(object sender, EventArgs e)
        {
            MKTBData4.Visible = true;
            MKTBHoraInicial4.Visible = true;
            MKTBIntervalo4.Visible = true;
            MKTBRetorno4.Visible = true;
            MKTBHoraFinal4.Visible = true;
            btnAbrirLinha4.Visible = true;
        }

        private void btnAbrirLinha4_Click(object sender, EventArgs e)
        {
            MKTBData5.Visible = true;
            MKTBHoraInicial5.Visible = true;
            MKTBIntervalo5.Visible = true;
            MKTBRetorno5.Visible = true;
            MKTBHoraFinal5.Visible = true;
            btnAbrirLinha5.Visible = true;
        }

        private void btnAbrirLinha5_Click(object sender, EventArgs e)
        {
            MKTBData6.Visible = true;
            MKTBHoraInicial6.Visible = true;
            MKTBIntervalo6.Visible = true;
            MKTBRetorno6.Visible = true;
            MKTBHoraFinal6.Visible = true;
            btnAbrirLinha6.Visible = true;
        }

        private void btnAbrirLinha6_Click(object sender, EventArgs e)
        {
            MKTBData7.Visible = true;
            MKTBHoraInicial7.Visible = true;
            MKTBIntervalo7.Visible = true;
            MKTBRetorno7.Visible = true;
            MKTBHoraFinal7.Visible = true;
            btnRemoverLinhas.Visible = true;
        }

        private void btnRemoverLinhas_Click(object sender, EventArgs e)
        {
            MKTBData2.Visible = false;
            MKTBData3.Visible = false;
            MKTBData4.Visible = false;
            MKTBData5.Visible = false;
            MKTBData6.Visible = false;
            MKTBData7.Visible = false;
            MKTBHoraInicial2.Visible = false;
            MKTBHoraInicial3.Visible = false;
            MKTBHoraInicial4.Visible = false;
            MKTBHoraInicial5.Visible = false;
            MKTBHoraInicial6.Visible = false;
            MKTBHoraInicial7.Visible = false;
            MKTBIntervalo2.Visible = false;
            MKTBIntervalo3.Visible = false;
            MKTBIntervalo4.Visible = false;
            MKTBIntervalo5.Visible = false;
            MKTBIntervalo6.Visible = false;
            MKTBIntervalo7.Visible = false;
            MKTBRetorno2.Visible = false;
            MKTBRetorno3.Visible = false;
            MKTBRetorno4.Visible = false;
            MKTBRetorno5.Visible = false;
            MKTBRetorno6.Visible = false;
            MKTBRetorno7.Visible = false;
            MKTBHoraFinal2.Visible = false;
            MKTBHoraFinal3.Visible = false;
            MKTBHoraFinal4.Visible = false;
            MKTBHoraFinal5.Visible = false;
            MKTBHoraFinal6.Visible = false;
            MKTBHoraFinal7.Visible = false;
            btnAbrirLinha2.Visible = false;
            btnAbrirLinha3.Visible = false;
            btnAbrirLinha4.Visible = false;
            btnAbrirLinha5.Visible = false;
            btnAbrirLinha6.Visible = false;
            btnRemoverLinhas.Visible = false;
        }

        private void MKTBHoraInicial_TextChanged(object sender, EventArgs e)
        {
            CalculoLinha1();
        }

        private void MKTBHoraFinal_TextChanged(object sender, EventArgs e)
        {
            CalculoLinha1();
        }

        private void MKTBIntervalo_TextChanged(object sender, EventArgs e)
        {
            CalculoLinha1();
        }

        private void MKTBRetorno_TextChanged(object sender, EventArgs e)
        {
            CalculoLinha1();
        }

        private void MKTBRegulagem_TextChanged(object sender, EventArgs e)
        {
            CalculoLinha1();
        }

        private void MKTBAjuste_TextChanged(object sender, EventArgs e)
        {
            CalculoLinha1();
        }

        private void MKTBHoraInicial2_TextChanged(object sender, EventArgs e)
        {
            CalculoLinha2();
        }

        private void MKTBIntervalo2_TextChanged(object sender, EventArgs e)
        {
            CalculoLinha2();
        }

        private void MKTBRetorno2_TextChanged(object sender, EventArgs e)
        {
            CalculoLinha2();
        }

        private void MKTBHoraFinal2_TextChanged(object sender, EventArgs e)
        {
            CalculoLinha2();
        }

        private void MKTBHoraInicial3_TextChanged(object sender, EventArgs e)
        {
            CalculoLinha3();
        }

        private void MKTBIntervalo3_TextChanged(object sender, EventArgs e)
        {
            CalculoLinha3();
        }

        private void MKTBRetorno3_TextChanged(object sender, EventArgs e)
        {
            CalculoLinha3();
        }

        private void MKTBHoraFinal3_TextChanged(object sender, EventArgs e)
        {
            CalculoLinha3();
        }

        private void MKTBHoraInicial4_TextChanged(object sender, EventArgs e)
        {
            CalculoLinha4();
        }

        private void MKTBIntervalo4_TextChanged(object sender, EventArgs e)
        {
            CalculoLinha4();
        }

        private void MKTBRetorno4_TextChanged(object sender, EventArgs e)
        {
            CalculoLinha4();
        }

        private void MKTBHoraFinal4_TextChanged(object sender, EventArgs e)
        {
            CalculoLinha4();
        }

        private void MKTBHoraInicial5_TextChanged(object sender, EventArgs e)
        {
            CalculoLinha5();
        }

        private void MKTBIntervalo5_TextChanged(object sender, EventArgs e)
        {
            CalculoLinha5();
        }

        private void MKTBRetorno5_TextChanged(object sender, EventArgs e)
        {
            CalculoLinha5();
        }

        private void MKTBHoraFinal5_TextChanged(object sender, EventArgs e)
        {
            CalculoLinha5();
        }

        private void MKTBHoraInicial6_TextChanged(object sender, EventArgs e)
        {
            CalculoLinha6();
        }

        private void MKTBIntervalo6_TextChanged(object sender, EventArgs e)
        {
            CalculoLinha6();
        }

        private void MKTBRetorno6_TextChanged(object sender, EventArgs e)
        {
            CalculoLinha6();
        }

        private void MKTBHoraFinal6_TextChanged(object sender, EventArgs e)
        {
            CalculoLinha6();
        }

        private void MKTBHoraInicial7_TextChanged(object sender, EventArgs e)
        {
            CalculoLinha7();
        }

        private void MKTBIntervalo7_TextChanged(object sender, EventArgs e)
        {
            CalculoLinha7();
        }

        private void MKTBRetorno7_TextChanged(object sender, EventArgs e)
        {
            CalculoLinha7();
        }

        private void MKTBHoraFinal7_TextChanged(object sender, EventArgs e)
        {
            CalculoLinha7();
        }

        private void txtResultadoL1_TextChanged(object sender, EventArgs e)
        {
            CalculoTotalLinhas();
        }

        private void txtResultadoL2_TextChanged(object sender, EventArgs e)
        {
            CalculoTotalLinhas();
        }

        private void txtResultadoL3_TextChanged(object sender, EventArgs e)
        {
            CalculoTotalLinhas();
        }

        private void txtResultadoL4_TextChanged(object sender, EventArgs e)
        {
            CalculoTotalLinhas();
        }

        private void txtResultadoL5_TextChanged(object sender, EventArgs e)
        {
            CalculoTotalLinhas();
        }

        private void txtResultadoL6_TextChanged(object sender, EventArgs e)
        {
            CalculoTotalLinhas();
        }

        private void txtResultadoL7_TextChanged(object sender, EventArgs e)
        {
            CalculoTotalLinhas();
        }
    }
}