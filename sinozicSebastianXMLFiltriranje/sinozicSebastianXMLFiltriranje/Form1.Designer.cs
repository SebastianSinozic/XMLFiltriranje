﻿
namespace sinozicSebastianXMLFiltriranje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnUnos = new System.Windows.Forms.Button();
            this.btnPrikaz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUnos
            // 
            this.btnUnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnUnos.Location = new System.Drawing.Point(32, 168);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(135, 33);
            this.btnUnos.TabIndex = 0;
            this.btnUnos.Text = "Unos";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // btnPrikaz
            // 
            this.btnPrikaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnPrikaz.Location = new System.Drawing.Point(32, 217);
            this.btnPrikaz.Name = "btnPrikaz";
            this.btnPrikaz.Size = new System.Drawing.Size(135, 33);
            this.btnPrikaz.TabIndex = 1;
            this.btnPrikaz.Text = "Prikaz";
            this.btnPrikaz.UseVisualStyleBackColor = true;
            this.btnPrikaz.Click += new System.EventHandler(this.btnPrikaz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(203, 277);
            this.Controls.Add(this.btnPrikaz);
            this.Controls.Add(this.btnUnos);
            this.Name = "Form1";
            this.Text = "XML Filtriranje";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Button btnPrikaz;
    }
}

