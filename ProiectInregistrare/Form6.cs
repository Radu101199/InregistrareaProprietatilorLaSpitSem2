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
    public partial class Form6 : Form
    {
        const int DataRadiere = 1;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet6.Radieri' table. You can move, or remove it, as needed.
            this.radieriTableAdapter.Fill(this.dataSet6.Radieri);
            // TODO: This line of code loads data into the 'dataSet6.Inregistrari' table. You can move, or remove it, as needed.
            this.inregistrariTableAdapter.Fill(this.dataSet6.Inregistrari);
            config(true);
            refresh_grid();
            dataGridView2.Columns[DataRadiere].ReadOnly = true; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell.RowIndex != null) {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                OleDbConnection con = new OleDbConnection();
                OleDbCommand cmd = new OleDbCommand();
                OleDbDataReader r;

                con.ConnectionString = inregistrariTableAdapter.Connection.ConnectionString;

                cmd.Connection = con;




                string listaCampuri = "DataRadiere, IdProprietar, IdTipProprietate, Valoare, IdInregistrare";


                string listaValori = "#" + Convert.ToString(DateTime.Now.Month) + "/"
                               + Convert.ToString(DateTime.Now.Day) + "/"
                               + Convert.ToString(DateTime.Now.Year) + "#," +
                               dataGridView1.CurrentRow.Cells[2].Value +
                               "," + dataGridView1.CurrentRow.Cells[3].Value +
                               "," + dataGridView1.CurrentRow.Cells[4].Value.ToString()
                               + "," + dataGridView1.CurrentRow.Cells[0].Value;



                cmd.CommandText = "Insert into Radieri(" + listaCampuri + ") " +
                                  "Select " + listaValori;
                con.Open();
                cmd.ExecuteReader();
                con.Close();
                refresh_grid();
            }
            else
            {
                MessageBox.Show("Nu exista inregistrari de radiat!");
            }
        }

        private void refresh_grid()
        {
            inregistrariTableAdapter.Fill(dataSet6.Inregistrari);
            
            radieriTableAdapter.Fill(dataSet6.Radieri);
           
        }

        private void config(bool v)
        {

            dataGridView2.AllowUserToDeleteRows = !v;

            //Protectie coloane
            dataGridView2.Columns[DataRadiere].ReadOnly = v;
            
            btnActualizare.Enabled = v;
            btnStergere.Enabled = v;
            btnSalvare.Visible = !v;
            btnRenuntare.Visible = !v;
        }
        private void refresh()
        {
            radieriTableAdapter.Fill(dataSet6.Radieri);
        }
        private bool completareCampuri()
        {
            bool raspuns = true;
            foreach (DataRow r in dataSet6.Radieri)
            {
                if (r.RowState == DataRowState.Deleted) continue;

                
                if (r["DataRadiere"] == DBNull.Value)
                {
                    MessageBox.Show("Completati data radiere la linia " + r["IdRadiere"]);
                    raspuns = false;
                }
            }
            return raspuns;
        }
        // actualizare data radiere
        private void button2_Click(object sender, EventArgs e)
        {
            config(false);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!completareCampuri()) return;
            
           
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            con.ConnectionString = radieriTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;

            foreach (DataRow r in dataSet6.Radieri)
            {
                if (r.RowState == DataRowState.Deleted) {
                    Console.WriteLine(r["IdRadiere"]);
                    continue; 
                }


                
                string listaSet = "Set DataRadiere =#" +r["DataRadiere"].ToString()+"#";
                cmd.CommandText = "Update Radieri " + listaSet + " Where IdRadiere=" + r["IdRadiere"];
                con.Open();

                cmd.ExecuteNonQuery();

                con.Close();
            }
           

            config(true);
            refresh_grid();
            
            
        }

        private void btnRenuntare_Click(object sender, EventArgs e)
        {
            //A3
            config(true);
            refresh_grid();
        }

        private void A8()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            

            con.ConnectionString = radieriTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;

            if ( dataGridView2.CurrentCell.RowIndex != null)
            {
                cmd.CommandText = "Delete From Radieri Where IdRadiere = " + dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells[0].Value;


                MessageBox.Show(cmd.CommandText);

                con.Open();

                cmd.ExecuteNonQuery();

                con.Close();

                refresh_grid();
            }
            else
            {
                MessageBox.Show("Nu exista radieri de sters!");
            }

        }
        private void btnStergere_Click(object sender, EventArgs e)
        {
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";

            if (dataGridView2.Rows.Count > 0) {
                var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (rezultat == DialogResult.No) return;
                A8();
            }
            else
            {
                MessageBox.Show("Nu exista radieri de sters");

            }
        }
    }

       

    
}
