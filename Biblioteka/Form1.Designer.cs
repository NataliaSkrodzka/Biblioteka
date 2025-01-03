namespace Biblioteka
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.wyswietlWszystkie = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dodajNowa = new System.Windows.Forms.Button();
            this.usun = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // wyswietlWszystkie
            // 
            this.wyswietlWszystkie.Location = new System.Drawing.Point(51, 55);
            this.wyswietlWszystkie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wyswietlWszystkie.Name = "wyswietlWszystkie";
            this.wyswietlWszystkie.Size = new System.Drawing.Size(169, 42);
            this.wyswietlWszystkie.TabIndex = 0;
            this.wyswietlWszystkie.Text = "Wyświetl wszystkie książki";
            this.wyswietlWszystkie.UseVisualStyleBackColor = true;
            this.wyswietlWszystkie.Click += new System.EventHandler(this.wyswietl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(252, 55);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 66);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dodajNowa
            // 
            this.dodajNowa.Location = new System.Drawing.Point(252, 126);
            this.dodajNowa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dodajNowa.Name = "dodajNowa";
            this.dodajNowa.Size = new System.Drawing.Size(141, 47);
            this.dodajNowa.TabIndex = 3;
            this.dodajNowa.Text = "Dodaj nową";
            this.dodajNowa.UseVisualStyleBackColor = true;
            this.dodajNowa.Click += new System.EventHandler(this.dodaj_Click);
            // 
            // usun
            // 
            this.usun.Location = new System.Drawing.Point(480, 126);
            this.usun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usun.Name = "usun";
            this.usun.Size = new System.Drawing.Size(141, 47);
            this.usun.TabIndex = 4;
            this.usun.Text = "Usuń";
            this.usun.UseVisualStyleBackColor = true;
            this.usun.Click += new System.EventHandler(this.usun_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(480, 55);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(169, 66);
            this.textBox2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(789, 517);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.usun);
            this.Controls.Add(this.dodajNowa);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wyswietlWszystkie);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Biblioteka";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button wyswietlWszystkie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button dodajNowa;
        private System.Windows.Forms.Button usun;
        private System.Windows.Forms.TextBox textBox2;
    }
}

