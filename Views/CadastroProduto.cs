using System.Drawing;
using System.Windows.Forms;

namespace Views {
  public class CadastroProduto : Form
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

    public CadastroProduto()
    {
      InitializeComponent();
    }

    public CadastroProduto(int id)
    {
      AlteraProduto(id);
    }

    public void InitializeComponent()
    {
      this.titulo = new Label();
      this.lblNome = new Label();
      this.lblPreco = new Label();
      this.txtNome = new TextBox();
      this.txtPreco = new TextBox();
      this.btnSalvar = new Button();
      this.btnCancelar = new Button();

      this.titulo.Text = "Produto";
      this.titulo.Location = new Point(10, 10);
      this.titulo.Size = new Size(280, 30);
      this.titulo.TextAlign = ContentAlignment.MiddleCenter;
      this.titulo.Font = new Font("Arial", 20, FontStyle.Bold);

      this.lblNome.Text = "Nome";
      this.lblNome.Location = new Point(10, 50);
      this.lblNome.Size = new Size(280, 30);
      this.lblNome.Font = new Font("Arial", 12, FontStyle.Bold);

      this.txtNome.Location = new Point(10, 80);
      this.txtNome.Size = new Size(280, 30);
      this.txtNome.Font = new Font("Arial", 12, FontStyle.Bold);

      this.lblPreco.Text = "Preço";
      this.lblPreco.Location = new Point(10, 110);
      this.lblPreco.Size = new Size(280, 30);
      this.lblPreco.Font = new Font("Arial", 12, FontStyle.Bold);

      this.txtPreco.Location = new Point(10, 140);
      this.txtPreco.Size = new Size(280, 30);
      this.txtPreco.Font = new Font("Arial", 12, FontStyle.Bold);

      this.btnSalvar.Text = "Salvar";
      this.btnSalvar.Location = new Point(10, 200);
      this.btnSalvar.Size = new Size(130, 30);
      this.btnSalvar.Font = new Font("Arial", 12, FontStyle.Bold);
      this.btnSalvar.Click += (sender, e) =>
      {
        Controllers.Produto.CreateProduto(this.txtNome.Text, double.Parse(this.txtPreco.Text));
        this.Close();
      };

      this.btnCancelar.Text = "Cancelar";
      this.btnCancelar.Location = new Point(160, 200);
      this.btnCancelar.Size = new Size(130, 30);
      this.btnCancelar.Font = new Font("Arial", 12, FontStyle.Bold);
      this.btnCancelar.Click += (sender, e) => this.Close();

      this.Controls.Add(this.titulo);
      this.Controls.Add(this.lblNome);
      this.Controls.Add(this.txtNome);
      this.Controls.Add(this.lblPreco);
      this.Controls.Add(this.txtPreco);
      this.Controls.Add(this.btnSalvar);
      this.Controls.Add(this.btnCancelar);

      this.Text = "Produto";
      this.Size = new Size(500, 350);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.TopMost = true;
      this.Visible = false;
      this.ShowDialog();
    }

    public void AlteraProduto(int id)
    {
      // TODO: CRIA TELA ALTERAR PRODUTO
    }
  }
}