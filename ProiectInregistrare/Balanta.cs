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
    public partial class Balanta : Form
    {
        private static OleDbConnection con = new OleDbConnection();
        private static OleDbCommand cmd = new OleDbCommand();

        public Balanta()
        {
            InitializeComponent();
        }

        private void Balanta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet9.Balanta' table. You can move, or remove it, as needed.
            this.balantaTableAdapter.Fill(this.dataSet9.Balanta);
            con.ConnectionString = balantaProprietatiTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;

            con.Open();

            //Sterg continut tabela BalantaStoc
            cmd.CommandText = "Delete * from BalantaProprietati";
            cmd.ExecuteNonQuery();
            con.Close();
            
            Calcul.calculSituatie(balantaProprietatiTableAdapter.Connection.ConnectionString);
            this.calculSituatieTableAdapter.Fill(this.dataSet9.CalculSituatie);
            
        }

        private void btnSituatieFinala_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd.CommandText = "INSERT INTO BalantaProprietati ( IdProprietar, SituatieFinala, SituatieFinalaImpozit )" +
                            " SELECT IdProprietar, Valoare, ValoareImpozit FROM CalculImpozit Where IdOperatie=4";
            cmd.ExecuteNonQuery();
            con.Close();
            //Afisez balanta
            balantaProprietatiTableAdapter.Fill(dataSet9.BalantaProprietati);
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            btnGrafic.Enabled = true;

        }

        private void btnStocInitial_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd.CommandText = "UPDATE BalantaProprietati LEFT JOIN SituatieProprietatiInitiala ON BalantaProprietati.IdProprietar = SituatieProprietatiInitiala.IdProprietar " +
                              "SET BalantaProprietati.SituatieInitiala = IIf(SituatieProprietatiInitiala.Valoare IS NULL OR SituatieProprietatiInitiala.Valoare = 0, 0, SituatieProprietatiInitiala.Valoare)";
            cmd.ExecuteNonQuery();
            con.Close();
            //Afisez balanta
            balantaProprietatiTableAdapter.Fill(dataSet9.BalantaProprietati);
            button2.Enabled = false;
        }

        private void btnIntrari_Click(object sender, EventArgs e)
        {
            DataSet9TableAdapters.InregistrariTableAdapter ta = new DataSet9TableAdapters.InregistrariTableAdapter();
            ta.Fill(dataSet9.Inregistrari);

            DataRelation balInregistrari = dataSet9.Relations.Add(dataSet9.BalantaProprietati.Columns["IdProprietar"], dataSet9.Inregistrari.Columns["IdProprietar"]);

            foreach (DataRow rb in dataSet9.BalantaProprietati)
            {
                foreach (DataRow ri in rb.GetChildRows(balInregistrari))
                {
                    
                     rb["Inregistrari"] = ri["Total"];
                    
                }
                if (rb["Inregistrari"].ToString() == "")
                {
                    rb["Inregistrari"] = 0;
                }
            }
            button3.Enabled = false;
        }

        private void btnRadieri_Click(object sender, EventArgs e)
        {
            DataSet9TableAdapters.RadieriTableAdapter ta = new DataSet9TableAdapters.RadieriTableAdapter();
            ta.Fill(dataSet9.Radieri);

            DataRelation balRadieri = dataSet9.Relations.Add(dataSet9.BalantaProprietati.Columns["IdProprietar"], dataSet9.Radieri.Columns["IdProprietar"]);

            foreach (DataRow rb in dataSet9.BalantaProprietati)
            {
                foreach (DataRow ri in rb.GetChildRows(balRadieri))
                {
                    
                    rb["Radieri"] = ri["Total"];
                
                }
                if(rb["Radieri"].ToString() == "")
                {
                    rb["Radieri"] = 0;
                }
            }
            button4.Enabled = false;
        }

        private void btnGrafic_Click(object sender, EventArgs e)
        {
            chart1.Visible = true;
            chart2.Visible = true;
            chart1.DataBind();
            chart2.DataBind();
        }
    }


}
