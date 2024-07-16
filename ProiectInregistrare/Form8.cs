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
    public partial class Form8 : Form
    {
        const int DenumireTipProprietate = 0;
        const int ImpozitAnual = 1;

        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet81.TipProprietate' table. You can move, or remove it, as needed.
            this.tipProprietateTableAdapter.Fill(this.dataSet8.TipProprietate);
            this.tipProprietateTableAdapter.Fill(this.dataSet8.TipProprietate);
            config(true);
            refresh();

        }
        private void config(bool v)
        {
            dataGridView1.AllowUserToAddRows = !v;
            dataGridView1.AllowUserToDeleteRows = !v;

            dataGridView1.Columns[DenumireTipProprietate].ReadOnly = v;
            dataGridView1.Columns[ImpozitAnual].ReadOnly = v;

            btnActualizare.Enabled = v;
            btnSalvare.Visible = !v;
            btnRenuntare.Visible = !v;
            btnStergere.Visible = false;
        }

        private void refresh()
        {
            this.tipProprietateTableAdapter.Fill(this.dataSet8.TipProprietate);
        }

        private bool completareCampuri()
        {
            bool raspuns = true;
            foreach (DataRow r in this.dataSet8.TipProprietate)
            {
                if (r.RowState == DataRowState.Deleted) continue;

                if (r["DenumireTipProprietate"] == DBNull.Value)
                {
                    MessageBox.Show("Denumirea nu poate fi goala!");
                    raspuns = false;
                    return raspuns;
                }

                if (r["ImpozitAnual"] == DBNull.Value)
                {
                    MessageBox.Show("Impozitul Anual nu poate fi gol!");
                    raspuns = false;
                    return raspuns;
                }
            }
            return raspuns;
        }

        private bool cheieDenumire()
        {
            bool raspuns = true;
            var list = new List<String>();
            foreach (DataRow r in this.dataSet8.TipProprietate)
            {
                if (r.RowState == DataRowState.Deleted) continue;

                if (r["DenumireTipProprietate"] != DBNull.Value)
                {
                    list.Add(r["DenumireTipProprietate"].ToString());
                }
            }
            if (list.Count != list.Distinct().Count())
            {
                MessageBox.Show("Nu pot exista 2 tipuri de proprietati cu aceeasi denumire!");
                raspuns = false;
            }
            return raspuns;
        }

        private void btnActualizare_Click(object sender, EventArgs e)
        {
            config(false);
        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            if (!completareCampuri())
            {
                return;
            }
            if (!cheieDenumire())
            {
                return;
            }
            try
            {
                tipProprietateTableAdapter.Update(dataSet8.TipProprietate);
                config(true);
                refresh();
            }
            catch (Exception ex)
            {
                string s = ex.Message;

                MessageBox.Show(s);

            }
        }

        private void btnRenuntare_Click(object sender, EventArgs e)
        {
            //A3
            config(true);
            refresh();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (btnRenuntare.Focused)
            {
                dataGridView1.CancelEdit();
                //A3
                config(true);
                refresh();
                return;
            }
            MessageBox.Show("Format eronat");
        }


        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            con.ConnectionString = tipProprietateTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            DataGridViewRow randSelectat = dataGridView1.Rows[e.Row.Index];
            int idTipProprietate = Convert.ToInt32(randSelectat.Cells["IdTipProprietate"].Value);

            if (!existaId(idTipProprietate))
            {
                MessageBox.Show("Nu poate fi sters tipul acesta de proprietate pentru ca exista impozite cu proprietati de acest tip.");
                e.Cancel = true;
                return;
            }
            const string mesaj = "Stergeti proprietatea?";
            const string titlu = "Stergere";
            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
            cmd.CommandText = "delete from TipProprietate where IdTipProprietate=" + idTipProprietate;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private bool existaId(int idTipProprietate)
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader r;
            con.ConnectionString = tipProprietateTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            cmd.CommandText = "select IdTipProprietate from ImpoziteContinut where IdTipProprietate=" + idTipProprietate;
            con.Open();
            r = cmd.ExecuteReader();
            if (r.Read())
            {
                con.Close();
                return false;
            }
            con.Close();
            return true;
        }


    }
}
