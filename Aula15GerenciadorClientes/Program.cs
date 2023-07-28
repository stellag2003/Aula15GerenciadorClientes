namespace Aula15GerenciadorClientes
{
    internal class Program
    {
       public static List<Cliente> clientes = new List<Cliente>();

        
        [STAThread]
        static void Main()
        {
            
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}