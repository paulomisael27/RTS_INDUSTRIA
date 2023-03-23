
namespace FQXAutoMec.Cadastros
{
    partial class CadInsumo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadInsumo));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtInsumo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtCodInsumo = new System.Windows.Forms.TextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.rTS_CadastroInsumo = new FQXAutoMec.RTS_CadastroInsumo();
            this.cadastroInsumoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNSUMODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECOINSUMODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODCADASTRODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rTS_CadastroInsumo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroInsumoBindingSource)).BeginInit();
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
            this.toolStrip1.TabIndex = 14;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripLabel1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(342, 33);
            this.toolStripLabel1.Text = "Cadastro de Insumo - Novo";
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.White;
            this.btnAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(980, 555);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 37);
            this.btnAlterar.TabIndex = 19;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.UseVisualStyleBackColor = false;
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(44, 181);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(59, 20);
            this.txtCod.TabIndex = 22;
            // 
            // txtInsumo
            // 
            this.txtInsumo.Location = new System.Drawing.Point(109, 181);
            this.txtInsumo.Name = "txtInsumo";
            this.txtInsumo.Size = new System.Drawing.Size(208, 20);
            this.txtInsumo.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Insumo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Preço";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(324, 181);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(71, 20);
            this.txtPreco.TabIndex = 28;
            this.txtPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "R$";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.iNSUMODataGridViewTextBoxColumn,
            this.pRECOINSUMODataGridViewTextBoxColumn,
            this.cODCADASTRODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cadastroInsumoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 291);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(444, 209);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // txtCodInsumo
            // 
            this.txtCodInsumo.Enabled = false;
            this.txtCodInsumo.Location = new System.Drawing.Point(44, 52);
            this.txtCodInsumo.Name = "txtCodInsumo";
            this.txtCodInsumo.Size = new System.Drawing.Size(59, 20);
            this.txtCodInsumo.TabIndex = 31;
            this.txtCodInsumo.Visible = false;
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.White;
            this.btnNovo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(818, 555);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 37);
            this.btnNovo.TabIndex = 44;
            this.btnNovo.TabStop = false;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.UseVisualStyleBackColor = false;
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
            this.btnInserir.Location = new System.Drawing.Point(899, 555);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 37);
            this.btnInserir.TabIndex = 46;
            this.btnInserir.TabStop = false;
            this.btnInserir.Text = "Salvar";
            this.btnInserir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click_1);
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
            this.btnExcluir.TabIndex = 47;
            this.btnExcluir.TabStop = false;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // rTS_CadastroInsumo
            // 
            this.rTS_CadastroInsumo.DataSetName = "RTS_CadastroInsumo";
            this.rTS_CadastroInsumo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cadastroInsumoBindingSource
            // 
            this.cadastroInsumoBindingSource.DataMember = "CadastroInsumo";
            this.cadastroInsumoBindingSource.DataSource = this.rTS_CadastroInsumo;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iNSUMODataGridViewTextBoxColumn
            // 
            this.iNSUMODataGridViewTextBoxColumn.DataPropertyName = "INSUMO";
            this.iNSUMODataGridViewTextBoxColumn.HeaderText = "INSUMO";
            this.iNSUMODataGridViewTextBoxColumn.Name = "iNSUMODataGridViewTextBoxColumn";
            this.iNSUMODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRECOINSUMODataGridViewTextBoxColumn
            // 
            this.pRECOINSUMODataGridViewTextBoxColumn.DataPropertyName = "PRECO_INSUMO";
            this.pRECOINSUMODataGridViewTextBoxColumn.HeaderText = "PRECO_INSUMO";
            this.pRECOINSUMODataGridViewTextBoxColumn.Name = "pRECOINSUMODataGridViewTextBoxColumn";
            this.pRECOINSUMODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cODCADASTRODataGridViewTextBoxColumn
            // 
            this.cODCADASTRODataGridViewTextBoxColumn.DataPropertyName = "CODCADASTRO";
            this.cODCADASTRODataGridViewTextBoxColumn.HeaderText = "CODCADASTRO";
            this.cODCADASTRODataGridViewTextBoxColumn.Name = "cODCADASTRODataGridViewTextBoxColumn";
            this.cODCADASTRODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CadInsumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1146, 604);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.txtCodInsumo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInsumo);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadInsumo";
            this.Text = "MKTBPreco";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rTS_CadastroInsumo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroInsumoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.TextBox txtInsumo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtCodInsumo;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNSUMODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECOINSUMODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODCADASTRODataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cadastroInsumoBindingSource;
        private RTS_CadastroInsumo rTS_CadastroInsumo;
    }
}