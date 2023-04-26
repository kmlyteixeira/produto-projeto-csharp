using System.Drawing;
using System.Windows.Forms;

namespace Views
{
  public class CadastroSaldo : Form
  {
    private Label titulo;
    private Label lblQuantidade;
    private Label lblProduto;
    private TextBox txtQuantidade;
    private Button btnSalvar;
    private Button btnCancelar;
    private ComboBox cbProduto;
    private Label lblAlmoxarifado;
    private ComboBox cbAlmoxarifado;

    public CadastroSaldo(int id)
    {
      InitializeComponent(id);
    }

    public void InitializeComponent(int id)
    {
      this.titulo = new Label();
      this.lblQuantidade = new Label();
      this.lblProduto = new Label();
      this.txtQuantidade = new TextBox();
      this.btnSalvar = new Button();
      this.btnCancelar = new Button();
      this.cbProduto = new ComboBox();
      this.lblAlmoxarifado = new Label();
      this.cbAlmoxarifado = new ComboBox();

      this.titulo.Text = "Saldo";
      this.titulo.Location = new Point(10, 10);
      this.titulo.Size = new Size(280, 30);
      this.titulo.TextAlign = ContentAlignment.MiddleCenter;
      this.titulo.Font = new Font("Arial", 20, FontStyle.Bold);

      this.lblQuantidade.Text = "Quantidade";
      this.lblQuantidade.Location = new Point(10, 50);
      this.lblQuantidade.Size = new Size(280, 30);
      this.lblQuantidade.Font = new Font("Arial", 12, FontStyle.Bold);
      
      this.txtQuantidade.Location = new Point(10, 80);
      this.txtQuantidade.Size = new Size(280, 30);
      this.txtQuantidade.Font = new Font("Arial", 12, FontStyle.Bold);

      this.lblProduto.Text = "Produto";
      this.lblProduto.Location = new Point(10, 110);
      this.lblProduto.Size = new Size(280, 30);
      this.lblProduto.Font = new Font("Arial", 12, FontStyle.Bold);

      this.cbProduto.Location = new Point(10, 140);
      this.cbProduto.Size = new Size(280, 30);
      this.cbProduto.Font = new Font("Arial", 12, FontStyle.Bold);
      
      foreach (Models.Produto produto in Controllers.Produto.GetProdutos())
      {
        this.cbProduto.Items.Add(produto.Nome);
      };

      this.lblAlmoxarifado.Text = "Almoxarifado";
      this.lblAlmoxarifado.Location = new Point(10, 170);
      this.lblAlmoxarifado.Size = new Size(280, 30);
      this.lblAlmoxarifado.Font = new Font("Arial", 12, FontStyle.Bold);

      this.cbAlmoxarifado.Location = new Point(10, 200);
      this.cbAlmoxarifado.Size = new Size(280, 30);
      this.cbAlmoxarifado.Font = new Font("Arial", 12, FontStyle.Bold);

      foreach (Models.Almoxarifado almoxarifado in Controllers.Almoxarifado.GetAlmoxarifados())
      {
        this.cbAlmoxarifado.Items.Add(almoxarifado.Nome);
      };

      if (id != 0)
      {
        Models.Saldo saldo = Controllers.Saldo.GetSaldoById(id);
        this.txtQuantidade.Text = saldo.Quantidade.ToString();
        this.cbProduto.Text = saldo.Produto.Nome;
        this.cbAlmoxarifado.Text = saldo.Almoxarifado.Nome;
      }

      this.btnSalvar.Text = "Salvar";
      this.btnSalvar.Location = new Point(10, 240);
      this.btnSalvar.Size = new Size(130, 30);
      this.btnSalvar.Font = new Font("Arial", 12, FontStyle.Bold);
      this.btnSalvar.Click += (sender, e) => {
        if (id == 0)
        {
          Controllers.Saldo.CreateSaldo(this.txtQuantidade.Text, this.cbProduto.Text, this.cbAlmoxarifado.Text);
        } else {
          Controllers.Saldo.UpdateSaldoById(id, this.txtQuantidade.Text, this.cbProduto.Text, this.cbAlmoxarifado.Text);
        }
        this.Close();
      };

      this.btnCancelar.Text = "Cancelar";
      this.btnCancelar.Location = new Point(150, 240);
      this.btnCancelar.Size = new Size(130, 30);
      this.btnCancelar.Font = new Font("Arial", 12, FontStyle.Bold);
      this.btnCancelar.Click += (sender, e) => this.Close();

      this.Controls.Add(this.titulo);
      this.Controls.Add(this.lblQuantidade);
      this.Controls.Add(this.lblProduto);
      this.Controls.Add(this.txtQuantidade);
      this.Controls.Add(this.btnSalvar);
      this.Controls.Add(this.btnCancelar);
      this.Controls.Add(this.cbProduto);
      this.Controls.Add(this.lblAlmoxarifado);
      this.Controls.Add(this.cbAlmoxarifado);

      this.Text = "Cadastro de Saldo";
      this.Size = new Size(300, 300);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.BackColor = Color.White;
      
    }

  }
}