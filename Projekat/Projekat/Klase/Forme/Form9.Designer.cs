namespace Projekat.Klase.Forme
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.zvanje = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.prezime = new System.Windows.Forms.Label();
            this.ime = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bris = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pretraga profesora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prezime:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Zvanje:";
            // 
            // zvanje
            // 
            this.zvanje.AutoSize = true;
            this.zvanje.Location = new System.Drawing.Point(127, 218);
            this.zvanje.Name = "zvanje";
            this.zvanje.Size = new System.Drawing.Size(0, 13);
            this.zvanje.TabIndex = 8;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(127, 169);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(0, 13);
            this.email.TabIndex = 7;
            // 
            // prezime
            // 
            this.prezime.AutoSize = true;
            this.prezime.Location = new System.Drawing.Point(127, 120);
            this.prezime.Name = "prezime";
            this.prezime.Size = new System.Drawing.Size(0, 13);
            this.prezime.TabIndex = 6;
            // 
            // ime
            // 
            this.ime.AutoSize = true;
            this.ime.Location = new System.Drawing.Point(127, 71);
            this.ime.Name = "ime";
            this.ime.Size = new System.Drawing.Size(0, 13);
            this.ime.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Dalje";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 306);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Nazad";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bris
            // 
            this.bris.Location = new System.Drawing.Point(218, 13);
            this.bris.Name = "bris";
            this.bris.Size = new System.Drawing.Size(91, 23);
            this.bris.TabIndex = 24;
            this.bris.Text = "Obrisi";
            this.bris.UseVisualStyleBackColor = true;
            this.bris.Click += new System.EventHandler(this.bris_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 277);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 23);
            this.button3.TabIndex = 28;
            this.button3.Text = "Glavni Meni";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 351);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bris);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.zvanje);
            this.Controls.Add(this.email);
            this.Controls.Add(this.prezime);
            this.Controls.Add(this.ime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pretraga Profesora";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form9_FormClosing);
            this.Load += new System.EventHandler(this.Form9_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label zvanje;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label prezime;
        private System.Windows.Forms.Label ime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bris;
        private System.Windows.Forms.Button button3;
    }
}