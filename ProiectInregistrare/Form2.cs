using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectFinal
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.BalantaProprietati' table. You can move, or remove it, as needed.
            this.balantaProprietatiTableAdapter.Fill(this.dataSet2.BalantaProprietati);
            // TODO: This line of code loads data into the 'dataSet2.SituatieProprietati' table. You can move, or remove it, as needed.
            this.situatieProprietatiTableAdapter.Fill(this.dataSet2.SituatieProprietati);
            // TODO: This line of code loads data into the 'dataSet2.Situatie' table. You can move, or remove it, as needed.
            this.situatieTableAdapter.Fill(this.dataSet2.Situatie);
            // TODO: This line of code loads data into the 'dataSet2.Situatie' table. You can move, or remove it, as needed.
            this.situatieTableAdapter.Fill(this.dataSet2.Situatie);
            // TODO: This line of code loads data into the 'dataSet2.SituatieProprietati' table. You can move, or remove it, as needed.
            this.situatieTableAdapter.Fill(this.dataSet2.Situatie);

        }
    }
}
