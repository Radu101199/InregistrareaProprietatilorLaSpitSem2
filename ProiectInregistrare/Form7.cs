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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet7.Proprietari' table. You can move, or remove it, as needed.
            this.proprietariTableAdapter.Fill(this.dataSet7.Proprietari);
            // TODO: This line of code loads data into the 'dataSet7.Proprietari' table. You can move, or remove it, as needed.
            this.proprietariTableAdapter.Fill(this.dataSet7.Proprietari);
            // TODO: This line of code loads data into the 'dataSet2.Clienti' table. You can move, or remove it, as needed.
            this.proprietariTableAdapter.Fill(this.dataSet7.Proprietari);
            // TODO: This line of code loads data into the 'dataSet1.Persoane' table. You can move, or remove it, as needed.
            txtIdClient.Visible = false;
            lblIdClient.Visible = false;
            A1();

        }

        private void A1()
        {
            this.proprietariTableAdapter.Fill(this.dataSet7.Proprietari);

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            A3();
        }

        private void A2()
        {
            configureazaButoane(false);
            legareControale(false);
            protectiePanel(false);
            lblOp.Text = "Adaugare";
            txtIdClient.ReadOnly = true;

            txtNume.Focus();
            golireCampuri();
        }

        private void A3()
        {
            configureazaButoane(true);
            legareControale(true);
            protectiePanel(true);
            lblOp.Text = "";
        }

        private void A4()
        {
            if (lblOp.Text == "Adaugare")
            {
                if (!validareCampuriObligatorii())
                {
                    return;
                }

                //adauga_inregistrare();
                if (adauga_inregistrare() == false)
                {
                    return;
                }
                else
                {
                    golireCampuri();

                    txtNume.Focus();
                    refresh_grid(proprietariBindingSource.Position);
                }
            }
            else if (lblOp.Text == "Modificare")
            {
                if (!validareCampuriObligatorii())
                {
                    return;
                }
                if (modifica_inregistrarea() == false)
                {
                    return;
                }

                refresh_grid(proprietariBindingSource.Position);
                A3();
            }
            else
            {
                MessageBox.Show("Operatie actualizare neefectuata!");
            }

        }

        private bool A5(TextBox txtB)
        {
            decimal p;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader r;

            //if (lblOp.Text == "") return false;
            //if (txtB.Text == "") return false;
            //if (btnRenuntare.Focused) return false;

            try { p = Convert.ToDecimal(txtB.Text); }
            catch { MessageBox.Show("Format eronat"); return false; }
            con.ConnectionString = proprietariTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            string nrTelefon = txtB.Text.Trim();
            string idPersoana = txtIdClient.Text.Trim();
            if (string.IsNullOrEmpty(nrTelefon))
            {
                MessageBox.Show("Numarul de telefon nu poate fi gol!");
                txtB.Focus();
                return false;
            }

            cmd.CommandText = "SELECT IdProprietar,NumeProprietar FROM Proprietari WHERE NrTel = @NrTel";
            cmd.Parameters.AddWithValue("@NrTel", nrTelefon);

            con.Open();
            r = cmd.ExecuteReader();

            if (r.Read())
            {
                if (lblOp.Text == "Modificare" && idPersoana.Equals(r["IdProprietar"].ToString()))
                {
                    con.Close();
                    return true;
                }
                MessageBox.Show("Numarul de telefon exista deja!");
                txtB.Focus();
                con.Close();
                return false;
            }

            con.Close();
            return true;
        }

        private void A7()
        {
            configureazaButoane(false);
            legareControale(false);
            protectiePanel(false);
            lblOp.Text = "Modificare";
            txtNume.Focus();
        }

        private void A8()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader r;
            con.ConnectionString = proprietariTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            cmd.CommandText = "select IdProprietar from Inregistrari where IdProprietar=" + txtIdClient.Text;
            con.Open();
            r = cmd.ExecuteReader();
            if (r.Read())
            {
                MessageBox.Show("Proprietarul nu poate fi sters pentru ca detine proprietati!");
                con.Close();
                return;
            }
            con.Close();
            const string mesaj = "Stergeti inregistrarea curenta?";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No)
            {
                return;
            }
            cmd.CommandText = "delete from Proprietari where IdProprietar=" + txtIdClient.Text;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            refresh_grid(proprietariBindingSource.Position);
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
                txtNume.DataBindings.Add("Text", proprietariBindingSource, "NumeProprietar");
                txtCNP.DataBindings.Add("Text", proprietariBindingSource, "CNP");
                txtLocalitate.DataBindings.Add("Text", proprietariBindingSource, "Localitate");
                txtAdresa.DataBindings.Add("Text", proprietariBindingSource, "Adresa");
                txtNrTel.DataBindings.Add("Text", proprietariBindingSource, "NrTel");
                txtIdClient.DataBindings.Add("Text", proprietariBindingSource, "IdProprietar");
            }
            else
            {
                txtNume.DataBindings.Clear();
                txtAdresa.DataBindings.Clear();
                txtNrTel.DataBindings.Clear();
                txtLocalitate.DataBindings.Clear();
                txtCNP.DataBindings.Clear();
                txtIdClient.DataBindings.Clear();

            }
        }

        private void protectiePanel(bool v)
        {
            txtNume.ReadOnly = v;
            txtAdresa.ReadOnly = v;
            txtNrTel.ReadOnly = v;
            txtCNP.ReadOnly = v;
            txtLocalitate.ReadOnly = v;
        }

        private void golireCampuri()
        {
            txtNume.Text = "";
            txtAdresa.Text = "";
            txtNrTel.Text = "";
            txtLocalitate.Text = "";
            txtCNP.Text = "";
            txtIdClient.Text = "";

        }

        private bool validareCampuriObligatorii()
        {
            if (txtNume.Text == "")
            {
                MessageBox.Show("Numele este obligatoriu!");
                txtNume.Focus();
                return false;
            }
            if (txtCNP.Text == "")
            {
                MessageBox.Show("CNP este obligatoriu!");
                txtCNP.Focus();
                return false;
            }
            if (txtLocalitate.Text == "")
            {
                MessageBox.Show("Localitatea este obligatorie!");
                txtLocalitate.Focus();
                return false;
            }
            if (txtAdresa.Text == "")
            {
                MessageBox.Show("Adresa este obligatorie!");
                txtAdresa.Focus();
                return false;
            }
            if (txtNrTel.Text == "")
            {
                MessageBox.Show("Numarul de telefon este obligatoriu!");
                txtNrTel.Focus();
                return false;
            }
            return true;
        }

        private bool adauga_inregistrare()
        {
            string listaCampuri;
            string listaValori;
            if (!A5(txtNrTel))
            {
                txtNrTel.Focus();
                return false;
            }
            else
            {
                OleDbConnection con = new OleDbConnection();
                OleDbCommand cmd = new OleDbCommand();
                OleDbDataReader r;
                con.ConnectionString = proprietariTableAdapter.Connection.ConnectionString;
                cmd.Connection = con;

                cmd.CommandText = "Select IdProprietar from PROPRIETARI where CNP='" + txtCNP.Text + "'";
                con.Open();
                r = cmd.ExecuteReader();
                if (r.Read())
                {
                    MessageBox.Show("Nu pot exista 2 proprietari cu acelasi CNP!");
                    con.Close();
                    return false;
                }

                con.Close();
                listaCampuri = "NumeProprietar, CNP, Localitate, Adresa, NrTel";
                listaValori = "'" + txtNume.Text + "', '" + txtCNP.Text + "', '" + txtLocalitate.Text + "', '" + txtAdresa.Text + "', '" + txtNrTel.Text + "'";
                cmd.CommandText = "insert into Proprietari (" + listaCampuri + ") values (" + listaValori + ")";
                con.Open();

                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
        }

        private void refresh_grid(int p)
        {
            this.proprietariTableAdapter.Fill(this.dataSet7.Proprietari);
            proprietariBindingSource.Position = p;
        }

        private bool modifica_inregistrarea()
        {
            string listaSet;
            if (!A5(txtNrTel))
            {
                return false;
            }
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader r;
            con.ConnectionString = proprietariTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            cmd.CommandText = "Select IdProprietar from Proprietari where CNP='" + txtCNP.Text + "'";
            con.Open();
            r = cmd.ExecuteReader();
            if (r.Read())
            {
                MessageBox.Show("Nu pot exista 2 proprietari cu acelasi CNP!");
                con.Close();
                return false;
            }

            con.Close();
            listaSet = "NumeProprietar='" + txtNume.Text + "', CNP='" + txtCNP.Text + "', Localitate='" + txtLocalitate.Text + "', Adresa='" + txtAdresa.Text + "', NrTel='" + txtNrTel.Text + "'";
            cmd.CommandText = "update Proprietari set " + listaSet + " where IdProprietar=" + txtIdClient.Text;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
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

            A8();
        }


    }
}
