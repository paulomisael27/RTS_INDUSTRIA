
namespace FQXAutoMec.Cadastros
{
    partial class CadProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadProduto));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxModeloTela = new System.Windows.Forms.ComboBox();
            this.cbxTipoFio = new System.Windows.Forms.ComboBox();
            this.txtCodProduto = new System.Windows.Forms.TextBox();
            this.txtCadProduto = new System.Windows.Forms.TextBox();
            this.txtMalhaTela = new System.Windows.Forms.TextBox();
            this.txtFioTela = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvUltimosProd = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUltimosProd)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(1146, 36);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripLabel1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(346, 33);
            this.toolStripLabel1.Text = "Cadastro de Produto - Novo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(117, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Modelo da tela";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Código";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(270, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tipo do Fio";
            // 
            // cbxModeloTela
            // 
            this.cbxModeloTela.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxModeloTela.FormattingEnabled = true;
            this.cbxModeloTela.Items.AddRange(new object[] {
            "LOSANGULAR",
            "QUADRADA"});
            this.cbxModeloTela.Location = new System.Drawing.Point(120, 175);
            this.cbxModeloTela.Name = "cbxModeloTela";
            this.cbxModeloTela.Size = new System.Drawing.Size(101, 21);
            this.cbxModeloTela.TabIndex = 8;
            // 
            // cbxTipoFio
            // 
            this.cbxTipoFio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoFio.FormattingEnabled = true;
            this.cbxTipoFio.Items.AddRange(new object[] {
            "REVESTIDO",
            "GALV."});
            this.cbxTipoFio.Location = new System.Drawing.Point(273, 226);
            this.cbxTipoFio.Name = "cbxTipoFio";
            this.cbxTipoFio.Size = new System.Drawing.Size(83, 21);
            this.cbxTipoFio.TabIndex = 9;
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.Enabled = false;
            this.txtCodProduto.Location = new System.Drawing.Point(48, 175);
            this.txtCodProduto.MaxLength = 10;
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.Size = new System.Drawing.Size(55, 20);
            this.txtCodProduto.TabIndex = 0;
            this.txtCodProduto.Visible = false;
            // 
            // txtCadProduto
            // 
            this.txtCadProduto.Location = new System.Drawing.Point(48, 226);
            this.txtCadProduto.Name = "txtCadProduto";
            this.txtCadProduto.Size = new System.Drawing.Size(219, 20);
            this.txtCadProduto.TabIndex = 1;
            // 
            // txtMalhaTela
            // 
            this.txtMalhaTela.Location = new System.Drawing.Point(427, 226);
            this.txtMalhaTela.MaxLength = 5;
            this.txtMalhaTela.Name = "txtMalhaTela";
            this.txtMalhaTela.Size = new System.Drawing.Size(56, 20);
            this.txtMalhaTela.TabIndex = 4;
            this.txtMalhaTela.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFioTela
            // 
            this.txtFioTela.Location = new System.Drawing.Point(362, 226);
            this.txtFioTela.MaxLength = 2;
            this.txtFioTela.Name = "txtFioTela";
            this.txtFioTela.Size = new System.Drawing.Size(59, 20);
            this.txtFioTela.TabIndex = 5;
            this.txtFioTela.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(45, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Produto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(359, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "FIO da tela";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(424, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Malha";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(707, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Últimos produtos cadastrados";
            // 
            // dgvUltimosProd
            // 
            this.dgvUltimosProd.BackgroundColor = System.Drawing.Color.White;
            this.dgvUltimosProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUltimosProd.GridColor = System.Drawing.Color.White;
            this.dgvUltimosProd.Location = new System.Drawing.Point(710, 159);
            this.dgvUltimosProd.Name = "dgvUltimosProd";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Cyan;
            this.dgvUltimosProd.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUltimosProd.Size = new System.Drawing.Size(409, 208);
            this.dgvUltimosProd.TabIndex = 20;
            this.dgvUltimosProd.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvUltimosProd_MouseDoubleClick);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.White;
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(1059, 555);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 37);
            this.btnExcluir.TabIndex = 53;
            this.btnExcluir.TabStop = false;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.White;
            this.btnAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(978, 555);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 37);
            this.btnAlterar.TabIndex = 52;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.UseVisualStyleBackColor = false;
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.White;
            this.btnInserir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInserir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnInserir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserir.Image = ((System.Drawing.Image)(resources.GetObject("btnInserir.Image")));
            this.btnInserir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInserir.Location = new System.Drawing.Point(897, 555);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 37);
            this.btnInserir.TabIndex = 51;
            this.btnInserir.TabStop = false;
            this.btnInserir.Text = "Salvar";
            this.btnInserir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInserir.UseVisualStyleBackColor = false;
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.White;
            this.btnNovo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(816, 555);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 37);
            this.btnNovo.TabIndex = 50;
            this.btnNovo.TabStop = false;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.UseVisualStyleBackColor = false;
            // 
            // CadProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1146, 604);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dgvUltimosProd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbxModeloTela);
            this.Controls.Add(this.cbxTipoFio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFioTela);
            this.Controls.Add(this.txtCodProduto);
            this.Controls.Add(this.txtMalhaTela);
            this.Controls.Add(this.txtCadProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadProduto";
            this.Text = "CadProduto";
            this.Load += new System.EventHandler(this.CadProduto_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUltimosProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxModeloTela;
        private System.Windows.Forms.ComboBox cbxTipoFio;
        private System.Windows.Forms.TextBox txtCodProduto;
        private System.Windows.Forms.TextBox txtCadProduto;
        private System.Windows.Forms.TextBox txtMalhaTela;
        private System.Windows.Forms.TextBox txtFioTela;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvUltimosProd;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnNovo;
    }
}