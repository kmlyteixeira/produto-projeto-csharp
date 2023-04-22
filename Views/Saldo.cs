using System.Drawing;
using System.Windows.Forms;

namespace Views
{
  public class Saldo : Form
  {

    private Label titulo;
    private Label lblNome;
    private Label lblPreco;
    private TextBox txtNome;
    private TextBox txtPreco;
    private Button btnSalvar;
    private Button btnCancelar;
    private ListView lista;
    private Button btnEditar;
    private Button btnExcluir;


    public Saldo()
    {
      InitializeComponent();
    }

    public void InitializeComponent()
    {
      this.titulo = new Label();
      this.lista = new ListView();
      this.btnSalvar = new Button();
      this.btnEditar = new Button();
      this.btnExcluir = new Button();
      this.btnCancelar = new Button();

      this.titulo.Text = "Lista Saldo";
      this.titulo.Location = new Point(10, 10);
      this.titulo.Size = new Size(280, 30);
      this.titulo.TextAlign = ContentAlignment.MiddleCenter;
      this.titulo.Font = new Font("Arial", 20, FontStyle.Bold);

      this.lista.Location = new Point(10, 50);
      this.lista.Size = new Size(590, 400);
      this.lista.View = View.Details;
      this.lista.FullRowSelect = true;
      this.lista.GridLines = true;
      this.lista.Columns.Add("Id", 50);
      this.lista.Columns.Add("Nome", 100);
      this.lista.Columns.Add("Quantidade", 150);

      this.LoadList();

      this.btnSalvar.Text = "Incluir";
      this.btnSalvar.Location = new Point(10, 450);
      this.btnSalvar.Size = new Size(90, 30);
      this.btnSalvar.Font = new Font("Arial", 12, FontStyle.Bold);
      this.btnSalvar.Click += (sender, e) =>
      {
        new CadastroSaldo(0);
        this.LoadList();
      };

      this.btnEditar.Text = "Editar";
      this.btnEditar.Location = new Point(110, 450);
      this.btnEditar.Size = new Size(90, 30);
      this.btnEditar.Font = new Font("Arial", 12, FontStyle.Bold);
      this.btnEditar.Click += (sender, e) =>
      {
        new CadastroSaldo(
          int.Parse(this.lista.SelectedItems[0].Text)
        );
        this.LoadList();
      };

      this.btnExcluir.Text = "Excluir";
      this.btnExcluir.Location = new Point(210, 450);
      this.btnExcluir.Size = new Size(90, 30);
      this.btnExcluir.Font = new Font("Arial", 12, FontStyle.Bold);
      this.btnExcluir.Click += (sender, e) =>
      {
        DialogResult result = MessageBox.Show(
          "Deseja realmente excluir o Saldo?",
          "Excluir Saldo",
          MessageBoxButtons.YesNo,
          MessageBoxIcon.Question
        );

        if (result == DialogResult.No) return;

        Controllers.Saldo.DeleteSaldoById(
          int.Parse(this.lista.SelectedItems[0].Text)
        );
        this.LoadList();

      };

      this.btnCancelar.Text = "Voltar";
      this.btnCancelar.Location = new Point(310, 450);
      this.btnCancelar.Size = new Size(90, 30);
      this.btnCancelar.Font = new Font("Arial", 12, FontStyle.Bold);
      this.btnCancelar.Click += (sender, e) => this.Close();

      this.Controls.Add(this.titulo);
      this.Controls.Add(this.lista);
      this.Controls.Add(this.btnSalvar);
      this.Controls.Add(this.btnEditar);
      this.Controls.Add(this.btnExcluir);
      this.Controls.Add(this.btnCancelar);

      this.Text = "Saldo";
      this.Size = new Size(750, 600);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.TopMost = true;

      this.ShowDialog();

    }

    private void LoadList()
    {
      this.lista.Items.Clear();

      foreach (Models.Almoxarifado almoxarife in Controllers.Almoxarifado.GetAlmoxarifados())
      {
        ListViewItem item = new ListViewItem(almoxarife.Id.ToString());
        item.SubItems.Add(almoxarife.Nome);
        this.lista.Items.Add(item);
      }
    }
  }
}