
namespace ProiectFinal
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dtnSituatieInitiala = new System.Windows.Forms.Button();
            this.btnInregistrari = new System.Windows.Forms.Button();
            this.btnRadieri = new System.Windows.Forms.Button();
            this.btnSituatieFinala = new System.Windows.Forms.Button();
            this.fillBy1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillBy1ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.IdProprietar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipProprietate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DenumireTipProprietate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImpozitAnual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situatieProprietatiBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new ProiectFinal.DataSet1();
            this.idOperatieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valoareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calculImpozitBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.calculImpozitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.situatieProprietatiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.situatieProprietatiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calculImpozitTableAdapter = new ProiectFinal.DataSet1TableAdapters.CalculImpozitTableAdapter();
            this.situatieProprietatiTableAdapter = new ProiectFinal.DataSet1TableAdapters.SituatieProprietatiTableAdapter();
            this.situatieProprietatiBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeProprietar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valoareDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValoareImpozit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.fillBy1ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.situatieProprietatiBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculImpozitBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculImpozitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.situatieProprietatiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.situatieProprietatiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.situatieProprietatiBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operatii Proprietati";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(583, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Situatie Proprietati";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOperatieDataGridViewTextBoxColumn,
            this.IdProprietar,
            this.IdTipProprietate,
            this.CNP,
            this.dataDataGridViewTextBoxColumn,
            this.DenumireTipProprietate,
            this.valoareDataGridViewTextBoxColumn,
            this.ImpozitAnual,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView1.DataSource = this.calculImpozitBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(461, 177);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.NumeProprietar,
            this.valoareDataGridViewTextBoxColumn1,
            this.ValoareImpozit});
            this.dataGridView2.DataSource = this.situatieProprietatiBindingSource3;
            this.dataGridView2.Location = new System.Drawing.Point(568, 107);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(350, 150);
            this.dataGridView2.TabIndex = 3;
            // 
            // dtnSituatieInitiala
            // 
            this.dtnSituatieInitiala.Location = new System.Drawing.Point(479, 126);
            this.dtnSituatieInitiala.Name = "dtnSituatieInitiala";
            this.dtnSituatieInitiala.Size = new System.Drawing.Size(75, 38);
            this.dtnSituatieInitiala.TabIndex = 4;
            this.dtnSituatieInitiala.Text = "Situatie Initiala";
            this.dtnSituatieInitiala.UseVisualStyleBackColor = true;
            this.dtnSituatieInitiala.Click += new System.EventHandler(this.btnStocInitial_Click);
            // 
            // btnInregistrari
            // 
            this.btnInregistrari.Location = new System.Drawing.Point(479, 170);
            this.btnInregistrari.Name = "btnInregistrari";
            this.btnInregistrari.Size = new System.Drawing.Size(75, 23);
            this.btnInregistrari.TabIndex = 5;
            this.btnInregistrari.Text = "Inregistrari";
            this.btnInregistrari.UseVisualStyleBackColor = true;
            this.btnInregistrari.Click += new System.EventHandler(this.btnInregistrari_Click);
            // 
            // btnRadieri
            // 
            this.btnRadieri.Location = new System.Drawing.Point(479, 199);
            this.btnRadieri.Name = "btnRadieri";
            this.btnRadieri.Size = new System.Drawing.Size(75, 23);
            this.btnRadieri.TabIndex = 6;
            this.btnRadieri.Text = "Radieri";
            this.btnRadieri.UseVisualStyleBackColor = true;
            this.btnRadieri.Click += new System.EventHandler(this.btnRadieri_Click);
            // 
            // btnSituatieFinala
            // 
            this.btnSituatieFinala.Location = new System.Drawing.Point(479, 228);
            this.btnSituatieFinala.Name = "btnSituatieFinala";
            this.btnSituatieFinala.Size = new System.Drawing.Size(75, 38);
            this.btnSituatieFinala.TabIndex = 7;
            this.btnSituatieFinala.Text = "Situatie Finala";
            this.btnSituatieFinala.UseVisualStyleBackColor = true;
            this.btnSituatieFinala.Click += new System.EventHandler(this.btnStocFinal_Click);
            // 
            // fillBy1ToolStrip
            // 
            this.fillBy1ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillBy1ToolStripButton});
            this.fillBy1ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBy1ToolStrip.Name = "fillBy1ToolStrip";
            this.fillBy1ToolStrip.Size = new System.Drawing.Size(1028, 25);
            this.fillBy1ToolStrip.TabIndex = 8;
            this.fillBy1ToolStrip.Text = "fillBy1ToolStrip";
            // 
            // fillBy1ToolStripButton
            // 
            this.fillBy1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy1ToolStripButton.Name = "fillBy1ToolStripButton";
            this.fillBy1ToolStripButton.Size = new System.Drawing.Size(45, 22);
            this.fillBy1ToolStripButton.Text = "FillBy1";
            this.fillBy1ToolStripButton.Click += new System.EventHandler(this.fillBy1ToolStripButton_Click);
            // 
            // IdProprietar
            // 
            this.IdProprietar.DataPropertyName = "IdProprietar";
            this.IdProprietar.HeaderText = "IdProprietar";
            this.IdProprietar.Name = "IdProprietar";
            this.IdProprietar.ReadOnly = true;
            this.IdProprietar.Visible = false;
            // 
            // IdTipProprietate
            // 
            this.IdTipProprietate.DataPropertyName = "IdTipProprietate";
            this.IdTipProprietate.HeaderText = "IdTipProprietate";
            this.IdTipProprietate.Name = "IdTipProprietate";
            this.IdTipProprietate.ReadOnly = true;
            this.IdTipProprietate.Visible = false;
            // 
            // CNP
            // 
            this.CNP.DataPropertyName = "CNP";
            this.CNP.HeaderText = "CNP";
            this.CNP.Name = "CNP";
            this.CNP.ReadOnly = true;
            // 
            // DenumireTipProprietate
            // 
            this.DenumireTipProprietate.DataPropertyName = "DenumireTipProprietate";
            this.DenumireTipProprietate.HeaderText = "DenumireTipProprietate";
            this.DenumireTipProprietate.Name = "DenumireTipProprietate";
            this.DenumireTipProprietate.ReadOnly = true;
            this.DenumireTipProprietate.Visible = false;
            // 
            // ImpozitAnual
            // 
            this.ImpozitAnual.DataPropertyName = "ImpozitAnual";
            this.ImpozitAnual.HeaderText = "ImpozitAnual";
            this.ImpozitAnual.Name = "ImpozitAnual";
            this.ImpozitAnual.ReadOnly = true;
            this.ImpozitAnual.Visible = false;
            // 
            // situatieProprietatiBindingSource2
            // 
            this.situatieProprietatiBindingSource2.DataMember = "SituatieProprietati";
            this.situatieProprietatiBindingSource2.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idOperatieDataGridViewTextBoxColumn
            // 
            this.idOperatieDataGridViewTextBoxColumn.DataPropertyName = "IdOperatie";
            this.idOperatieDataGridViewTextBoxColumn.HeaderText = "IdOperatie";
            this.idOperatieDataGridViewTextBoxColumn.Name = "idOperatieDataGridViewTextBoxColumn";
            this.idOperatieDataGridViewTextBoxColumn.ReadOnly = true;
            this.idOperatieDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valoareDataGridViewTextBoxColumn
            // 
            this.valoareDataGridViewTextBoxColumn.DataPropertyName = "Valoare";
            this.valoareDataGridViewTextBoxColumn.HeaderText = "Valoare";
            this.valoareDataGridViewTextBoxColumn.Name = "valoareDataGridViewTextBoxColumn";
            this.valoareDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ValoareImpozit";
            this.dataGridViewTextBoxColumn2.HeaderText = "ValoareImpozit";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // calculImpozitBindingSource1
            // 
            this.calculImpozitBindingSource1.DataMember = "CalculImpozit";
            this.calculImpozitBindingSource1.DataSource = this.dataSet1;
            // 
            // calculImpozitBindingSource
            // 
            this.calculImpozitBindingSource.DataMember = "CalculImpozit";
            this.calculImpozitBindingSource.DataSource = this.dataSet1;
            // 
            // situatieProprietatiBindingSource1
            // 
            this.situatieProprietatiBindingSource1.DataMember = "SituatieProprietati";
            this.situatieProprietatiBindingSource1.DataSource = this.dataSet1;
            // 
            // situatieProprietatiBindingSource
            // 
            this.situatieProprietatiBindingSource.DataMember = "SituatieProprietati";
            this.situatieProprietatiBindingSource.DataSource = this.dataSet1;
            // 
            // calculImpozitTableAdapter
            // 
            this.calculImpozitTableAdapter.ClearBeforeFill = true;
            // 
            // situatieProprietatiTableAdapter
            // 
            this.situatieProprietatiTableAdapter.ClearBeforeFill = true;
            // 
            // situatieProprietatiBindingSource3
            // 
            this.situatieProprietatiBindingSource3.DataMember = "SituatieProprietati";
            this.situatieProprietatiBindingSource3.DataSource = this.dataSet1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdProprietar";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdProprietar";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CNP";
            this.dataGridViewTextBoxColumn3.HeaderText = "CNP";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // NumeProprietar
            // 
            this.NumeProprietar.DataPropertyName = "NumeProprietar";
            this.NumeProprietar.HeaderText = "NumeProprietar";
            this.NumeProprietar.Name = "NumeProprietar";
            this.NumeProprietar.ReadOnly = true;
            this.NumeProprietar.Visible = false;
            // 
            // valoareDataGridViewTextBoxColumn1
            // 
            this.valoareDataGridViewTextBoxColumn1.DataPropertyName = "Valoare";
            this.valoareDataGridViewTextBoxColumn1.HeaderText = "Valoare";
            this.valoareDataGridViewTextBoxColumn1.Name = "valoareDataGridViewTextBoxColumn1";
            this.valoareDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ValoareImpozit
            // 
            this.ValoareImpozit.DataPropertyName = "ValoareImpozit";
            this.ValoareImpozit.HeaderText = "ValoareImpozit";
            this.ValoareImpozit.Name = "ValoareImpozit";
            this.ValoareImpozit.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1028, 467);
            this.Controls.Add(this.fillBy1ToolStrip);
            this.Controls.Add(this.btnSituatieFinala);
            this.Controls.Add(this.btnRadieri);
            this.Controls.Add(this.btnInregistrari);
            this.Controls.Add(this.dtnSituatieInitiala);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.V1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.fillBy1ToolStrip.ResumeLayout(false);
            this.fillBy1ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.situatieProprietatiBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculImpozitBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculImpozitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.situatieProprietatiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.situatieProprietatiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.situatieProprietatiBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource calculImpozitBindingSource;
        private DataSet1TableAdapters.CalculImpozitTableAdapter calculImpozitTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipProprietateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource situatieProprietatiBindingSource;
        private DataSet1TableAdapters.SituatieProprietatiTableAdapter situatieProprietatiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipProprietateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireTipProprietateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn impozitAnualDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button dtnSituatieInitiala;
        private System.Windows.Forms.Button btnInregistrari;
        private System.Windows.Forms.Button btnRadieri;
        private System.Windows.Forms.Button btnSituatieFinala;
        private System.Windows.Forms.ToolStrip fillBy1ToolStrip;
        private System.Windows.Forms.ToolStripButton fillBy1ToolStripButton;
        private System.Windows.Forms.BindingSource situatieProprietatiBindingSource1;
        private System.Windows.Forms.BindingSource situatieProprietatiBindingSource2;
        private System.Windows.Forms.BindingSource calculImpozitBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOperatieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProprietar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipProprietate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DenumireTipProprietate;
        private System.Windows.Forms.DataGridViewTextBoxColumn valoareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImpozitAnual;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource situatieProprietatiBindingSource3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeProprietar;
        private System.Windows.Forms.DataGridViewTextBoxColumn valoareDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValoareImpozit;
    }
}

