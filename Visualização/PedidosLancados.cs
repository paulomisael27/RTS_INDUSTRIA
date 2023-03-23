using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FQXAutoMec.Módulos;
using FQXAutoMec.Menu;
using Excel = Microsoft.Office.Interop.Excel;

namespace FQXAutoMec.Visualização
{
    public partial class PedidosLancados : Form
    {
        public PedidosLancados()
        {
            InitializeComponent();
        }

        private void PedidosLancados_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'rTS_Pedidos.REGISTRA_PEDIDO'. Você pode movê-la ou removê-la conforme necessário.
            this.rEGISTRA_PEDIDOTableAdapter.Fill(this.rTS_Pedidos.REGISTRA_PEDIDO);

        }

        private void dgvPedidosLançados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String Coluna0 = dgvPedidosLançados.Rows[0].Cells[0].Value.ToString();
            String Coluna1 = dgvPedidosLançados.Rows[0].Cells[1].Value.ToString();
            String Coluna2 = dgvPedidosLançados.Rows[0].Cells[2].Value.ToString();
            String Coluna3 = dgvPedidosLançados.Rows[0].Cells[3].Value.ToString();
            String Coluna4 = dgvPedidosLançados.Rows[0].Cells[4].Value.ToString();
            String Coluna5 = dgvPedidosLançados.Rows[0].Cells[5].Value.ToString();
            String Coluna6 = dgvPedidosLançados.Rows[0].Cells[6].Value.ToString();
            String Coluna7 = dgvPedidosLançados.Rows[0].Cells[7].Value.ToString();
            String Coluna8 = dgvPedidosLançados.Rows[0].Cells[8].Value.ToString();
            String Coluna9 = dgvPedidosLançados.Rows[0].Cells[9].Value.ToString();
            String Coluna10 = dgvPedidosLançados.Rows[0].Cells[10].Value.ToString();
            String Coluna11 = dgvPedidosLançados.Rows[0].Cells[11].Value.ToString();
            String Coluna12 = dgvPedidosLançados.Rows[0].Cells[12].Value.ToString();
            String Coluna13 = dgvPedidosLançados.Rows[0].Cells[13].Value.ToString();
            String Coluna14 = dgvPedidosLançados.Rows[0].Cells[14].Value.ToString();
            String Coluna15 = dgvPedidosLançados.Rows[0].Cells[15].Value.ToString();
            String Coluna16 = dgvPedidosLançados.Rows[0].Cells[16].Value.ToString();
            String Coluna17 = dgvPedidosLançados.Rows[0].Cells[17].Value.ToString();
            String Coluna18 = dgvPedidosLançados.Rows[0].Cells[18].Value.ToString();
            String Coluna19 = dgvPedidosLançados.Rows[0].Cells[19].Value.ToString();
            String Coluna20 = dgvPedidosLançados.Rows[0].Cells[20].Value.ToString();
            String Coluna21 = dgvPedidosLançados.Rows[0].Cells[21].Value.ToString();

            DisplayInfo DI = new DisplayInfo(Coluna0, Coluna1, Coluna2, Coluna3, Coluna4, Coluna5, Coluna6, Coluna7, Coluna8, Coluna9, Coluna10, Coluna11, Coluna12,
                Coluna13, Coluna14, Coluna15, Coluna16, Coluna17, Coluna18, Coluna19, Coluna20, Coluna21);
            DI.ShowDialog();
        }

        private void PedidosLancados_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnToolExportarPedido_Click(object sender, EventArgs e)
        {
            SaveFileDialog salvar = new SaveFileDialog(); // novo
                Excel.Application App; // Aplicação Excel
                Excel.Workbook WorkBook; // Pasta
                Excel.Worksheet WorkSheet; // Planilha
                object misValue = System.Reflection.Missing.Value;

                App = new Excel.Application();
                WorkBook = App.Workbooks.Add(misValue);
                WorkSheet = (Excel.Worksheet)WorkBook.Worksheets.get_Item(1);
                int i = 0;
                int j = 0;

                // passa as celulas do DataGridView para a Pasta do Excel
                for (i = 0; i <= dgvPedidosLançados.RowCount - 1; i++)
                {
                    for (j = 0; j <= dgvPedidosLançados.ColumnCount - 1; j++)
                    {
                        DataGridViewCell cell = dgvPedidosLançados[j, i];
                        WorkSheet.Cells[i + 1, j + 1] = cell.Value;
                    }
                }

                // define algumas propriedades da caixa salvar
                salvar.Title = "Exportar para Excel";
                salvar.Filter = "Arquivo do Excel *.xls | *.xls";
                salvar.ShowDialog();

                // salva o arquivo
                WorkBook.SaveAs(salvar.FileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue,

                Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                WorkBook.Close(true, misValue, misValue);
                App.Quit(); // encerra o excel

                MessageBox.Show("Exportado com sucesso!");
        }
    }
}