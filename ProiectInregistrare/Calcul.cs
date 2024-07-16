using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ProiectFinal
{
    class Calcul
    {
        private static OleDbConnection con = new OleDbConnection();
        private static OleDbCommand cmd = new OleDbCommand();

        public static void calculSituatie(string cs)
        {
            con.ConnectionString = cs;
            cmd.Connection = con;
            con.Open();
            //Sterg continut tabele CalculStoc
            cmd.CommandText = "Delete * from CalculImpozit";
            cmd.ExecuteNonQuery();

            situatieInitiala(); inregistrari(); radieri();
            
            situatieFinala();
            con.Close();
        }

        private static void situatieInitiala()
        {
            cmd.CommandText = "Insert into CalculImpozit(IdOperatie, Data, IdProprietar, Valoare, IdTipProprietate, ValoareImpozit) " +
                              "Select 1,Data, IdProprietar, Valoare, SituatieProprietatiInitiala.IdTipProprietate, SituatieProprietatiInitiala.Valoare*TipProprietate.ImpozitAnual " +
                                "FROM (SituatieProprietatiInitiala INNER JOIN TipProprietate " +
                                "ON SituatieProprietatiInitiala.IdTipProprietate = TipProprietate.IdTipProprietate) ";


            try { cmd.ExecuteNonQuery(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private static void inregistrari()
        {
            cmd.CommandText = "Insert into CalculImpozit(IdOperatie, Data, IdProprietar, Valoare, IdTipProprietate, ValoareImpozit) " +
                              "Select 2,DataInregistrare as Data, IdProprietar, Valoare, Inregistrari.IdTipProprietate, Inregistrari.Valoare*TipProprietate.ImpozitAnual " +
                              "FROM (Inregistrari INNER JOIN TipProprietate " +
                              "ON Inregistrari.IdTipProprietate = TipProprietate.IdTipProprietate) ";

            try { cmd.ExecuteNonQuery(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private static void radieri()
        {
            cmd.CommandText = "Insert into CalculImpozit(IdOperatie, Data, IdProprietar, Valoare, IdTipProprietate, ValoareImpozit) " +
                   "Select 3,DataRadiere as Data, IdProprietar, -Valoare, Radieri.IdTipProprietate, -Radieri.Valoare*TipProprietate.ImpozitAnual " +
                    "FROM (Radieri INNER JOIN TipProprietate " +
                      "ON Radieri.IdTipProprietate = TipProprietate.IdTipProprietate) ";

            try { cmd.ExecuteNonQuery(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private static void situatieFinala()
        {

            // Calculez totaluri pe Cantitate si grupez pe IdProdus 

            cmd.CommandText = "INSERT INTO CalculImpozit ( IdOperatie, IdProprietar, Valoare, IdTipProprietate, ValoareImpozit,Data ) " +
                       "SELECT  4,CalculImpozit.IdProprietar, Sum(CalculImpozit.Valoare) AS Valoare, 1, Sum(CalculImpozit.ValoareImpozit),now() " +
                       "FROM CalculImpozit GROUP BY CalculImpozit.IdProprietar";
            cmd.ExecuteNonQuery();
        }

    }
}
