using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _21___Anagrafica_in_classe
{

    public partial class FormModifica : Form
    {
        public string id_utente;

        public FormModifica(string id)
        {
            InitializeComponent();
            id_utente = id;
            PopolaForm();
        }

        public void PopolaForm()
        {
            string ConnectionString = "server=127.0.0.1;" +
                                    "database=anagrafica2iot;" +
                                    "uid=anagrafica2iot;" +
                                    "pwd=2iot";
            MySqlConnection connessione = new MySqlConnection(ConnectionString);
            try
            {
                connessione.Open();
                //string query = "SELECT * FROM utenti WHERE id = '" + id + "'";
                string query = $"SELECT * FROM utenti WHERE id = '{id_utente}'";
                MySqlCommand cmd = new MySqlCommand(query, connessione);
                MySqlDataReader dr = cmd.ExecuteReader();

                dr.Read();
                textBoxNome.Text = dr.GetString("Nome");
                textBoxCognome.Text = dr.GetString("Cognome");
                dateTimePicker1.Value = dr.GetDateTime("DataNascita");
                string path = $"../../../immagini/noimage.png";
                if (File.Exists($"../../../immagini/{dr.GetString("Immagine")}"))
                {
                    path = $"../../../immagini/{dr.GetString("Immagine")}";
                }
                else
                {
                    if (File.Exists($"../../../immagini/{dr.GetString("Id")}.jpg"))
                        path = $"../../../immagini/{dr.GetString("Id")}.jpg";
                }
                pictureBoxImmagine.Image = new Bitmap(path);
                dr.Close();

                connessione.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // modificare il record nel database
            string ConnectionString = "server=127.0.0.1;" +
                                    "database=anagrafica2iot;" +
                                    "uid=anagrafica2iot;" +
                                    "pwd=2iot";
            MySqlConnection connessione = new MySqlConnection(ConnectionString);
            try
            {
                connessione.Open();

                string query = $"UPDATE utenti " +
                    $"SET " +
                    $"Nome = '{textBoxNome.Text}', " +
                    $"Cognome = '{textBoxCognome.Text}', " +
                    $"DataNascita = '{dateTimePicker1.Value.ToString("yyyy-MM-dd")}' " +
                    $"WHERE id = '{id_utente}'";
                MySqlCommand cmd = new MySqlCommand(query, connessione);
                cmd.ExecuteNonQuery();

                connessione.Close();
            }
            catch
            {
                MessageBox.Show("Impossibile stabilire una connessione al DB");
            }

            this.Close();

        }
    }
}
