using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Telasvelculos : Form
    {
        // Controles (criados manualmente)
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
        private DataGridView dgvCarro;
        private Button btnSalvar;
        private Button btnEditar;
        private Button btnExcluir;
        private Button btnConsultarLista;
        private Button btnUploadFoto;
        private Button btnLimpar;

        // Lista em memória similar ao exemplo do professor
        BindingList<Veiculo> listaVeiculos = new BindingList<Veiculo>();

        public Telasvelculos()
        {
            InitializeComponent();

            // exemplos iniciais
            listaVeiculos.Add(new Veiculo { Marca = "Fiat", Modelo = "Uno", Placa = "ABC1234", Combustivel = "Flex", Quilometragem = 12000, Ano = 2015, Cor = "Prata", Preco = 25000, Foto = string.Empty });
            listaVeiculos.Add(new Veiculo { Marca = "Volks", Modelo = "Gol", Placa = "DEF5678", Combustivel = "Gasolina", Quilometragem = 45000, Ano = 2012, Cor = "Branco", Preco = 30000, Foto = string.Empty });
            listaVeiculos.Add(new Veiculo { Marca = "Ford", Modelo = "Ka", Placa = "GHI9012", Combustivel = "Etanol", Quilometragem = 8000, Ano = 2018, Cor = "Vermelho", Preco = 32000, Foto = string.Empty });

            dgvCarro.DataSource = listaVeiculos;
        }

        private void InitializeComponent()
        {
            // Form básico
            this.Text = "Tela principal";
            this.ClientSize = new Size(820, 420);

            // Instancia controles
            textMarca = new TextBox() { Location = new Point(90, 10), Size = new Size(180, 20) };
            txtModelo = new TextBox() { Location = new Point(90, 40), Size = new Size(180, 20) };
            textPlaca = new TextBox() { Location = new Point(90, 70), Size = new Size(180, 20) };
            textCombustivel = new TextBox() { Location = new Point(90, 100), Size = new Size(180, 20) };
            dtpAno = new DateTimePicker() { Location = new Point(90, 130), Size = new Size(180, 20) };
            nudQuilometragem = new NumericUpDown() { Location = new Point(90, 160), Size = new Size(180, 20), Maximum = 1000000 };
            txtcor = new TextBox() { Location = new Point(90, 190), Size = new Size(180, 20) };
            txtPreco = new TextBox() { Location = new Point(90, 220), Size = new Size(180, 20) };

            btnUploadFoto = new Button() { Location = new Point(90, 250), Size = new Size(90, 25), Text = "Carregar Foto" };
            btnUploadFoto.Click += btnUploadFoto_Click;

            txtFotoPath = new TextBox() { Location = new Point(190, 250), Size = new Size(80, 20), Visible = false };

            pbFoto = new PictureBox() { Location = new Point(300, 10), Size = new Size(500, 240), BorderStyle = BorderStyle.FixedSingle, SizeMode = PictureBoxSizeMode.Zoom };

            btnSalvar = new Button() { Location = new Point(10, 290), Size = new Size(120, 40), Text = "btnSALVAR" };
            btnSalvar.Click += btnSalvar_Click;

            btnEditar = new Button() { Location = new Point(140, 290), Size = new Size(120, 40), Text = "btnEDITAR" };
            btnEditar.Click += btnEditar_Click;

            btnExcluir = new Button() { Location = new Point(10, 340), Size = new Size(120, 40), Text = "btnEXCLUIR" };
            btnExcluir.Click += btnExcluir_Click;

            btnConsultarLista = new Button() { Location = new Point(140, 340), Size = new Size(120, 40), Text = "btnConsultarLista" };
            btnConsultarLista.Click += btnConsultarLista_Click;

            btnLimpar = new Button() { Location = new Point(270, 290), Size = new Size(120, 40), Text = "Limpar" };
            btnLimpar.Click += btnLimpar_Click;

            dgvCarro = new DataGridView() { Location = new Point(300, 260), Size = new Size(500, 140), ReadOnly = true, AllowUserToAddRows = false, AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill };
            dgvCarro.CellClick += dgvCarro_CellClick;

            // Labels
            var lblMarca = new Label() { Location = new Point(10, 12), Text = "Marca:" };
            var lblModelo = new Label() { Location = new Point(10, 42), Text = "Modelo:" };
            var lblPlaca = new Label() { Location = new Point(10, 72), Text = "Placa:" };
            var lblComb = new Label() { Location = new Point(10, 102), Text = "Combustível:" };
            var lblAno = new Label() { Location = new Point(10, 132), Text = "Ano:" };
            var lblQuil = new Label() { Location = new Point(10, 162), Text = "Quilometragem:" };
            var lblCor = new Label() { Location = new Point(10, 192), Text = "Cor:" };
            var lblPreco = new Label() { Location = new Point(10, 222), Text = "Preço:" };

            // Adiciona controles ao formulário
            this.Controls.AddRange(new Control[] {
                lblMarca, textMarca,
                lblModelo, txtModelo,
                lblPlaca, textPlaca,
                lblComb, textCombustivel,
                lblAno, dtpAno,
                lblQuil, nudQuilometragem,
                lblCor, txtcor,
                lblPreco, txtPreco,
                btnUploadFoto, txtFotoPath, pbFoto,
                btnSalvar, btnEditar, btnExcluir, btnConsultarLista, btnLimpar,
                dgvCarro
            });
        }

        private void Telasvelculos_Load(object sender, EventArgs e)
        {
            // nada ao carregar
        }

        private void fnLimpar()
        {
            // limpa campos do formulário
            textMarca.Clear();
            txtModelo.Clear();
            textPlaca.Clear();
            textCombustivel.Clear();
            txtcor.Clear();
            txtPreco.Clear();
            txtFotoPath.Text = string.Empty;

            dtpAno.Value = DateTime.Now;
            nudQuilometragem.Value = 0;

            if (pbFoto != null) pbFoto.Image = null;

            textMarca.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // cria novo veículo e adiciona à lista
            var v = new Veiculo();
            v.Marca = textMarca.Text.Trim();
            v.Modelo = txtModelo.Text.Trim();
            v.Placa = textPlaca.Text.Trim();
            v.Combustivel = textCombustivel.Text.Trim();
            v.Quilometragem = nudQuilometragem.Value;
            v.Ano = dtpAno.Value.Year;
            if (decimal.TryParse(txtPreco.Text.Trim(), out var pr)) v.Preco = pr; else v.Preco = 0;
            v.Cor = txtcor.Text.Trim();
            v.Foto = txtFotoPath.Text.Trim();

            listaVeiculos.Add(v);

            MessageBox.Show("Veículo cadastrado com sucesso!");
            fnLimpar();
        }

        private void btnConsultarLista_Click(object sender, EventArgs e)
        {
            // binding já atualiza; apenas garantir refresh
            dgvCarro.Refresh();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvCarro.CurrentRow == null) { MessageBox.Show("Selecione um veículo na lista."); return; }

            var v = (Veiculo)dgvCarro.CurrentRow.DataBoundItem;
            v.Marca = textMarca.Text.Trim();
            v.Modelo = txtModelo.Text.Trim();
            v.Placa = textPlaca.Text.Trim();
            v.Combustivel = textCombustivel.Text.Trim();
            v.Quilometragem = nudQuilometragem.Value;
            v.Ano = dtpAno.Value.Year;
            if (decimal.TryParse(txtPreco.Text.Trim(), out var pr)) v.Preco = pr;
            v.Cor = txtcor.Text.Trim();
            v.Foto = txtFotoPath.Text.Trim();

            dgvCarro.Refresh();
            MessageBox.Show("Veículo atualizado na lista.");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvCarro.CurrentRow == null) { MessageBox.Show("Selecione um veículo na lista."); return; }

            var v = (Veiculo)dgvCarro.CurrentRow.DataBoundItem;
            var resp = MessageBox.Show($"Confirma exclusão do veículo {v.Marca} {v.Modelo}?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp != DialogResult.Yes) return;

            listaVeiculos.Remove(v);
            fnLimpar();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            fnLimpar();
        }

        private void btnUploadFoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Imagens|*.jpg;*.jpeg;*.png;*.bmp|Todos os arquivos|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtFotoPath.Text = ofd.FileName;
                    if (pbFoto != null)
                    {
                        try { pbFoto.Image = Image.FromFile(ofd.FileName); } catch { pbFoto.Image = null; }
                    }
                }
            }
        }

        private void dgvCarro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var item = dgvCarro.Rows[e.RowIndex].DataBoundItem as Veiculo;
            if (item == null) return;

            // preencher campos com o veículo selecionado
            textMarca.Text = item.Marca;
            txtModelo.Text = item.Modelo;
            textPlaca.Text = item.Placa;
            textCombustivel.Text = item.Combustivel;
            nudQuilometragem.Value = item.Quilometragem;
            try { dtpAno.Value = new DateTime(item.Ano, 1, 1); } catch { dtpAno.Value = DateTime.Now; }
            txtcor.Text = item.Cor;
            txtPreco.Text = item.Preco.ToString();
            txtFotoPath.Text = item.Foto ?? string.Empty;
            if (pbFoto != null && !string.IsNullOrEmpty(item.Foto) && File.Exists(item.Foto))
            {
                try { pbFoto.Image = Image.FromFile(item.Foto); } catch { pbFoto.Image = null; }
            }
        }
    }
}
