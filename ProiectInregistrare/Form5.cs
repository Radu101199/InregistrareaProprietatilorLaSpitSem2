using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ProiectFinal
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            A1();
        }

        private void A1()
        {
            //Umple cu date obiectele DataTable: Persoane, Localitati (din DataSet):
            inregistrariTableAdapter.Fill(dataSet5.Inregistrari);
            tipProprietateTableAdapter.Fill(dataSet5.TipProprietate);
            proprietariTableAdapter.Fill(dataSet5.Proprietari);

            
            //Protectie grid 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;

            //Protectie txtIdPersoana
            //txtId.ReadOnly = true;

            A3();
        }
        private void A2()
        {
            //Configurare butoane
            configureazaButoane(false);

            //Dezlegare controale Panel
            legareControale(false);

            //Ridicare protectie controale Panel
            protectiePanel(false);

            //Modifcare lblOp
            lblOp.Text = "ADAUGARE";

            //Pozitionare cursor pe primul camp
            valoareTextBox.Focus();

            // Golire campuri
            golireCampuri();
        }
        private void A3()
        {
            //Initializare lblOp
            lblOp.Text = "";

            //Çonfigurare(butoane)
            configureazaButoane(true);

            //Protectie componente Panel
            protectiePanel(true);

            //Legare controale
            legareControale(true);
        }

        private void A4()
        {
            if (lblOp.Text == "ADAUGARE")
            {
                if (!validareCampuriObligatorii()) return;

                adauga_inregistrare();

                golireCampuri();

                //Pune cursor pe primul camp
                valoareTextBox.Focus();
                refresh_grid(inregistrariBindingSource.Position);
            }
            else if (lblOp.Text == "MODIFICARE")
            {
                modifica_inregistrare();
                refresh_grid(inregistrariBindingSource.Position);
                A3();
            }
            else
                MessageBox.Show("Operatie actualizare neefectuata");
        }

        private void A7()
        {
            //Configurare butoane
            configureazaButoane(false);

            //Dezlegare controale Panel
            legareControale(false);

            //Ridicare protectie controale Panel
            protectiePanel(false);

            //Modifcare lblOp
            lblOp.Text = "MODIFICARE";

            //Pozitionare cursor pe primul camp
            valoareTextBox.Focus();
        }

        private void configureazaButoane(bool v)
        {
            btnRenuntare.Visible = !v;
            btnConfirmare.Visible = !v;

            btnAdaugare.Enabled = v;
            btnModificare.Enabled = v;
            btnStergere.Enabled = v;
        }

        private void legareControale(bool v)
        {
            if (v)
            {
                valoareTextBox.DataBindings.Add("Text", inregistrariBindingSource, "Valoare");
                dateTimePicker1.DataBindings.Add("Text", inregistrariBindingSource, "DataInregistrare");
                comboBox1.DataBindings.Add("Text", inregistrariBindingSource, "DenumireTipProprietate");
                comboBox2.DataBindings.Add("Text", inregistrariBindingSource, "CNP");
            }
            else
            {
                valoareTextBox.DataBindings.Clear();
                dateTimePicker1.DataBindings.Clear();
                comboBox1.DataBindings.Clear();
                comboBox2.DataBindings.Clear();
            }
        }

        private void protectiePanel(bool v)
        {
            valoareTextBox.ReadOnly = v;
            dateTimePicker1.Enabled = !v;
            comboBox1.Enabled = !v;
            comboBox2.Enabled = !v;
        }
        private void golireCampuri()
        {
            valoareTextBox.Text = "";
            dateTimePicker1.Text = "";
            
        }

        private bool validareCampuriObligatorii()
        {
            //Validare de completare obligatorie campurile: Nume, CNP, Salariu, Localitate
            if (valoareTextBox.Text == "")
            {
                MessageBox.Show("Completati Valoare Proprietate !");
                valoareTextBox.Focus();
                return false;
            }
            if (dateTimePicker1.Value == null)
            {
                MessageBox.Show("Completati Data Inregistrare !");
                dateTimePicker1.Focus();
                return false;
            }
            
            return true;
        }

        private void adauga_inregistrare()
        {
            string listaCampuri;
            string listaValori;

            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();

            con.ConnectionString = inregistrariTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;
            
            DateTime d = dateTimePicker1.Value;
            listaCampuri = "DataInregistrare, IdProprietar, IdTipProprietate, Valoare";
   
            listaValori = "#" + Convert.ToString(d.Month) + "/"
                           + Convert.ToString(d.Day) + "/"
                           + Convert.ToString(d.Year) + "#," +
                           comboBox2.SelectedValue +
                           ","+comboBox1.SelectedValue +
                           ","+valoareTextBox.Text;



            cmd.CommandText = "Insert into Inregistrari(" + listaCampuri + ") " +
                              "Select " + listaValori;

           

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void refresh_grid(int p)
        {
            inregistrariTableAdapter.Fill(dataSet5.Inregistrari);
            inregistrariBindingSource.Position = p;
        }
        private void modifica_inregistrare()
        {
            string listaSet;

            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader r;

            con.ConnectionString = inregistrariTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;

            cmd.CommandText = "Select IdInregistrare From Radieri Where IdInregistrare = " + txtIdInregistrare.Text;
            con.Open();
            r = cmd.ExecuteReader();
            if (r.Read())
            {
                MessageBox.Show("Inregistrarea aceasta a fost radiata, nu poate fi modificata!");
                con.Close();
                return;
            }
            con.Close();

            DateTime d = dateTimePicker1.Value;
            listaSet = "Set DataInregistrare = #" + d.Month + "/"
                           + d.Day + "/"
                           + d.Year + "#," 
                       +"IdProprietar = " + comboBox2.SelectedValue 
                       +",IdTipProprietate = " + comboBox1.SelectedValue 
                       +",Valoare = " + valoareTextBox.Text;

           


            cmd.CommandText = "Update Inregistrari " + listaSet + " Where IdInregistrare=" + txtIdInregistrare.Text;

            

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }
        private void A8()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader r;

            con.ConnectionString = inregistrariTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;

            cmd.CommandText = "Select IdInregistrare From Radieri Where IdInregistrare = " + txtIdInregistrare.Text;
            con.Open();
            r = cmd.ExecuteReader();
            if (r.Read())
            {
                MessageBox.Show("Inregistrarea aceasta a fost radiata!");
                con.Close();
                return;
            }
            con.Close();

            cmd.CommandText = "Delete From Inregistrari Where IdInregistrare = " + txtIdInregistrare.Text;

            MessageBox.Show(cmd.CommandText);

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();

            refresh_grid(inregistrariBindingSource.Position);

        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            A2();
        }
        private void btnRenuntare_Click(object sender, EventArgs e)
        {
            A3();
        }
        private void btnConfirmare_Click(object sender, EventArgs e)
        {
            A4();
        }
        private void btnModificare_Click(object sender, EventArgs e)
        {
            A7();
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) return;
            A8();
        }
    }
}

