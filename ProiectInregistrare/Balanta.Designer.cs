
namespace ProiectFinal
{
    partial class Balanta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.balantaProprietatiBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet9 = new ProiectFinal.DataSet9();
            this.calculSituatieBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.balantaProprietatiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.calculSituatieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.balantaProprietatiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calculSituatieTableAdapter = new ProiectFinal.DataSet9TableAdapters.CalculSituatieTableAdapter();
            this.balantaProprietatiTableAdapter = new ProiectFinal.DataSet9TableAdapters.BalantaProprietatiTableAdapter();
            this.balantaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.balantaTableAdapter = new ProiectFinal.DataSet9TableAdapters.BalantaTableAdapter();
            this.balantaProprietatiBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cNPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeProprietarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProprietarDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situatieInitialaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inregistrariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radieriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situatieFinalaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situatieFinalaImpozitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOperatieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProprietarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valoareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valoareImpozitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGrafic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balantaProprietatiBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculSituatieBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balantaProprietatiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculSituatieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balantaProprietatiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balantaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balantaProprietatiBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOperatieDataGridViewTextBoxColumn,
            this.CNP,
            this.dataDataGridViewTextBoxColumn,
            this.idProprietarDataGridViewTextBoxColumn,
            this.valoareDataGridViewTextBoxColumn,
            this.valoareImpozitDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.calculSituatieBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(446, 231);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNPDataGridViewTextBoxColumn,
            this.numeProprietarDataGridViewTextBoxColumn,
            this.idProprietarDataGridViewTextBoxColumn1,
            this.situatieInitialaDataGridViewTextBoxColumn,
            this.inregistrariDataGridViewTextBoxColumn,
            this.radieriDataGridViewTextBoxColumn,
            this.situatieFinalaDataGridViewTextBoxColumn,
            this.situatieFinalaImpozitDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.balantaProprietatiBindingSource3;
            this.dataGridView2.Location = new System.Drawing.Point(483, 117);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(506, 155);
            this.dataGridView2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(483, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Situatie Finala";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSituatieFinala_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(577, 306);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 42);
            this.button2.TabIndex = 3;
            this.button2.Text = "Situatie Initiala";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnStocInitial_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(658, 316);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Inregistrari";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnIntrari_Click);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(739, 316);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Radieri";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnRadieri_Click);
            // 
            // chart1
            // 
            chartArea7.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea7);
            this.chart1.DataSource = this.balantaProprietatiBindingSource3;
            legend7.Name = "Legend1";
            this.chart1.Legends.Add(legend7);
            this.chart1.Location = new System.Drawing.Point(179, 414);
            this.chart1.Name = "chart1";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Valoare Proprietati";
            series7.XValueMember = "NumeProprietar";
            series7.YValueMembers = "SituatieFinala";
            this.chart1.Series.Add(series7);
            this.chart1.Size = new System.Drawing.Size(300, 200);
            this.chart1.TabIndex = 6;
            this.chart1.Text = " ";
            this.chart1.Visible = false;
            // 
            // balantaProprietatiBindingSource2
            // 
            this.balantaProprietatiBindingSource2.DataMember = "BalantaProprietati";
            this.balantaProprietatiBindingSource2.DataSource = this.dataSet9;
            // 
            // dataSet9
            // 
            this.dataSet9.DataSetName = "DataSet9";
            this.dataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // calculSituatieBindingSource1
            // 
            this.calculSituatieBindingSource1.DataMember = "CalculSituatie";
            this.calculSituatieBindingSource1.DataSource = this.dataSet9;
            // 
            // balantaProprietatiBindingSource1
            // 
            this.balantaProprietatiBindingSource1.DataMember = "BalantaProprietati";
            this.balantaProprietatiBindingSource1.DataSource = this.dataSet9;
            // 
            // calculSituatieBindingSource
            // 
            this.calculSituatieBindingSource.DataMember = "CalculSituatie";
            this.calculSituatieBindingSource.DataSource = this.dataSet9;
            // 
            // balantaProprietatiBindingSource
            // 
            this.balantaProprietatiBindingSource.DataMember = "BalantaProprietati";
            this.balantaProprietatiBindingSource.DataSource = this.dataSet9;
            // 
            // calculSituatieTableAdapter
            // 
            this.calculSituatieTableAdapter.ClearBeforeFill = true;
            // 
            // balantaProprietatiTableAdapter
            // 
            this.balantaProprietatiTableAdapter.ClearBeforeFill = true;
            // 
            // balantaBindingSource
            // 
            this.balantaBindingSource.DataMember = "Balanta";
            this.balantaBindingSource.DataSource = this.dataSet9;
            // 
            // balantaTableAdapter
            // 
            this.balantaTableAdapter.ClearBeforeFill = true;
            // 
            // balantaProprietatiBindingSource3
            // 
            this.balantaProprietatiBindingSource3.DataMember = "BalantaProprietati";
            this.balantaProprietatiBindingSource3.DataSource = this.dataSet9;
            // 
            // chart2
            // 
            chartArea8.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea8);
            this.chart2.DataSource = this.balantaProprietatiBindingSource3;
            legend8.Name = "Legend1";
            this.chart2.Legends.Add(legend8);
            this.chart2.Location = new System.Drawing.Point(557, 414);
            this.chart2.Name = "chart2";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Valoare Impozit";
            series8.XValueMember = "NumeProprietar";
            series8.YValueMembers = "SituatieFinalaImpozit";
            this.chart2.Series.Add(series8);
            this.chart2.Size = new System.Drawing.Size(300, 200);
            this.chart2.TabIndex = 7;
            this.chart2.Text = " ";
            this.chart2.Visible = false;
            // 
            // cNPDataGridViewTextBoxColumn
            // 
            this.cNPDataGridViewTextBoxColumn.DataPropertyName = "CNP";
            this.cNPDataGridViewTextBoxColumn.HeaderText = "CNP";
            this.cNPDataGridViewTextBoxColumn.Name = "cNPDataGridViewTextBoxColumn";
            this.cNPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeProprietarDataGridViewTextBoxColumn
            // 
            this.numeProprietarDataGridViewTextBoxColumn.DataPropertyName = "NumeProprietar";
            this.numeProprietarDataGridViewTextBoxColumn.HeaderText = "NumeProprietar";
            this.numeProprietarDataGridViewTextBoxColumn.Name = "numeProprietarDataGridViewTextBoxColumn";
            this.numeProprietarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idProprietarDataGridViewTextBoxColumn1
            // 
            this.idProprietarDataGridViewTextBoxColumn1.DataPropertyName = "IdProprietar";
            this.idProprietarDataGridViewTextBoxColumn1.HeaderText = "IdProprietar";
            this.idProprietarDataGridViewTextBoxColumn1.Name = "idProprietarDataGridViewTextBoxColumn1";
            this.idProprietarDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idProprietarDataGridViewTextBoxColumn1.Visible = false;
            // 
            // situatieInitialaDataGridViewTextBoxColumn
            // 
            this.situatieInitialaDataGridViewTextBoxColumn.DataPropertyName = "SituatieInitiala";
            this.situatieInitialaDataGridViewTextBoxColumn.HeaderText = "SituatieInitiala";
            this.situatieInitialaDataGridViewTextBoxColumn.Name = "situatieInitialaDataGridViewTextBoxColumn";
            this.situatieInitialaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inregistrariDataGridViewTextBoxColumn
            // 
            this.inregistrariDataGridViewTextBoxColumn.DataPropertyName = "Inregistrari";
            this.inregistrariDataGridViewTextBoxColumn.HeaderText = "Inregistrari";
            this.inregistrariDataGridViewTextBoxColumn.Name = "inregistrariDataGridViewTextBoxColumn";
            this.inregistrariDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // radieriDataGridViewTextBoxColumn
            // 
            this.radieriDataGridViewTextBoxColumn.DataPropertyName = "Radieri";
            this.radieriDataGridViewTextBoxColumn.HeaderText = "Radieri";
            this.radieriDataGridViewTextBoxColumn.Name = "radieriDataGridViewTextBoxColumn";
            this.radieriDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // situatieFinalaDataGridViewTextBoxColumn
            // 
            this.situatieFinalaDataGridViewTextBoxColumn.DataPropertyName = "SituatieFinala";
            this.situatieFinalaDataGridViewTextBoxColumn.HeaderText = "SituatieFinala";
            this.situatieFinalaDataGridViewTextBoxColumn.Name = "situatieFinalaDataGridViewTextBoxColumn";
            this.situatieFinalaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // situatieFinalaImpozitDataGridViewTextBoxColumn
            // 
            this.situatieFinalaImpozitDataGridViewTextBoxColumn.DataPropertyName = "SituatieFinalaImpozit";
            this.situatieFinalaImpozitDataGridViewTextBoxColumn.HeaderText = "SituatieFinalaImpozit";
            this.situatieFinalaImpozitDataGridViewTextBoxColumn.Name = "situatieFinalaImpozitDataGridViewTextBoxColumn";
            this.situatieFinalaImpozitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idOperatieDataGridViewTextBoxColumn
            // 
            this.idOperatieDataGridViewTextBoxColumn.DataPropertyName = "IdOperatie";
            this.idOperatieDataGridViewTextBoxColumn.HeaderText = "IdOperatie";
            this.idOperatieDataGridViewTextBoxColumn.Name = "idOperatieDataGridViewTextBoxColumn";
            this.idOperatieDataGridViewTextBoxColumn.ReadOnly = true;
            this.idOperatieDataGridViewTextBoxColumn.Visible = false;
            // 
            // CNP
            // 
            this.CNP.DataPropertyName = "CNP";
            this.CNP.HeaderText = "CNP";
            this.CNP.Name = "CNP";
            this.CNP.ReadOnly = true;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idProprietarDataGridViewTextBoxColumn
            // 
            this.idProprietarDataGridViewTextBoxColumn.DataPropertyName = "IdProprietar";
            this.idProprietarDataGridViewTextBoxColumn.HeaderText = "IdProprietar";
            this.idProprietarDataGridViewTextBoxColumn.Name = "idProprietarDataGridViewTextBoxColumn";
            this.idProprietarDataGridViewTextBoxColumn.ReadOnly = true;
            this.idProprietarDataGridViewTextBoxColumn.Visible = false;
            // 
            // valoareDataGridViewTextBoxColumn
            // 
            this.valoareDataGridViewTextBoxColumn.DataPropertyName = "Valoare";
            this.valoareDataGridViewTextBoxColumn.HeaderText = "Valoare";
            this.valoareDataGridViewTextBoxColumn.Name = "valoareDataGridViewTextBoxColumn";
            this.valoareDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valoareImpozitDataGridViewTextBoxColumn
            // 
            this.valoareImpozitDataGridViewTextBoxColumn.DataPropertyName = "ValoareImpozit";
            this.valoareImpozitDataGridViewTextBoxColumn.HeaderText = "ValoareImpozit";
            this.valoareImpozitDataGridViewTextBoxColumn.Name = "valoareImpozitDataGridViewTextBoxColumn";
            this.valoareImpozitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btnGrafic
            // 
            this.btnGrafic.Enabled = false;
            this.btnGrafic.Location = new System.Drawing.Point(483, 371);
            this.btnGrafic.Name = "btnGrafic";
            this.btnGrafic.Size = new System.Drawing.Size(75, 23);
            this.btnGrafic.TabIndex = 8;
            this.btnGrafic.Text = "Grafic";
            this.btnGrafic.UseVisualStyleBackColor = true;
            this.btnGrafic.Click += new System.EventHandler(this.btnGrafic_Click);
            // 
            // Balanta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 749);
            this.Controls.Add(this.btnGrafic);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Balanta";
            this.Text = "Balanta";
            this.Load += new System.EventHandler(this.Balanta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balantaProprietatiBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculSituatieBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balantaProprietatiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculSituatieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balantaProprietatiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balantaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balantaProprietatiBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet9 dataSet9;
        private System.Windows.Forms.BindingSource calculSituatieBindingSource;
        private DataSet9TableAdapters.CalculSituatieTableAdapter calculSituatieTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource balantaProprietatiBindingSource;
        private DataSet9TableAdapters.BalantaProprietatiTableAdapter balantaProprietatiTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource balantaProprietatiBindingSource1;
        private System.Windows.Forms.BindingSource calculSituatieBindingSource1;
        private System.Windows.Forms.BindingSource balantaBindingSource;
        private DataSet9TableAdapters.BalantaTableAdapter balantaTableAdapter;
        private System.Windows.Forms.BindingSource balantaProprietatiBindingSource2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.BindingSource balantaProprietatiBindingSource3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeProprietarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProprietarDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn situatieInitialaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inregistrariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn radieriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn situatieFinalaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn situatieFinalaImpozitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOperatieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProprietarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valoareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valoareImpozitDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnGrafic;
    }
}