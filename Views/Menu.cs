using System.Drawing;
using System.Windows.Forms;

namespace Views {
  public class Menu : Form {

    private Label titulo;
    private Button btnProduto;
    private Button btnSair;
        
    public Menu(){
      InitializeComponent();
    }

    public void InitializeComponent() {
      this.titulo = new Label();
      this.btnProduto = new Button();
      this.btnSair = new Button();

      this.titulo.Text = "Menu";
      this.titulo.Location = new Point(10, 10);
      this.titulo.Size = new Size(280, 30);
      this.titulo.TextAlign = ContentAlignment.MiddleCenter;
      this.titulo.Font = new Font("Arial", 20, FontStyle.Bold);

      this.btnProduto.Text = "Produtos";
      this.btnProduto.Location = new Point(10, 50);
      this.btnProduto.Size = new Size(280, 30);
      this.btnProduto.Font = new Font("Arial", 12, FontStyle.Bold);
      this.btnProduto.Click += (sender, e) => {
        this.Hide();
        new Produto();
      };

      this.btnSair.Text = "Sair";
      this.btnSair.Location = new Point(10, 90);
      this.btnSair.Size = new Size(280, 30);
      this.btnSair.Font = new Font("Arial", 12, FontStyle.Bold);
      this.btnSair.Click += (sender, e) => this.Close();
      
      this.Controls.Add(this.titulo);
      this.Controls.Add(this.btnProduto);
      this.Controls.Add(this.btnSair);

      this.Text = "Menu";
      this.Size = new Size(500, 350);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.ShowDialog();
    }
  }
}