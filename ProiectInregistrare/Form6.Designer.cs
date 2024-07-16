
namespace ProiectFinal
{
    partial class Form6
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idInregistrareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInregistrareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProprietarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTipProprietateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valoareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denumireTipProprietateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inregistrariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet6 = new ProiectFinal.DataSet6();
            this.inregistrariTableAdapter = new ProiectFinal.DataSet6TableAdapters.InregistrariTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.radieriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radieriTableAdapter = new ProiectFinal.DataSet6TableAdapters.RadieriTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.btnActualizare = new System.Windows.Forms.Button();
            this.btnRenuntare = new System.Windows.Forms.Button();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            this.idRadiereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataRadiereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProprietarDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTipProprietateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valoareDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idInregistrareDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denumireTipProprietateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inregistrariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radieriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idInregistrareDataGridViewTextBoxColumn,
            this.dataInregistrareDataGridViewTextBoxColumn,
            this.idProprietarDataGridViewTextBoxColumn,
            this.idTipProprietateDataGridViewTextBoxColumn,
            this.valoareDataGridViewTextBoxColumn,
            this.denumireTipProprietateDataGridViewTextBoxColumn,
            this.cNPDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.inregistrariBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(445, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // idInregistrareDataGridViewTextBoxColumn
            // 
            this.idInregistrareDataGridViewTextBoxColumn.DataPropertyName = "IdInregistrare";
            this.idInregistrareDataGridViewTextBoxColumn.HeaderText = "IdInregistrare";
            this.idInregistrareDataGridViewTextBoxColumn.Name = "idInregistrareDataGridViewTextBoxColumn";
            this.idInregistrareDataGridViewTextBoxColumn.ReadOnly = true;
            this.idInregistrareDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataInregistrareDataGridViewTextBoxColumn
            // 
            this.dataInregistrareDataGridViewTextBoxColumn.DataPropertyName = "DataInregistrare";
            this.dataInregistrareDataGridViewTextBoxColumn.HeaderText = "DataInregistrare";
            this.dataInregistrareDataGridViewTextBoxColumn.Name = "dataInregistrareDataGridViewTextBoxColumn";
            this.dataInregistrareDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idProprietarDataGridViewTextBoxColumn
            // 
            this.idProprietarDataGridViewTextBoxColumn.DataPropertyName = "IdProprietar";
            this.idProprietarDataGridViewTextBoxColumn.HeaderText = "IdProprietar";
            this.idProprietarDataGridViewTextBoxColumn.Name = "idProprietarDataGridViewTextBoxColumn";
            this.idProprietarDataGridViewTextBoxColumn.ReadOnly = true;
            this.idProprietarDataGridViewTextBoxColumn.Visible = false;
            // 
            // idTipProprietateDataGridViewTextBoxColumn
            // 
            this.idTipProprietateDataGridViewTextBoxColumn.DataPropertyName = "IdTipProprietate";
            this.idTipProprietateDataGridViewTextBoxColumn.HeaderText = "IdTipProprietate";
            this.idTipProprietateDataGridViewTextBoxColumn.Name = "idTipProprietateDataGridViewTextBoxColumn";
            this.idTipProprietateDataGridViewTextBoxColumn.ReadOnly = true;
            this.idTipProprietateDataGridViewTextBoxColumn.Visible = false;
            // 
            // valoareDataGridViewTextBoxColumn
            // 
            this.valoareDataGridViewTextBoxColumn.DataPropertyName = "Valoare";
            this.valoareDataGridViewTextBoxColumn.HeaderText = "Valoare";
            this.valoareDataGridViewTextBoxColumn.Name = "valoareDataGridViewTextBoxColumn";
            this.valoareDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // denumireTipProprietateDataGridViewTextBoxColumn
            // 
            this.denumireTipProprietateDataGridViewTextBoxColumn.DataPropertyName = "DenumireTipProprietate";
            this.denumireTipProprietateDataGridViewTextBoxColumn.HeaderText = "DenumireTipProprietate";
            this.denumireTipProprietateDataGridViewTextBoxColumn.Name = "denumireTipProprietateDataGridViewTextBoxColumn";
            this.denumireTipProprietateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cNPDataGridViewTextBoxColumn
            // 
            this.cNPDataGridViewTextBoxColumn.DataPropertyName = "CNP";
            this.cNPDataGridViewTextBoxColumn.HeaderText = "CNP";
            this.cNPDataGridViewTextBoxColumn.Name = "cNPDataGridViewTextBoxColumn";
            this.cNPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inregistrariBindingSource
            // 
            this.inregistrariBindingSource.DataMember = "Inregistrari";
            this.inregistrariBindingSource.DataSource = this.dataSet6;
            // 
            // dataSet6
            // 
            this.dataSet6.DataSetName = "DataSet6";
            this.dataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inregistrariTableAdapter
            // 
            this.inregistrariTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRadiereDataGridViewTextBoxColumn,
            this.dataRadiereDataGridViewTextBoxColumn,
            this.idProprietarDataGridViewTextBoxColumn1,
            this.idTipProprietateDataGridViewTextBoxColumn1,
            this.valoareDataGridViewTextBoxColumn1,
            this.idInregistrareDataGridViewTextBoxColumn1,
            this.denumireTipProprietateDataGridViewTextBoxColumn1,
            this.cNPDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.radieriBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(504, 103);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(444, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // radieriBindingSource
            // 
            this.radieriBindingSource.DataMember = "Radieri";
            this.radieriBindingSource.DataSource = this.dataSet6;
            // 
            // radieriTableAdapter
            // 
            this.radieriTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(189, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Radiaza Inregistrare";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnActualizare
            // 
            this.btnActualizare.Location = new System.Drawing.Point(572, 12);
            this.btnActualizare.Name = "btnActualizare";
            this.btnActualizare.Size = new System.Drawing.Size(75, 37);
            this.btnActualizare.TabIndex = 3;
            this.btnActualizare.Text = "Modifica Data";
            this.btnActualizare.UseVisualStyleBackColor = true;
            this.btnActualizare.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRenuntare
            // 
            this.btnRenuntare.Location = new System.Drawing.Point(734, 19);
            this.btnRenuntare.Name = "btnRenuntare";
            this.btnRenuntare.Size = new System.Drawing.Size(75, 23);
            this.btnRenuntare.TabIndex = 5;
            this.btnRenuntare.Text = "Anuleaza";
            this.btnRenuntare.UseVisualStyleBackColor = true;
            this.btnRenuntare.Click += new System.EventHandler(this.btnRenuntare_Click);
            // 
            // btnSalvare
            // 
            this.btnSalvare.Location = new System.Drawing.Point(653, 19);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(75, 23);
            this.btnSalvare.TabIndex = 6;
            this.btnSalvare.Text = "Salveaza";
            this.btnSalvare.UseVisualStyleBackColor = true;
            this.btnSalvare.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnStergere
            // 
            this.btnStergere.Location = new System.Drawing.Point(572, 55);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(75, 35);
            this.btnStergere.TabIndex = 7;
            this.btnStergere.Text = "Sterge Radiere";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // idRadiereDataGridViewTextBoxColumn
            // 
            this.idRadiereDataGridViewTextBoxColumn.DataPropertyName = "IdRadiere";
            this.idRadiereDataGridViewTextBoxColumn.HeaderText = "IdRadiere";
            this.idRadiereDataGridViewTextBoxColumn.Name = "idRadiereDataGridViewTextBoxColumn";
            this.idRadiereDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataRadiereDataGridViewTextBoxColumn
            // 
            this.dataRadiereDataGridViewTextBoxColumn.DataPropertyName = "DataRadiere";
            this.dataRadiereDataGridViewTextBoxColumn.HeaderText = "DataRadiere";
            this.dataRadiereDataGridViewTextBoxColumn.Name = "dataRadiereDataGridViewTextBoxColumn";
            // 
            // idProprietarDataGridViewTextBoxColumn1
            // 
            this.idProprietarDataGridViewTextBoxColumn1.DataPropertyName = "IdProprietar";
            this.idProprietarDataGridViewTextBoxColumn1.HeaderText = "IdProprietar";
            this.idProprietarDataGridViewTextBoxColumn1.Name = "idProprietarDataGridViewTextBoxColumn1";
            this.idProprietarDataGridViewTextBoxColumn1.Visible = false;
            // 
            // idTipProprietateDataGridViewTextBoxColumn1
            // 
            this.idTipProprietateDataGridViewTextBoxColumn1.DataPropertyName = "IdTipProprietate";
            this.idTipProprietateDataGridViewTextBoxColumn1.HeaderText = "IdTipProprietate";
            this.idTipProprietateDataGridViewTextBoxColumn1.Name = "idTipProprietateDataGridViewTextBoxColumn1";
            this.idTipProprietateDataGridViewTextBoxColumn1.Visible = false;
            // 
            // valoareDataGridViewTextBoxColumn1
            // 
            this.valoareDataGridViewTextBoxColumn1.DataPropertyName = "Valoare";
            this.valoareDataGridViewTextBoxColumn1.HeaderText = "Valoare";
            this.valoareDataGridViewTextBoxColumn1.Name = "valoareDataGridViewTextBoxColumn1";
            // 
            // idInregistrareDataGridViewTextBoxColumn1
            // 
            this.idInregistrareDataGridViewTextBoxColumn1.DataPropertyName = "IdInregistrare";
            this.idInregistrareDataGridViewTextBoxColumn1.HeaderText = "IdInregistrare";
            this.idInregistrareDataGridViewTextBoxColumn1.Name = "idInregistrareDataGridViewTextBoxColumn1";
            this.idInregistrareDataGridViewTextBoxColumn1.Visible = false;
            // 
            // denumireTipProprietateDataGridViewTextBoxColumn1
            // 
            this.denumireTipProprietateDataGridViewTextBoxColumn1.DataPropertyName = "DenumireTipProprietate";
            this.denumireTipProprietateDataGridViewTextBoxColumn1.HeaderText = "DenumireTipProprietate";
            this.denumireTipProprietateDataGridViewTextBoxColumn1.Name = "denumireTipProprietateDataGridViewTextBoxColumn1";
            // 
            // cNPDataGridViewTextBoxColumn1
            // 
            this.cNPDataGridViewTextBoxColumn1.DataPropertyName = "CNP";
            this.cNPDataGridViewTextBoxColumn1.HeaderText = "CNP";
            this.cNPDataGridViewTextBoxColumn1.Name = "cNPDataGridViewTextBoxColumn1";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 450);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnSalvare);
            this.Controls.Add(this.btnRenuntare);
            this.Controls.Add(this.btnActualizare);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inregistrariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radieriBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet6 dataSet6;
        private System.Windows.Forms.BindingSource inregistrariBindingSource;
        private DataSet6TableAdapters.InregistrariTableAdapter inregistrariTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idInregistrareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInregistrareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProprietarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipProprietateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valoareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireTipProprietateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource radieriBindingSource;
        private DataSet6TableAdapters.RadieriTableAdapter radieriTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnActualizare;
        private System.Windows.Forms.Button btnRenuntare;
        private System.Windows.Forms.Button btnSalvare;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRadiereDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataRadiereDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProprietarDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipProprietateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn valoareDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idInregistrareDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireTipProprietateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPDataGridViewTextBoxColumn1;
    }
}