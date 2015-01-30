namespace ViktorinaApp
{
    partial class Zaidimas
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
            this.txtAtsakymas = new System.Windows.Forms.TextBox();
            this.lblKlausimas = new System.Windows.Forms.Label();
            this.btnPabaiga = new System.Windows.Forms.Button();
            this.lblLaikmatis = new System.Windows.Forms.Label();
            this.lblLaikas = new System.Windows.Forms.Label();
            this.btnTikrinimas = new System.Windows.Forms.Button();
            this.lblPagalba = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAtsakymas
            // 
            this.txtAtsakymas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtAtsakymas.Location = new System.Drawing.Point(83, 276);
            this.txtAtsakymas.Name = "txtAtsakymas";
            this.txtAtsakymas.Size = new System.Drawing.Size(597, 29);
            this.txtAtsakymas.TabIndex = 0;
            this.txtAtsakymas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblKlausimas
            // 
            this.lblKlausimas.AutoSize = true;
            this.lblKlausimas.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.lblKlausimas.Location = new System.Drawing.Point(12, 43);
            this.lblKlausimas.Name = "lblKlausimas";
            this.lblKlausimas.Size = new System.Drawing.Size(147, 29);
            this.lblKlausimas.TabIndex = 1;
            this.lblKlausimas.Text = "KLAUSIMAS";
            // 
            // btnPabaiga
            // 
            this.btnPabaiga.BackColor = System.Drawing.Color.Gray;
            this.btnPabaiga.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnPabaiga.Location = new System.Drawing.Point(686, 12);
            this.btnPabaiga.Name = "btnPabaiga";
            this.btnPabaiga.Size = new System.Drawing.Size(36, 32);
            this.btnPabaiga.TabIndex = 2;
            this.btnPabaiga.Text = "X";
            this.btnPabaiga.UseVisualStyleBackColor = false;
            // 
            // lblLaikmatis
            // 
            this.lblLaikmatis.AutoSize = true;
            this.lblLaikmatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lblLaikmatis.Location = new System.Drawing.Point(13, 188);
            this.lblLaikmatis.Name = "lblLaikmatis";
            this.lblLaikmatis.Size = new System.Drawing.Size(102, 22);
            this.lblLaikmatis.TabIndex = 3;
            this.lblLaikmatis.Text = "LAIKMATIS";
            // 
            // lblLaikas
            // 
            this.lblLaikas.AutoSize = true;
            this.lblLaikas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lblLaikas.Location = new System.Drawing.Point(13, 381);
            this.lblLaikas.Name = "lblLaikas";
            this.lblLaikas.Size = new System.Drawing.Size(188, 22);
            this.lblLaikas.TabIndex = 4;
            this.lblLaikas.Text = "PRALEISTAS LAIKAS";
            // 
            // btnTikrinimas
            // 
            this.btnTikrinimas.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnTikrinimas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnTikrinimas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTikrinimas.Location = new System.Drawing.Point(339, 311);
            this.btnTikrinimas.Name = "btnTikrinimas";
            this.btnTikrinimas.Size = new System.Drawing.Size(75, 33);
            this.btnTikrinimas.TabIndex = 5;
            this.btnTikrinimas.Text = "TIKRINTI";
            this.btnTikrinimas.UseVisualStyleBackColor = false;
            // 
            // lblPagalba
            // 
            this.lblPagalba.AutoSize = true;
            this.lblPagalba.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lblPagalba.Location = new System.Drawing.Point(13, 240);
            this.lblPagalba.Name = "lblPagalba";
            this.lblPagalba.Size = new System.Drawing.Size(94, 22);
            this.lblPagalba.TabIndex = 6;
            this.lblPagalba.Text = "PAGALBA";
            // 
            // Zaidimas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 412);
            this.Controls.Add(this.lblPagalba);
            this.Controls.Add(this.btnTikrinimas);
            this.Controls.Add(this.lblLaikas);
            this.Controls.Add(this.lblLaikmatis);
            this.Controls.Add(this.btnPabaiga);
            this.Controls.Add(this.lblKlausimas);
            this.Controls.Add(this.txtAtsakymas);
            this.Name = "Zaidimas";
            this.Text = "Viktorina";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAtsakymas;
        private System.Windows.Forms.Label lblKlausimas;
        private System.Windows.Forms.Button btnPabaiga;
        private System.Windows.Forms.Label lblLaikmatis;
        private System.Windows.Forms.Label lblLaikas;
        private System.Windows.Forms.Button btnTikrinimas;
        private System.Windows.Forms.Label lblPagalba;
    }
}