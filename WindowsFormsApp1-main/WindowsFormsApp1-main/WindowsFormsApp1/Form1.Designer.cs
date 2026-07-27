namespace WindowsFormsApp1
{
    partial class Telasvelculos
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnexcliuir = new System.Windows.Forms.Button();
            this.dgvCarro = new System.Windows.Forms.DataGridView();
            this.txttelefone = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lbPlaca = new System.Windows.Forms.Label();
            this.textPlaca = new System.Windows.Forms.TextBox();
            this.lbModelo = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.btnConsultarLista = new System.Windows.Forms.Button();
            this.lbMarca = new System.Windows.Forms.Label();
            this.textMarca = new System.Windows.Forms.TextBox();
            this.lbAno = new System.Windows.Forms.Label();
            this.lbCor = new System.Windows.Forms.Label();
            this.lbQuilometragem = new System.Windows.Forms.Label();
            this.nudQuilometragem = new System.Windows.Forms.NumericUpDown();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dtpAno = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuilometragem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(1, 243);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(156, 67);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "btnSALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(1, 316);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(156, 67);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "btnEDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(163, 243);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(156, 67);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "btnCONSULTAR";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnexcliuir
            // 
            this.btnexcliuir.Location = new System.Drawing.Point(163, 316);
            this.btnexcliuir.Name = "btnexcliuir";
            this.btnexcliuir.Size = new System.Drawing.Size(156, 67);
            this.btnexcliuir.TabIndex = 3;
            this.btnexcliuir.Text = "btnEXCLUIR";
            this.btnexcliuir.UseVisualStyleBackColor = true;
            this.btnexcliuir.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // dgvCarro
            // 
            this.dgvCarro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarro.Location = new System.Drawing.Point(335, 243);
            this.dgvCarro.Name = "dgvCarro";
            this.dgvCarro.Size = new System.Drawing.Size(437, 195);
            this.dgvCarro.TabIndex = 4;
            // 
            // txttelefone
            // 
            this.txttelefone.Location = new System.Drawing.Point(91, 32);
            this.txttelefone.Name = "txttelefone";
            this.txttelefone.Size = new System.Drawing.Size(189, 20);
            this.txttelefone.TabIndex = 6;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(91, 6);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(189, 20);
            this.txtnome.TabIndex = 7;
            // 
            // lbPlaca
            // 
            this.lbPlaca.AutoSize = true;
            this.lbPlaca.Location = new System.Drawing.Point(32, 39);
            this.lbPlaca.Name = "lbPlaca";
            this.lbPlaca.Size = new System.Drawing.Size(37, 13);
            this.lbPlaca.TabIndex = 10;
            this.lbPlaca.Text = "Placa:";
            // 
            // textPlaca
            // 
            this.textPlaca.Location = new System.Drawing.Point(91, 58);
            this.textPlaca.Name = "textPlaca";
            this.textPlaca.Size = new System.Drawing.Size(189, 20);
            this.textPlaca.TabIndex = 11;
            // 
            // lbModelo
            // 
            this.lbModelo.AutoSize = true;
            this.lbModelo.Location = new System.Drawing.Point(30, 65);
            this.lbModelo.Name = "lbModelo";
            this.lbModelo.Size = new System.Drawing.Size(45, 13);
            this.lbModelo.TabIndex = 12;
            this.lbModelo.Text = "Modelo:";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(91, 84);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(189, 20);
            this.txtModelo.TabIndex = 13;
            // 
            // btnConsultarLista
            // 
            this.btnConsultarLista.Location = new System.Drawing.Point(27, 389);
            this.btnConsultarLista.Name = "btnConsultarLista";
            this.btnConsultarLista.Size = new System.Drawing.Size(270, 37);
            this.btnConsultarLista.TabIndex = 14;
            this.btnConsultarLista.Text = "btnConsultarLista";
            this.btnConsultarLista.UseVisualStyleBackColor = true;
            this.btnConsultarLista.Click += new System.EventHandler(this.btnConsultarLista_Click);
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.Location = new System.Drawing.Point(29, 9);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(40, 13);
            this.lbMarca.TabIndex = 15;
            this.lbMarca.Text = "Marca:";
            // 
            // textMarca
            // 
            this.textMarca.Location = new System.Drawing.Point(91, 113);
            this.textMarca.Name = "textMarca";
            this.textMarca.Size = new System.Drawing.Size(189, 20);
            this.textMarca.TabIndex = 16;
            // 
            // lbAno
            // 
            this.lbAno.AutoSize = true;
            this.lbAno.Location = new System.Drawing.Point(40, 139);
            this.lbAno.Name = "lbAno";
            this.lbAno.Size = new System.Drawing.Size(29, 13);
            this.lbAno.TabIndex = 17;
            this.lbAno.Text = "Ano:";
            // 
            // lbCor
            // 
            this.lbCor.AutoSize = true;
            this.lbCor.Location = new System.Drawing.Point(40, 87);
            this.lbCor.Name = "lbCor";
            this.lbCor.Size = new System.Drawing.Size(26, 13);
            this.lbCor.TabIndex = 19;
            this.lbCor.Text = "Cor:";
            // 
            // lbQuilometragem
            // 
            this.lbQuilometragem.AutoSize = true;
            this.lbQuilometragem.Location = new System.Drawing.Point(5, 116);
            this.lbQuilometragem.Name = "lbQuilometragem";
            this.lbQuilometragem.Size = new System.Drawing.Size(80, 13);
            this.lbQuilometragem.TabIndex = 21;
            this.lbQuilometragem.Text = "Quilometragem:";
            // 
            // nudQuilometragem
            // 
            this.nudQuilometragem.Location = new System.Drawing.Point(91, 165);
            this.nudQuilometragem.Name = "nudQuilometragem";
            this.nudQuilometragem.Size = new System.Drawing.Size(189, 20);
            this.nudQuilometragem.TabIndex = 24;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dtpAno
            // 
            this.dtpAno.Location = new System.Drawing.Point(91, 139);
            this.dtpAno.Name = "dtpAno";
            this.dtpAno.Size = new System.Drawing.Size(228, 20);
            this.dtpAno.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "preco:";
            // 
            // Telasvelculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 460);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpAno);
            this.Controls.Add(this.nudQuilometragem);
            this.Controls.Add(this.lbQuilometragem);
            this.Controls.Add(this.lbCor);
            this.Controls.Add(this.lbAno);
            this.Controls.Add(this.textMarca);
            this.Controls.Add(this.lbMarca);
            this.Controls.Add(this.btnConsultarLista);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.lbModelo);
            this.Controls.Add(this.textPlaca);
            this.Controls.Add(this.lbPlaca);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txttelefone);
            this.Controls.Add(this.dgvCarro);
            this.Controls.Add(this.btnexcliuir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvar);
            this.Name = "Telasvelculos";
            this.Text = "Tela pricinpal";
            this.Load += new System.EventHandler(this.Telasvelculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuilometragem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnexcliuir;
        private System.Windows.Forms.DataGridView dgvCarro;
        private System.Windows.Forms.TextBox txttelefone;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label lbPlaca;
        private System.Windows.Forms.TextBox textPlaca;
        private System.Windows.Forms.Label lbModelo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Button btnConsultarLista;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.TextBox textMarca;
        private System.Windows.Forms.Label lbAno;
        private System.Windows.Forms.Label lbCor;
        private System.Windows.Forms.Label lbQuilometragem;
        private System.Windows.Forms.NumericUpDown nudQuilometragem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DateTimePicker dtpAno;
        private System.Windows.Forms.Label label1;
    }
}

