using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Telasvelculos : Form
    {
        // controles
        private TextBox textMarca;
        private TextBox txtModelo;
        private TextBox textPlaca;
        private TextBox textCombustivel;
        private TextBox txtcor;
        private TextBox txtPreco;
        private TextBox txtFotoPath;
        private NumericUpDown nudQuilometragem;
        private DateTimePicker dtpAno;
        private PictureBox pbFoto;
        private Button btnUploadFoto;
        private Button btnSalvar;
        private Button btnEditar;
        private Button btnExcluir;
        private Button btnLimpar;
        private Button btnConsultarLista;
        private DataGridView dgvCarro;

        private List<Veiculo> lista = new List<Veiculo>();

        public Telasvelculos()
        {
            InitializeComponent();
            ConfigureDataGridView();
        }

        private void InitializeComponent()
        {
            // FORM
            this.Text = "Cadastro de Veículos";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ClientSize = new Size(1150, 650);
            this.BackColor = Color.WhiteSmoke;
            this.Font = new Font("Segoe UI", 10);

            // CAMPOS
            textMarca = new TextBox();
            txtModelo = new TextBox();
            textPlaca = new TextBox();
            textCombustivel = new TextBox();
            txtcor = new TextBox();
            txtPreco = new TextBox();
            txtFotoPath = new TextBox();
            nudQuilometragem = new NumericUpDown();
            dtpAno = new DateTimePicker();

            int lblX = 20;
            int txtX = 150;
            int y = 25;
            int espaco = 45;

            Label lblMarca = new Label();
            lblMarca.Text = "Marca:";
            lblMarca.Location = new Point(lblX, y);
            lblMarca.AutoSize = true;

            textMarca.Location = new Point(txtX, y);
            textMarca.Size = new Size(220, 28);

            y += espaco;

            Label lblModelo = new Label();
            lblModelo.Text = "Modelo:";
            lblModelo.Location = new Point(lblX, y);
            lblModelo.AutoSize = true;

            txtModelo.Location = new Point(txtX, y);
            txtModelo.Size = new Size(220, 28);

            y += espaco;

            Label lblPlaca = new Label();
            lblPlaca.Text = "Placa:";
            lblPlaca.Location = new Point(lblX, y);
            lblPlaca.AutoSize = true;

            textPlaca.Location = new Point(txtX, y);
            textPlaca.Size = new Size(220, 28);

            y += espaco;

            Label lblComb = new Label();
            lblComb.Text = "Combustível:";
            lblComb.Location = new Point(lblX, y);
            lblComb.AutoSize = true;

            textCombustivel.Location = new Point(txtX, y);
            textCombustivel.Size = new Size(220, 28);

            y += espaco;

            Label lblAno = new Label();
            lblAno.Text = "Ano:";
            lblAno.Location = new Point(lblX, y);
            lblAno.AutoSize = true;

            dtpAno.Location = new Point(txtX, y);
            dtpAno.Size = new Size(220, 28);
            dtpAno.Format = DateTimePickerFormat.Short;

            y += espaco;

            Label lblKm = new Label();
            lblKm.Text = "Quilometragem:";
            lblKm.Location = new Point(lblX, y);
            lblKm.AutoSize = true;

            nudQuilometragem.Location = new Point(txtX, y);
            nudQuilometragem.Size = new Size(220, 28);
            nudQuilometragem.Maximum = 1000000;

            y += espaco;

            Label lblCor = new Label();
            lblCor.Text = "Cor:";
            lblCor.Location = new Point(lblX, y);
            lblCor.AutoSize = true;

            txtcor.Location = new Point(txtX, y);
            txtcor.Size = new Size(220, 28);

            y += espaco;

            Label lblPreco = new Label();
            lblPreco.Text = "Preço:";
            lblPreco.Location = new Point(lblX, y);
            lblPreco.AutoSize = true;

            txtPreco.Location = new Point(txtX, y);
            txtPreco.Size = new Size(220, 28);

            // FOTO

            pbFoto = new PictureBox();
            pbFoto.Location = new Point(430, 25);
            pbFoto.Size = new Size(680, 260);
            pbFoto.BorderStyle = BorderStyle.FixedSingle;
            pbFoto.SizeMode = PictureBoxSizeMode.Zoom;

            btnUploadFoto = new Button();
            btnUploadFoto.Text = "Selecionar Foto";
            btnUploadFoto.Location = new Point(430, 295);
            btnUploadFoto.Size = new Size(160, 35);
            btnUploadFoto.Click += btnUploadFoto_Click;

            txtFotoPath.Visible = false;

            // BOTÕES

            btnSalvar = new Button();
            btnSalvar.Text = "Salvar";
            btnSalvar.Size = new Size(120, 45);
            btnSalvar.Location = new Point(20, 420);
            btnSalvar.Click += btnSalvar_Click;

            btnEditar = new Button();
            btnEditar.Text = "Editar";
            btnEditar.Size = new Size(120, 45);
            btnEditar.Location = new Point(160, 420);
            btnEditar.Click += btnEditar_Click;

            btnExcluir = new Button();
            btnExcluir.Text = "Excluir";
            btnExcluir.Size = new Size(120, 45);
            btnExcluir.Location = new Point(300, 420);
            btnExcluir.Click += btnExcluir_Click;

            btnLimpar = new Button();
            btnLimpar.Text = "Limpar";
            btnLimpar.Size = new Size(120, 45);
            btnLimpar.Location = new Point(440, 420);
            btnLimpar.Click += btnLimpar_Click;

            btnConsultarLista = new Button();
            btnConsultarLista.Text = "Consultar";
            btnConsultarLista.Size = new Size(120, 45);
            btnConsultarLista.Location = new Point(580, 420);
            btnConsultarLista.Click += btnConsultarLista_Click;

            // TABELA

            dgvCarro = new DataGridView();
            dgvCarro.Location = new Point(20, 490);
            dgvCarro.Size = new Size(1090, 140);
            dgvCarro.ReadOnly = true;
            dgvCarro.AllowUserToAddRows = false;
            dgvCarro.AllowUserToDeleteRows = false;
            dgvCarro.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarro.MultiSelect = false;
            dgvCarro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCarro.CellClick += dgvCarro_CellClick;

            this.Controls.Add(lblMarca);
            this.Controls.Add(textMarca);

            this.Controls.Add(lblModelo);
            this.Controls.Add(txtModelo);

            this.Controls.Add(lblPlaca);
            this.Controls.Add(textPlaca);

            this.Controls.Add(lblComb);
            this.Controls.Add(textCombustivel);

            this.Controls.Add(lblAno);
            this.Controls.Add(dtpAno);

            this.Controls.Add(lblKm);
            this.Controls.Add(nudQuilometragem);

            this.Controls.Add(lblCor);
            this.Controls.Add(txtcor);

            this.Controls.Add(lblPreco);
            this.Controls.Add(txtPreco);

            this.Controls.Add(pbFoto);
            this.Controls.Add(btnUploadFoto);
            this.Controls.Add(txtFotoPath);

            this.Controls.Add(btnSalvar);
            this.Controls.Add(btnEditar);
            this.Controls.Add(btnExcluir);
            this.Controls.Add(btnLimpar);
            this.Controls.Add(btnConsultarLista);

            this.Controls.Add(dgvCarro);
        }

        private void ConfigureDataGridView()
        {
            dgvCarro.EnableHeadersVisualStyles = false;
            dgvCarro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCarro.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarro.ReadOnly = true;
            dgvCarro.AllowUserToAddRows = false;
            dgvCarro.RowHeadersVisible = false;
            dgvCarro.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
        }

        // event handlers and simple in-memory CRUD
        private void btnUploadFoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Imagens|*.jpg;*.jpeg;*.png;*.bmp|Todos|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtFotoPath.Text = ofd.FileName;
                    try { pbFoto.Image = Image.FromFile(ofd.FileName); } catch { }
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var v = new Veiculo
            {
                Marca = textMarca.Text,
                Modelo = txtModelo.Text,
                Placa = textPlaca.Text,
                Combustivel = textCombustivel.Text,
                Ano = dtpAno.Value.Year,
                Quilometragem = decimal.TryParse(nudQuilometragem.Value.ToString(), out decimal q) ? q : 0,
                Cor = txtcor.Text,
                Preco = decimal.TryParse(txtPreco.Text, out decimal p) ? p : 0,
                Foto = txtFotoPath.Text
            };
            lista.Add(v);
            RefreshGrid();
            MessageBox.Show("Salvo.");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvCarro.CurrentRow == null) return;
            int id = Convert.ToInt32(dgvCarro.CurrentRow.Cells["Id"].Value);
            var v = lista.Find(x => x.Id == id);
            if (v == null) return;
            v.Marca = textMarca.Text;
            v.Modelo = txtModelo.Text;
            v.Placa = textPlaca.Text;
            v.Combustivel = textCombustivel.Text;
            v.Ano = dtpAno.Value.Year;
            v.Quilometragem = decimal.TryParse(nudQuilometragem.Value.ToString(), out decimal q2) ? q2 : 0;
            v.Cor = txtcor.Text;
            v.Preco = decimal.TryParse(txtPreco.Text, out decimal p2) ? p2 : 0;
            v.Foto = txtFotoPath.Text;
            RefreshGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvCarro.CurrentRow == null) return;
            int id = Convert.ToInt32(dgvCarro.CurrentRow.Cells["Id"].Value);
            lista.RemoveAll(x => x.Id == id);
            RefreshGrid();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textMarca.Text = txtModelo.Text = textPlaca.Text = textCombustivel.Text = txtcor.Text = txtPreco.Text = txtFotoPath.Text = string.Empty;
            nudQuilometragem.Value = 0;
            dtpAno.Value = DateTime.Today;
            pbFoto.Image = null;
        }

        private void btnConsultarLista_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void dgvCarro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvCarro.Rows[e.RowIndex];
            int id = Convert.ToInt32(row.Cells["Id"].Value);
            var v = lista.Find(x => x.Id == id);
            if (v == null) return;
            textMarca.Text = v.Marca;
            txtModelo.Text = v.Modelo;
            textPlaca.Text = v.Placa;
            textCombustivel.Text = v.Combustivel;
            dtpAno.Value = new DateTime(Math.Max(1, v.Ano), 1, 1);
            nudQuilometragem.Value = Math.Min(nudQuilometragem.Maximum, Convert.ToDecimal(v.Quilometragem));
            txtcor.Text = v.Cor;
            txtPreco.Text = v.Preco.ToString("F2");
            txtFotoPath.Text = v.Foto;
            try { if (!string.IsNullOrEmpty(v.Foto) && File.Exists(v.Foto)) pbFoto.Image = Image.FromFile(v.Foto); } catch { }
        }

        private void RefreshGrid()
        {
            var dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Marca");
            dt.Columns.Add("Modelo");
            dt.Columns.Add("Placa");
            dt.Columns.Add("Combus");
            dt.Columns.Add("Quilom", typeof(decimal));
            dt.Columns.Add("Ano", typeof(int));
            dt.Columns.Add("Cor");
            dt.Columns.Add("Preco", typeof(decimal));
            dt.Columns.Add("Foto");

            foreach (var v in lista)
            {
                dt.Rows.Add(v.Id, v.Marca, v.Modelo, v.Placa, v.Combustivel, v.Quilometragem, v.Ano, v.Cor, v.Preco, Path.GetFileName(v.Foto));
            }

            dgvCarro.DataSource = dt;
            // formata colunas
            if (dgvCarro.Columns.Contains("Id")) dgvCarro.Columns["Id"].Width = 50;
            if (dgvCarro.Columns.Contains("Marca")) dgvCarro.Columns["Marca"].Width = 120;
            if (dgvCarro.Columns.Contains("Modelo")) dgvCarro.Columns["Modelo"].Width = 120;
            if (dgvCarro.Columns.Contains("Placa")) dgvCarro.Columns["Placa"].Width = 90;
            if (dgvCarro.Columns.Contains("Quilom"))
            {
                dgvCarro.Columns["Quilom"].DefaultCellStyle.Format = "N0";
                dgvCarro.Columns["Quilom"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            if (dgvCarro.Columns.Contains("Preco"))
            {
                dgvCarro.Columns["Preco"].DefaultCellStyle.Format = "N2";
                dgvCarro.Columns["Preco"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }
    }
}
