namespace Aula15GerenciadorClientes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario("admin","admin");
            Cliente cliente = new Cliente("Admin",0,usuario);
            Program.clientes.Add(cliente);
            

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;
            bool encontrado = false;

            for (int i = 0; i < Program.clientes.Count; i++)
            {
                if (Program.clientes[i].usuario.usuario == usuario && Program.clientes[i].usuario.senha == senha)
                {
                    Form2 form2 = new Form2();
                    form2.Show();
                    encontrado = true;
                }
                 
                if(encontrado == false)
                {
                    MessageBox.Show("Usuário ou senha inválidos","ERROU",MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }


        }
    }
}