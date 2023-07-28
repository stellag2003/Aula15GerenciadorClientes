using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula15GerenciadorClientes
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        void atualizaInterface()
        {
            list.Clear();
            for (int i = 0; i < Program.clientes.Count; i++)
            {
                list.Items.Add(Program.clientes[i].nome);
                
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string usuarioCadastro = txtUsuario2.Text;
            string senha = txtSenha2.Text;
            string nome = txtNome.Text;
            int idade = 2023 - int.Parse(txtAno.Text);

            Usuario usuario = new Usuario(usuarioCadastro, senha);
            Cliente cliente = new Cliente(nome, idade, usuario);
            Program.clientes.Add(cliente);
            atualizaInterface();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            atualizaInterface();
        }
    }
}      
