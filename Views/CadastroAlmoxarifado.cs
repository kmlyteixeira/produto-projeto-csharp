using System.Drawing;
using System.Windows.Forms;

namespace Views {
  public class CadastroAlmoxarifado : Form
  {
    private Label titulo;
    private Label lblNome;
    private TextBox txtNome;
    private Button btnSalvar;
    private Button btnCancelar;
    private ListView lista;
    private Button btnEditar;
    private Button btnExcluir;

    public CadastroAlmoxarifado(int id)
    {
      InitializeComponent(id);
    }

    public void InitializeComponent(int id)
    {
      this.titulo = new Label();
      this.lblNome = new Label();
      this.txtNome = new TextBox();
      this.btnSalvar = new Button();
      this.btnCancelar = new Button();

      this.titulo.Text = "Almoxarifado";
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

      if (id != 0)
      {
        Models.Almoxarifado almoxarife = Controllers.Almoxarifado.GetAlmoxarifadoById(id);
        this.txtNome.Text = almoxarife.Nome;
      }

      this.btnSalvar.Text = "Salvar";
      this.btnSalvar.Location = new Point(10, 200);
      this.btnSalvar.Size = new Size(130, 30);
      this.btnSalvar.Font = new Font("Arial", 12, FontStyle.Bold);
      this.btnSalvar.Click += (sender, e) =>
      {
        if (id == 0)
        {
          Controllers.Almoxarifado.CreateAlmoxarifado(this.txtNome.Text);
        } else {
          Controllers.Almoxarifado.UpdateAlmoxarifadoById(id, this.txtNome.Text);
        }
        this.Close();
      };

      this.btnCancelar.Text = "Cancelar";
      this.btnCancelar.Location = new Point(160, 200);
      this.btnCancelar.Size = new Size(130, 30);
      this.btnCancelar.Font = new Font("Arial", 12, FontStyle.Bold);
      this.btnCancelar.Click += (sender, e) => {
        this.Close();
        new Almoxarifado();
      };

      this.Controls.Add(this.titulo);
      this.Controls.Add(this.lblNome);
      this.Controls.Add(this.txtNome);
      this.Controls.Add(this.btnSalvar);
      this.Controls.Add(this.btnCancelar);

      this.Text = "Almoxarifado";
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
  }
}