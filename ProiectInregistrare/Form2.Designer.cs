
namespace ProiectFinal
{
    partial class Form2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.situatieProprietatiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new ProiectFinal.DataSet2();
            this.situatieBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.situatieBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.situatieBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.situatieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.situatieTableAdapter = new ProiectFinal.DataSet2TableAdapters.SituatieTableAdapter();
            this.situatieProprietatiTableAdapter = new ProiectFinal.DataSet2TableAdapters.SituatieProprietatiTableAdapter();
            this.balantaProprietatiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.balantaProprietatiTableAdapter = new ProiectFinal.DataSet2TableAdapters.BalantaProprietatiTableAdapter();
            this.idProprietarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situatieFinalaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situatieFinalaImpozitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.situatieProprietatiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.situatieBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.situatieBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.situatieBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.situatieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balantaProprietatiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProprietarDataGridViewTextBoxColumn,
            this.situatieFinalaDataGridViewTextBoxColumn,
            this.situatieFinalaImpozitDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.balantaProprietatiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(447, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.balantaProprietatiBindingSource;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(465, 37);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series2";
            series1.XValueMember = "NumeProprietar";
            series1.YValueMembers = "ValoareProprietati";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // situatieProprietatiBindingSource
            // 
            this.situatieProprietatiBindingSource.DataMember = "SituatieProprietati";
            this.situatieProprietatiBindingSource.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // situatieBindingSource3
            // 
            this.situatieBindingSource3.DataMember = "Situatie";
            this.situatieBindingSource3.DataSource = this.dataSet2;
            // 
            // situatieBindingSource2
            // 
            this.situatieBindingSource2.DataMember = "Situatie";
            this.situatieBindingSource2.DataSource = this.dataSet2;
            // 
            // situatieBindingSource1
            // 
            this.situatieBindingSource1.DataMember = "Situatie";
            this.situatieBindingSource1.DataSource = this.dataSet2;
            // 
            // situatieBindingSource
            // 
            this.situatieBindingSource.DataMember = "Situatie";
            this.situatieBindingSource.DataSource = this.dataSet2;
            // 
            // situatieTableAdapter
            // 
            this.situatieTableAdapter.ClearBeforeFill = true;
            // 
            // situatieProprietatiTableAdapter
            // 
            this.situatieProprietatiTableAdapter.ClearBeforeFill = true;
            // 
            // balantaProprietatiBindingSource
            // 
            this.balantaProprietatiBindingSource.DataMember = "BalantaProprietati";
            this.balantaProprietatiBindingSource.DataSource = this.dataSet2;
            // 
            // balantaProprietatiTableAdapter
            // 
            this.balantaProprietatiTableAdapter.ClearBeforeFill = true;
            // 
            // idProprietarDataGridViewTextBoxColumn
            // 
            this.idProprietarDataGridViewTextBoxColumn.DataPropertyName = "IdProprietar";
            this.idProprietarDataGridViewTextBoxColumn.HeaderText = "IdProprietar";
            this.idProprietarDataGridViewTextBoxColumn.Name = "idProprietarDataGridViewTextBoxColumn";
            this.idProprietarDataGridViewTextBoxColumn.ReadOnly = true;
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.situatieProprietatiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.situatieBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.situatieBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.situatieBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.situatieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balantaProprietatiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource situatieBindingSource;
        private DataSet2TableAdapters.SituatieTableAdapter situatieTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.BindingSource situatieBindingSource1;
        private System.Windows.Forms.BindingSource situatieBindingSource2;
        private System.Windows.Forms.BindingSource situatieBindingSource3;
        private System.Windows.Forms.BindingSource situatieProprietatiBindingSource;
        private DataSet2TableAdapters.SituatieProprietatiTableAdapter situatieProprietatiTableAdapter;
        private System.Windows.Forms.BindingSource balantaProprietatiBindingSource;
        private DataSet2TableAdapters.BalantaProprietatiTableAdapter balantaProprietatiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProprietarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn situatieFinalaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn situatieFinalaImpozitDataGridViewTextBoxColumn;
    }
}