using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FQXAutoMec.Visualização
{
    public partial class DisplayInfo : Form
    {
        protected String _Coluna0, _Coluna1, _Coluna2, _Coluna3, _Coluna4, _Coluna5, _Coluna6, _Coluna7, _Coluna8, _Coluna9, _Coluna10, _Coluna11, _Coluna12, _Coluna13, _Coluna14,
            _Coluna15, _Coluna16, _Coluna17, _Coluna18, _Coluna19, _Coluna20, _Coluna21;

        private void btnAlterarRegistro_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public DisplayInfo()
        {
            InitializeComponent();
        }

        public DisplayInfo(string Coluna0, String Coluna1, String Coluna2, String Coluna3, String Coluna4, String Coluna5, String Coluna6, String Coluna7, String Coluna8,
            String Coluna9, String Coluna10, String Coluna11, String Coluna12, String Coluna13, String Coluna14, String Coluna15, String Coluna16, String Coluna17, String Coluna18,
            String Coluna19, String Coluna20, String Coluna21)
        {
            _Coluna0 = Coluna0;
            _Coluna1 = Coluna1;
            _Coluna2 = Coluna2;
            _Coluna3 = Coluna3;
            _Coluna4 = Coluna4;
            _Coluna5 = Coluna5;
            _Coluna6 = Coluna6;
            _Coluna7 = Coluna7;
            _Coluna8 = Coluna8;
            _Coluna9 = Coluna9;
            _Coluna10 = Coluna10;
            _Coluna11 = Coluna11;
            _Coluna12 = Coluna12;
            _Coluna13 = Coluna13;
            _Coluna14 = Coluna14;
            _Coluna15 = Coluna15;
            _Coluna16 = Coluna16;
            _Coluna17 = Coluna17;
            _Coluna18 = Coluna18;
            _Coluna19 = Coluna19;
            _Coluna20 = Coluna20;
            _Coluna21 = Coluna21;
            InitializeComponent();
        }

        private void DisplayInfo_Load(object sender, EventArgs e)
        {
            txtCodigoRegistro.Text = _Coluna0;
            txtNumeroPedido.Text = _Coluna1;
            txtNomeCliente.Text = _Coluna2;
            cbxSituacaoPedido.Text = _Coluna3;
            cbxVendedorPedido.Text = _Coluna4;
            txtCodigoProduto.Text = _Coluna5;
            txtProdutoDetalhe.Text = _Coluna6;
            cbxOperador.Text = _Coluna7;
            cbxAuxiliar1.Text = _Coluna8;
            cbxAuxiliar2.Text = _Coluna9;
            txtCodigoInsumo.Text = _Coluna10;
            txtInsumoDetalhe.Text = _Coluna11;
            txtPrecoInsumo.Text = _Coluna12;
            txtCodigoMaquina.Text = _Coluna13;
            txtMaquinaDetalhe.Text = _Coluna14;
            txtCustoMaquina.Text = _Coluna15;
            txtQTDM2NF.Text = _Coluna16;
            txtQTDM2OP.Text = _Coluna17;
            txtQtdRolosProduzidos.Text = _Coluna18;
            txtQTDKGTotal.Text = _Coluna19;
            txtQtdKGProduzidos.Text = _Coluna20;
            txtPerdaKGTotal.Text = _Coluna21;
        }
    }
}