namespace ZadatakKolokvijum1
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
            this.txtSadrzaj = new System.Windows.Forms.TextBox();
            this.btnOtvoriFajl = new System.Windows.Forms.Button();
            this.txtPronadji = new System.Windows.Forms.TextBox();
            this.txtZameni = new System.Windows.Forms.TextBox();
            this.btnSnimiFajl = new System.Windows.Forms.Button();
            this.btnZavrsiProgram = new System.Windows.Forms.Button();
            this.btnPronadjiZameni = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // txtSadrzaj
            // 
            this.txtSadrzaj.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSadrzaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSadrzaj.Location = new System.Drawing.Point(12, 67);
            this.txtSadrzaj.Multiline = true;
            this.txtSadrzaj.Name = "txtSadrzaj";
            this.txtSadrzaj.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSadrzaj.Size = new System.Drawing.Size(760, 380);
            this.txtSadrzaj.TabIndex = 0;
            // 
            // btnOtvoriFajl
            // 
            this.btnOtvoriFajl.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOtvoriFajl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOtvoriFajl.Location = new System.Drawing.Point(13, 12);
            this.btnOtvoriFajl.Name = "btnOtvoriFajl";
            this.btnOtvoriFajl.Size = new System.Drawing.Size(100, 49);
            this.btnOtvoriFajl.TabIndex = 1;
            this.btnOtvoriFajl.Text = "&Otvori fajl";
            this.btnOtvoriFajl.UseVisualStyleBackColor = true;
            this.btnOtvoriFajl.Click += new System.EventHandler(this.btnOtvoriFajl_Click);
            // 
            // txtPronadji
            // 
            this.txtPronadji.Location = new System.Drawing.Point(275, 12);
            this.txtPronadji.Name = "txtPronadji";
            this.txtPronadji.Size = new System.Drawing.Size(100, 20);
            this.txtPronadji.TabIndex = 5;
            // 
            // txtZameni
            // 
            this.txtZameni.Location = new System.Drawing.Point(275, 41);
            this.txtZameni.Name = "txtZameni";
            this.txtZameni.Size = new System.Drawing.Size(100, 20);
            this.txtZameni.TabIndex = 6;
            // 
            // btnSnimiFajl
            // 
            this.btnSnimiFajl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSnimiFajl.Location = new System.Drawing.Point(526, 12);
            this.btnSnimiFajl.Name = "btnSnimiFajl";
            this.btnSnimiFajl.Size = new System.Drawing.Size(94, 49);
            this.btnSnimiFajl.TabIndex = 7;
            this.btnSnimiFajl.Text = "&Snimi fajl (Save As...)";
            this.btnSnimiFajl.UseVisualStyleBackColor = true;
            this.btnSnimiFajl.Click += new System.EventHandler(this.btnSnimiFajl_Click);
            // 
            // btnZavrsiProgram
            // 
            this.btnZavrsiProgram.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZavrsiProgram.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnZavrsiProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZavrsiProgram.Location = new System.Drawing.Point(679, 13);
            this.btnZavrsiProgram.Name = "btnZavrsiProgram";
            this.btnZavrsiProgram.Size = new System.Drawing.Size(93, 49);
            this.btnZavrsiProgram.TabIndex = 8;
            this.btnZavrsiProgram.Text = "Zavrsi program";
            this.btnZavrsiProgram.UseVisualStyleBackColor = true;
            this.btnZavrsiProgram.Click += new System.EventHandler(this.btnZavrsiProgram_Click);
            // 
            // btnPronadjiZameni
            // 
            this.btnPronadjiZameni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPronadjiZameni.Location = new System.Drawing.Point(399, 12);
            this.btnPronadjiZameni.Name = "btnPronadjiZameni";
            this.btnPronadjiZameni.Size = new System.Drawing.Size(94, 49);
            this.btnPronadjiZameni.TabIndex = 9;
            this.btnPronadjiZameni.Text = "Pronadji i zameni";
            this.btnPronadjiZameni.UseVisualStyleBackColor = true;
            this.btnPronadjiZameni.Click += new System.EventHandler(this.btnPronadjiZameni_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(204, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Pronadji:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(204, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Zameni:";
            // 
            // dlgOpen
            // 
            this.dlgOpen.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnZavrsiProgram;
            this.ClientSize = new System.Drawing.Size(784, 459);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPronadjiZameni);
            this.Controls.Add(this.btnZavrsiProgram);
            this.Controls.Add(this.btnSnimiFajl);
            this.Controls.Add(this.txtZameni);
            this.Controls.Add(this.txtPronadji);
            this.Controls.Add(this.btnOtvoriFajl);
            this.Controls.Add(this.txtSadrzaj);
            this.MinimumSize = new System.Drawing.Size(800, 300);
            this.Name = "Form1";
            this.Text = "Filip Protic S10/18";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSadrzaj;
        private System.Windows.Forms.Button btnOtvoriFajl;
        private System.Windows.Forms.TextBox txtPronadji;
        private System.Windows.Forms.TextBox txtZameni;
        private System.Windows.Forms.Button btnSnimiFajl;
        private System.Windows.Forms.Button btnZavrsiProgram;
        private System.Windows.Forms.Button btnPronadjiZameni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.SaveFileDialog dlgSave;
    }
}

