﻿namespace Credits
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
            this.txbx_name = new System.Windows.Forms.TextBox();
            this.txbx_surname = new System.Windows.Forms.TextBox();
            this.txbx_passportnumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_takecredit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbx_name
            // 
            this.txbx_name.Location = new System.Drawing.Point(154, 83);
            this.txbx_name.Name = "txbx_name";
            this.txbx_name.Size = new System.Drawing.Size(182, 22);
            this.txbx_name.TabIndex = 0;
            // 
            // txbx_surname
            // 
            this.txbx_surname.Location = new System.Drawing.Point(154, 145);
            this.txbx_surname.Name = "txbx_surname";
            this.txbx_surname.Size = new System.Drawing.Size(182, 22);
            this.txbx_surname.TabIndex = 2;
            // 
            // txbx_passportnumber
            // 
            this.txbx_passportnumber.Location = new System.Drawing.Point(154, 215);
            this.txbx_passportnumber.Name = "txbx_passportnumber";
            this.txbx_passportnumber.Size = new System.Drawing.Size(182, 22);
            this.txbx_passportnumber.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "PassportNumber";
            // 
            // btn_takecredit
            // 
            this.btn_takecredit.Location = new System.Drawing.Point(428, 279);
            this.btn_takecredit.Name = "btn_takecredit";
            this.btn_takecredit.Size = new System.Drawing.Size(93, 41);
            this.btn_takecredit.TabIndex = 8;
            this.btn_takecredit.Text = "Take Credit";
            this.btn_takecredit.UseVisualStyleBackColor = true;
            this.btn_takecredit.Click += new System.EventHandler(this.btn_takecredit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 617);
            this.Controls.Add(this.btn_takecredit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbx_passportnumber);
            this.Controls.Add(this.txbx_surname);
            this.Controls.Add(this.txbx_name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbx_name;
        private System.Windows.Forms.TextBox txbx_surname;
        private System.Windows.Forms.TextBox txbx_passportnumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_takecredit;
    }
}

