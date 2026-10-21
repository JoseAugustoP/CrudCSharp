using System.Security.Cryptography;
using MySql.Data.MySqlClient;

namespace CrudCSharp.Codigos
{
    public class conexaoMySql
    {
        private static MySqlConnection Conectar()
        {
            return new MySqlConnection("Server=localhost;Port=3306;Database=CrudCSharp;User=root;Password=ze13ze18@;");
        }

        public static string Funcao_INSERT(string tabela, Control ctrPai)
        {
            PegarListaCampos(ctrPai);

            string Campos = "";
            string Parametros = "";

            foreach(Control ctr in Controles)
            {
                string Coluna = PegarTag(ctr, "col");

                Campos += Coluna + ", ";
                Parametros += "@" + Coluna + ", ";
            }

            Campos = Campos.TrimEnd(' ').TrimEnd(',');
            Parametros = Parametros.TrimEnd(' ').TrimEnd(',');


            return $"INSERT INTO {tabela} ({Campos}) VALUES ({Parametros})";
        }

        public static List<Control> Controles = new List<Control>();
        public static void PegarListaCampos(Control pai)
        {
            foreach (Control ctr in pai.Controls)
            {
            if (ctr.Tag != null)
                {
                    if (ctr.Tag.ToString().Contains("col="))
                    {
                        Controles.Add(ctr);
                    }
                }
            }
        }


        public static string PegarTag(Control ctrPai, string Propriedade)
        {
            string[] configuracoes = ctrPai.Tag.ToString().Split('/');

            foreach (string config in configuracoes)
            {
                string[] p = config.Split('=');

                if (p[0] == Propriedade)
                    return p[1];
            }

            return "";
        }

        public static void Salvar(string tabela, Control ctrPai)
        {
            using(MySqlConnection con = Conectar())
            {
                con.Open();
                
                using(MySqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = Funcao_INSERT(tabela, ctrPai);

                    foreach(Control ctr in Controles)
                    {
                        string coluna = PegarTag(ctr, "col");
                        cmd.Parameters.AddWithValue("@" + coluna, ctr.Text);
                    }
                    cmd.ExecuteNonQuery();
                }
                
            }
        }
    }
}
