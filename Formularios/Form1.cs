using CrudCSharp.Codigos;
using MySql.Data.MySqlClient;

namespace CrudCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexaoMySql.Salvar("produto", this);
            
        }
    }
}
