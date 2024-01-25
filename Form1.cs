using MySql.Data.MySqlClient;

namespace _21___Anagrafica_in_classe
{
    public partial class Form1 : Form
    {
        string ConnectionString = "server=127.0.0.1;" +
                                    "database=anagrafica2iot;" +
                                    "uid=anagrafica2iot;" +
                                    "pwd=2iot";
        public Form1()
        {
            InitializeComponent();
            //TestConnessione();
            PololaTabella();
        }

        public void PololaTabella()
        {
            MySqlConnection connessione = new MySqlConnection(ConnectionString);
            try
            {
                connessione.Open();
                string query = "SELECT * FROM utenti";
                MySqlCommand cmd = new MySqlCommand(query, connessione);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dataGridView1.Rows.Add(
                        dr.GetInt32("Id").ToString(),
                        dr.GetString("Nome"),
                        dr.GetString("Cognome"),
                        dr.GetDateTime("DataNascita").ToString("dd/MM/yyyy")
                    );
                }

                connessione.Close();
            }
            catch
            {
                MessageBox.Show("Impossibile stabilire una connessione al DB");
            }
        }

        public void TestConnessione()
        {
            MySqlConnection connessione = new MySqlConnection(ConnectionString);
            try
            {
                connessione.Open();
                connessione.Close();
            }
            catch
            {
                MessageBox.Show("Impossibile stabilire una connessione al DB");
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            FormModifica formModifica = new FormModifica(id);

            formModifica.ShowDialog();

        }
    }
}