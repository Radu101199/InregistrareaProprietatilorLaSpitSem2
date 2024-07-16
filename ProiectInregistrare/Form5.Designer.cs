
namespace ProiectFinal
{
    partial class Form5
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
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.btnModificare = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idInregistrareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInregistrareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProprietarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTipProprietateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valoareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denumireTipProprietateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inregistrariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet5 = new ProiectFinal.DataSet5();
            this.dataSet5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inregistrariTableAdapter = new ProiectFinal.DataSet5TableAdapters.InregistrariTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIdInregistrare = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tipProprietateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.valoareTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.proprietariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipProprietateBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.inregistrariBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnConfirmare = new System.Windows.Forms.Button();
            this.btnRenuntare = new System.Windows.Forms.Button();
            this.tipProprietateTableAdapter = new ProiectFinal.DataSet5TableAdapters.TipProprietateTableAdapter();
            this.tipProprietateBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.proprietariTableAdapter = new ProiectFinal.DataSet5TableAdapters.ProprietariTableAdapter();
            this.lblOp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inregistrariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet5BindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipProprietateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proprietariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipProprietateBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inregistrariBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipProprietateBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Location = new System.Drawing.Point(56, 31);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(75, 23);
            this.btnAdaugare.TabIndex = 0;
            this.btnAdaugare.Text = "Adaugare";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // btnModificare
            // 
            this.btnModificare.Location = new System.Drawing.Point(137, 31);
            this.btnModificare.Name = "btnModificare";
            this.btnModificare.Size = new System.Drawing.Size(75, 23);
            this.btnModificare.TabIndex = 1;
            this.btnModificare.Text = "Modificare";
            this.btnModificare.UseVisualStyleBackColor = true;
            this.btnModificare.Click += new System.EventHandler(this.btnModificare_Click);
            // 
            // btnStergere
            // 
            this.btnStergere.Location = new System.Drawing.Point(218, 31);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(75, 23);
            this.btnStergere.TabIndex = 2;
            this.btnStergere.Text = "Stergere";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // dataGridView1
            // 
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
            this.dataGridView1.Location = new System.Drawing.Point(21, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(458, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // idInregistrareDataGridViewTextBoxColumn
            // 
            this.idInregistrareDataGridViewTextBoxColumn.DataPropertyName = "IdInregistrare";
            this.idInregistrareDataGridViewTextBoxColumn.HeaderText = "IdInregistrare";
            this.idInregistrareDataGridViewTextBoxColumn.Name = "idInregistrareDataGridViewTextBoxColumn";
            this.idInregistrareDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataInregistrareDataGridViewTextBoxColumn
            // 
            this.dataInregistrareDataGridViewTextBoxColumn.DataPropertyName = "DataInregistrare";
            this.dataInregistrareDataGridViewTextBoxColumn.HeaderText = "DataInregistrare";
            this.dataInregistrareDataGridViewTextBoxColumn.Name = "dataInregistrareDataGridViewTextBoxColumn";
            // 
            // idProprietarDataGridViewTextBoxColumn
            // 
            this.idProprietarDataGridViewTextBoxColumn.DataPropertyName = "IdProprietar";
            this.idProprietarDataGridViewTextBoxColumn.HeaderText = "IdProprietar";
            this.idProprietarDataGridViewTextBoxColumn.Name = "idProprietarDataGridViewTextBoxColumn";
            this.idProprietarDataGridViewTextBoxColumn.Visible = false;
            // 
            // idTipProprietateDataGridViewTextBoxColumn
            // 
            this.idTipProprietateDataGridViewTextBoxColumn.DataPropertyName = "IdTipProprietate";
            this.idTipProprietateDataGridViewTextBoxColumn.HeaderText = "IdTipProprietate";
            this.idTipProprietateDataGridViewTextBoxColumn.Name = "idTipProprietateDataGridViewTextBoxColumn";
            this.idTipProprietateDataGridViewTextBoxColumn.Visible = false;
            // 
            // valoareDataGridViewTextBoxColumn
            // 
            this.valoareDataGridViewTextBoxColumn.DataPropertyName = "Valoare";
            this.valoareDataGridViewTextBoxColumn.HeaderText = "Valoare";
            this.valoareDataGridViewTextBoxColumn.Name = "valoareDataGridViewTextBoxColumn";
            // 
            // denumireTipProprietateDataGridViewTextBoxColumn
            // 
            this.denumireTipProprietateDataGridViewTextBoxColumn.DataPropertyName = "DenumireTipProprietate";
            this.denumireTipProprietateDataGridViewTextBoxColumn.HeaderText = "DenumireTipProprietate";
            this.denumireTipProprietateDataGridViewTextBoxColumn.Name = "denumireTipProprietateDataGridViewTextBoxColumn";
            // 
            // cNPDataGridViewTextBoxColumn
            // 
            this.cNPDataGridViewTextBoxColumn.DataPropertyName = "CNP";
            this.cNPDataGridViewTextBoxColumn.HeaderText = "CNP";
            this.cNPDataGridViewTextBoxColumn.Name = "cNPDataGridViewTextBoxColumn";
            // 
            // inregistrariBindingSource
            // 
            this.inregistrariBindingSource.DataMember = "Inregistrari";
            this.inregistrariBindingSource.DataSource = this.dataSet5;
            // 
            // dataSet5
            // 
            this.dataSet5.DataSetName = "DataSet5";
            this.dataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet5BindingSource
            // 
            this.dataSet5BindingSource.DataSource = this.dataSet5;
            this.dataSet5BindingSource.Position = 0;
            // 
            // inregistrariTableAdapter
            // 
            this.inregistrariTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.valoareTextBox);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.txtIdInregistrare);
            this.groupBox1.Location = new System.Drawing.Point(546, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 185);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txtIdInregistrare
            // 
            this.txtIdInregistrare.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inregistrariBindingSource, "IdInregistrare", true));
            this.txtIdInregistrare.Location = new System.Drawing.Point(97, 130);
            this.txtIdInregistrare.Name = "txtIdInregistrare";
            this.txtIdInregistrare.Size = new System.Drawing.Size(100, 20);
            this.txtIdInregistrare.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "CNP Proprietar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tip Proprietate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Valoare";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Data";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.proprietariBindingSource;
            this.comboBox2.DisplayMember = "CNP";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(97, 131);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.ValueMember = "IdProprietar";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tipProprietateBindingSource;
            this.comboBox1.DisplayMember = "DenumireTipProprietate";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(97, 89);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.ValueMember = "IdTipProprietate";
            // 
            // tipProprietateBindingSource
            // 
            this.tipProprietateBindingSource.DataMember = "TipProprietate";
            this.tipProprietateBindingSource.DataSource = this.dataSet5BindingSource;
            // 
            // valoareTextBox
            // 
            this.valoareTextBox.Location = new System.Drawing.Point(109, 24);
            this.valoareTextBox.Name = "valoareTextBox";
            this.valoareTextBox.Size = new System.Drawing.Size(100, 20);
            this.valoareTextBox.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.AllowDrop = true;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(109, 60);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(97, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // proprietariBindingSource
            // 
            this.proprietariBindingSource.DataMember = "Proprietari";
            this.proprietariBindingSource.DataSource = this.dataSet5BindingSource;
            // 
            // tipProprietateBindingSource2
            // 
            this.tipProprietateBindingSource2.DataMember = "TipProprietate";
            this.tipProprietateBindingSource2.DataSource = this.dataSet5;
            // 
            // inregistrariBindingSource1
            // 
            this.inregistrariBindingSource1.DataMember = "Inregistrari";
            this.inregistrariBindingSource1.DataSource = this.dataSet5;
            // 
            // btnConfirmare
            // 
            this.btnConfirmare.Location = new System.Drawing.Point(546, 30);
            this.btnConfirmare.Name = "btnConfirmare";
            this.btnConfirmare.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmare.TabIndex = 5;
            this.btnConfirmare.Text = "Confirmare";
            this.btnConfirmare.UseVisualStyleBackColor = true;
            this.btnConfirmare.Click += new System.EventHandler(this.btnConfirmare_Click);
            // 
            // btnRenuntare
            // 
            this.btnRenuntare.Location = new System.Drawing.Point(627, 30);
            this.btnRenuntare.Name = "btnRenuntare";
            this.btnRenuntare.Size = new System.Drawing.Size(75, 23);
            this.btnRenuntare.TabIndex = 6;
            this.btnRenuntare.Text = "Renuntare";
            this.btnRenuntare.UseVisualStyleBackColor = true;
            this.btnRenuntare.Click += new System.EventHandler(this.btnRenuntare_Click);
            // 
            // tipProprietateTableAdapter
            // 
            this.tipProprietateTableAdapter.ClearBeforeFill = true;
            // 
            // tipProprietateBindingSource1
            // 
            this.tipProprietateBindingSource1.DataMember = "TipProprietate";
            this.tipProprietateBindingSource1.DataSource = this.dataSet5BindingSource;
            // 
            // proprietariTableAdapter
            // 
            this.proprietariTableAdapter.ClearBeforeFill = true;
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Location = new System.Drawing.Point(708, 35);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(31, 13);
            this.lblOp.TabIndex = 7;
            this.lblOp.Text = "lblOp";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.btnRenuntare);
            this.Controls.Add(this.btnConfirmare);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnModificare);
            this.Controls.Add(this.btnAdaugare);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inregistrariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet5BindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipProprietateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proprietariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipProprietateBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inregistrariBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipProprietateBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.Button btnModificare;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dataSet5BindingSource;
        private DataSet5 dataSet5;
        private System.Windows.Forms.BindingSource inregistrariBindingSource;
        private DataSet5TableAdapters.InregistrariTableAdapter inregistrariTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idInregistrareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInregistrareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProprietarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipProprietateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valoareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireTipProprietateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox valoareTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnConfirmare;
        private System.Windows.Forms.Button btnRenuntare;
        private System.Windows.Forms.BindingSource inregistrariBindingSource1;
        private System.Windows.Forms.BindingSource tipProprietateBindingSource;
        private DataSet5TableAdapters.TipProprietateTableAdapter tipProprietateTableAdapter;
        private System.Windows.Forms.BindingSource tipProprietateBindingSource1;
        private System.Windows.Forms.BindingSource proprietariBindingSource;
        private DataSet5TableAdapters.ProprietariTableAdapter proprietariTableAdapter;
        private System.Windows.Forms.BindingSource tipProprietateBindingSource2;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.TextBox txtIdInregistrare;
    }
}