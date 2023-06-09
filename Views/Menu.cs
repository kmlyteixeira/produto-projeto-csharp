using System.Drawing;
using System.Windows.Forms;

namespace Views {
  public class Menu : Form {

    private Label titulo;
    private Button btnProduto;
    private Button btnAlmoxarife;
    private Button btnSaldo;
    private Button btnSair;
        
    public Menu(){
      InitializeComponent();
    }

    public void InitializeComponent() {
      this.titulo = new Label();
      this.btnProduto = new Button();
      this.btnSair = new Button();
      this.btnAlmoxarife = new Button();
      this.btnSaldo = new Button();

      this.titulo.Text = "Menu";
      this.titulo.Location = new Point(10, 10);
      this.titulo.Size = new Size(280, 30);
      this.titulo.TextAlign = ContentAlignment.MiddleCenter;
      this.titulo.Font = new Font("Arial", 20, FontStyle.Bold);

      this.btnProduto.Text = "Produto";
      this.btnProduto.Location = new Point(10, 130);
      this.btnProduto.Size = new Size(280, 30);
      this.btnProduto.Font = new Font("Arial", 12, FontStyle.Bold);
      this.btnProduto.Click += (sender, e) => {
        new Produto();
      };

      this.btnAlmoxarife.Text = "Almoxarifado";
      this.btnAlmoxarife.Location = new Point(10, 170);
      this.btnAlmoxarife.Size = new Size(280, 30);
      this.btnAlmoxarife.Font = new Font("Arial", 12, FontStyle.Bold);
      this.btnAlmoxarife.Click += (sender, e) => {
        new Almoxarifado();
      };

      this.btnSaldo.Text = "Saldo";
      this.btnSaldo.Location = new Point(10, 210);
      this.btnSaldo.Size = new Size(280, 30);
      this.btnSaldo.Font = new Font("Arial", 12, FontStyle.Bold);
      this.btnSaldo.Click += (sender, e) => {
        new Saldo();
      };

      this.btnSair.Text = "Sair";
      this.btnSair.Location = new Point(10, 250);
      this.btnSair.Size = new Size(280, 30);
      this.btnSair.Font = new Font("Arial", 12, FontStyle.Bold);
      this.btnSair.Click += (sender, e) => {
        Application.Exit();
      };
      
      this.Controls.Add(this.titulo);
      this.Controls.Add(this.btnProduto);
      this.Controls.Add(this.btnAlmoxarife);
      this.Controls.Add(this.btnSaldo);
      this.Controls.Add(this.btnSair);

      this.Text = "Menu";
      this.Size = new Size(320, 500);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.ShowDialog();
    }
  }
}