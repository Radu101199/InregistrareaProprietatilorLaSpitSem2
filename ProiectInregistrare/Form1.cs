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
    public partial class Form1 : Form
    {
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void V1_Load(object sender, EventArgs e)
        {
            con.ConnectionString = calculImpozitTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;

            con.Open();
            cmd.CommandText = "Delete * from CalculImpozit";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "Delete * from SituatieProprietati";
            cmd.ExecuteNonQuery();
            
            con.Close();

            this.calculImpozitTableAdapter.Fill(this.dataSet1.CalculImpozit);
            this.situatieProprietatiTableAdapter.Fill(this.dataSet1.SituatieProprietati);
        }

        private void btnStocInitial_Click(object sender, EventArgs e)
        {

            con.Open();

            //Stoc Initial
            cmd.CommandText = "Insert into CalculImpozit(IdOperatie, Data, IdProprietar, Valoare, IdTipProprietate, ValoareImpozit) " +
                              "Select 1,Data, IdProprietar, Valoare, SituatieProprietatiInitiala.IdTipProprietate, SituatieProprietatiInitiala.Valoare*TipProprietate.ImpozitAnual " +
                                "FROM (SituatieProprietatiInitiala INNER JOIN TipProprietate " +
                                "ON SituatieProprietatiInitiala.IdTipProprietate = TipProprietate.IdTipProprietate) ";

            try { cmd.ExecuteNonQuery(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            con.Close();

            //Incarc dataTable-ul CalculStoc
            dataSet1.CalculImpozit.Clear();
            calculImpozitTableAdapter.Fill(this.dataSet1.CalculImpozit);

        }
        private void btnInregistrari_Click(object sender, EventArgs e)
        {
            // Intrari
            con.Open();

            cmd.CommandText = "Insert into CalculImpozit(IdOperatie, Data, IdProprietar, Valoare, IdTipProprietate, ValoareImpozit) " +
                              "Select 2,DataInregistrare as Data, IdProprietar, Valoare, Inregistrari.IdTipProprietate, Inregistrari.Valoare*TipProprietate.ImpozitAnual " +
                              "FROM (Inregistrari INNER JOIN TipProprietate " +
                              "ON Inregistrari.IdTipProprietate = TipProprietate.IdTipProprietate) ";

            try { cmd.ExecuteNonQuery(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            con.Close();

            //Incarc dataTable-ul CalculStoc
            dataSet1.CalculImpozit.Clear();
            calculImpozitTableAdapter.Fill(this.dataSet1.CalculImpozit);

        }

        private void btnRadieri_Click(object sender, EventArgs e)
        {
            //Iesiri
            con.Open();
            cmd.CommandText = "Insert into CalculImpozit(IdOperatie, Data, IdProprietar, Valoare, IdTipProprietate, ValoareImpozit) " +
                   "Select 3,DataRadiere as Data, IdProprietar, -Valoare, Radieri.IdTipProprietate, -Radieri.Valoare*TipProprietate.ImpozitAnual " +
                    "FROM (Radieri INNER JOIN TipProprietate " +
                      "ON Radieri.IdTipProprietate = TipProprietate.IdTipProprietate) ";

            try { cmd.ExecuteNonQuery(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            con.Close();

            //Incarc dataTable-ul CalculStoc
            dataSet1.CalculImpozit.Clear();
            calculImpozitTableAdapter.Fill(this.dataSet1.CalculImpozit);
        }

        private void btnStocFinal_Click(object sender, EventArgs e)
        {
            con.Open();

            // Calculez totaluri pe Cantitate si grupez pe IdProdus 
            // inserez rezultatul in tabela Stoc
            cmd.CommandText = "INSERT INTO SituatieProprietati ( IdProprietar, Valoare, ValoareImpozit ) " +
                              "SELECT  IdProprietar, Sum(CalculImpozit.Valoare) AS Valoare, Sum(CalculImpozit.Valoare * TipProprietate.ImpozitAnual) AS ValoareImpozit " +
                              "FROM (CalculImpozit INNER JOIN TipProprietate " +
                              "ON CalculImpozit.IdTipProprietate = TipProprietate.IdTipProprietate) " +
                              "GROUP BY CalculImpozit.IdProprietar";
            cmd.ExecuteNonQuery();

            //Stoc final 

            cmd.CommandText = "INSERT INTO CalculImpozit ( IdOperatie, IdProprietar, Valoare, IdTipProprietate, ValoareImpozit,Data ) " +
                       "SELECT  4,CalculImpozit.IdProprietar, Sum(CalculImpozit.Valoare) AS Valoare, 1, Sum(CalculImpozit.ValoareImpozit),now() " +
                       "FROM CalculImpozit GROUP BY CalculImpozit.IdProprietar";
            cmd.ExecuteNonQuery();

            con.Close();

            //Incarc dataTable-ul CalculStoc si Stoc
            dataSet1.CalculImpozit.Clear();
            calculImpozitTableAdapter.Fill(this.dataSet1.CalculImpozit);

            dataSet1.SituatieProprietati.Clear();
            situatieProprietatiTableAdapter.Fill(this.dataSet1.SituatieProprietati);

           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.SituatieProprietati' table. You can move, or remove it, as needed.
            this.situatieProprietatiTableAdapter.Fill(this.dataSet1.SituatieProprietati);
            // TODO: This line of code loads data into the 'dataSet1.CalculImpozit' table. You can move, or remove it, as needed.
            this.calculImpozitTableAdapter.Fill(this.dataSet1.CalculImpozit);

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.calculImpozitTableAdapter.FillBy1(this.dataSet1.CalculImpozit);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
