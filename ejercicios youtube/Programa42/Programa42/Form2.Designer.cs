﻿namespace Programa42
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
            this.btnInvalidate = new System.Windows.Forms.Button();
            this.btnDibuja = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInvalidate
            // 
            this.btnInvalidate.Location = new System.Drawing.Point(656, 75);
            this.btnInvalidate.Name = "btnInvalidate";
            this.btnInvalidate.Size = new System.Drawing.Size(75, 23);
            this.btnInvalidate.TabIndex = 0;
            this.btnInvalidate.Text = "Invalidate";
            this.btnInvalidate.UseVisualStyleBackColor = true;
            // 
            // btnDibuja
            // 
            this.btnDibuja.Location = new System.Drawing.Point(656, 119);
            this.btnDibuja.Name = "btnDibuja";
            this.btnDibuja.Size = new System.Drawing.Size(75, 23);
            this.btnDibuja.TabIndex = 1;
            this.btnDibuja.Text = "Dibuja";
            this.btnDibuja.UseVisualStyleBackColor = true;
            this.btnDibuja.Click += new System.EventHandler(this.btnDibuja_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDibuja);
            this.Controls.Add(this.btnInvalidate);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form2_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInvalidate;
        private System.Windows.Forms.Button btnDibuja;
    }
}