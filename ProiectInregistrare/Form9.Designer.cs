
namespace ProiectFinal
{
    partial class Form9
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inregistrariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radieriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proprietariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipProprietatiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblTitlu = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inregistrariToolStripMenuItem,
            this.radieriToolStripMenuItem,
            this.proprietariToolStripMenuItem,
            this.tipProprietatiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inregistrariToolStripMenuItem
            // 
            this.inregistrariToolStripMenuItem.Name = "inregistrariToolStripMenuItem";
            this.inregistrariToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.inregistrariToolStripMenuItem.Text = "Inregistrari";
            this.inregistrariToolStripMenuItem.Click += new System.EventHandler(this.inregistrariToolStripMenuItem_Click);
            // 
            // radieriToolStripMenuItem
            // 
            this.radieriToolStripMenuItem.Name = "radieriToolStripMenuItem";
            this.radieriToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.radieriToolStripMenuItem.Text = "Radieri";
            this.radieriToolStripMenuItem.Click += new System.EventHandler(this.radieriToolStripMenuItem_Click);
            // 
            // proprietariToolStripMenuItem
            // 
            this.proprietariToolStripMenuItem.Name = "proprietariToolStripMenuItem";
            this.proprietariToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.proprietariToolStripMenuItem.Text = "Proprietari";
            this.proprietariToolStripMenuItem.Click += new System.EventHandler(this.proprietariToolStripMenuItem_Click);
            // 
            // tipProprietatiToolStripMenuItem
            // 
            this.tipProprietatiToolStripMenuItem.Name = "tipProprietatiToolStripMenuItem";
            this.tipProprietatiToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.tipProprietatiToolStripMenuItem.Text = "Tip Proprietati";
            this.tipProprietatiToolStripMenuItem.Click += new System.EventHandler(this.tipProprietatiToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlu.Location = new System.Drawing.Point(114, 119);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(577, 24);
            this.lblTitlu.TabIndex = 1;
            this.lblTitlu.Text = "Aplicatie pt. inregistrarea proprietatilor unei persoane la SPIT";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(518, 164);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(126, 16);
            this.lblAutor.TabIndex = 2;
            this.lblAutor.Text = "Autor: Paun Raducu";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 56);
            this.button1.TabIndex = 3;
            this.button1.Text = "Evaluarea Situatiei Proprietatilor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(309, 303);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 56);
            this.button3.TabIndex = 5;
            this.button3.Text = "Raport Inregistrari Proprietati";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form9";
            this.Text = "Form9";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inregistrariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radieriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proprietariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipProprietatiToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}