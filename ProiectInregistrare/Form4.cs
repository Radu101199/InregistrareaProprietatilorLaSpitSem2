using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace ProiectFinal
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            DateTime d1 = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day);
            DateTime d2 = new DateTime(dateTimePicker2.Value.Year, dateTimePicker2.Value.Month, dateTimePicker2.Value.Day);

            // TODO: This line of code loads data into the 'DataSet4.Inregistrari' table. You can move, or remove it, as needed.
            this.InregistrariTableAdapter.Fill(this.DataSet4.Inregistrari, d1, d2);


            ReportParameter[] parameters = new ReportParameter[1];
            parameters[0] = new ReportParameter("Titlu", "Lista inregistrarilor din perioada " +
                d1.ToShortDateString() + "-" + d2.ToShortDateString());


            this.reportViewer2.LocalReport.SetParameters(parameters);
            this.reportViewer2.RefreshReport();

        }
    }
}
