using System.Drawing;
using System.Windows.Forms;

namespace Views {
  public class Produto : Form {
     
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


    public Produto() {
      HomeProdutos();
    }

    public void HomeProdutos() {
      this.titulo = new Label();
      this.lista = new ListView();
      this.btnSalvar = new Button();
      this.btnEditar = new Button();
      this.btnExcluir = new Button();
      this.btnCancelar = new Button();

      this.titulo.Text = "Lista de Produtos";
      this.titulo.Location = new Point(10, 10);
      this.titulo.Size = new Size(280, 30);
      this.titulo.TextAlign = ContentAlignment.MiddleCenter;
      this.titulo.Font = new Font("Arial", 20, FontStyle.Bold);

      this.lista.Location = new Point(10, 50);
      this.lista.Size = new Size(280, 200);
      this.lista.View = View.Details;
      this.lista.FullRowSelect = true;
      this.lista.GridLines = true;
      this.lista.Columns.Add("Id", 50);
      this.lista.Columns.Add("Nome", 100);
      this.lista.Columns.Add("Preço", 100);

      this.btnSalvar.Text = "Incluir";
      this.btnSalvar.Location = new Point(10, 260);
      this.btnSalvar.Size = new Size(90, 30);
      this.btnSalvar.Font = new Font("Arial", 12, FontStyle.Bold);
      this.btnSalvar.Click += (sender, e) => {
        new Produto().CadastroProduto();
      };

      this.btnEditar.Text = "Editar";
      this.btnEditar.Location = new Point(110, 260);
      this.btnEditar.Size = new Size(90, 30);
      this.btnEditar.Font = new Font("Arial", 12, FontStyle.Bold);
      this.btnEditar.Click += (sender, e) => {
        new Produto().CadastroProduto();
      };

      this.btnExcluir.Text = "Excluir";
      this.btnExcluir.Location = new Point(210, 260);
      this.btnExcluir.Size = new Size(90, 30);
      this.btnExcluir.Font = new Font("Arial", 12, FontStyle.Bold);
      this.btnExcluir.Click += (sender, e) => {
        // chamar função de exclusão
      };

    }

    public void CadastroProduto() {
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
      this.btnSalvar.Click += (sender, e) => {
        Controllers.Produto produto = new Controllers.Produto(
          this.txtNome.Text,
          this.txtPreco.Text
        );
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
      this.ShowDialog();
    }
  }
}