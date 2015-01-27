namespace ViktorinaApp
{
    partial class Titulinis
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
            this.txtVardas = new System.Windows.Forms.TextBox();
            this.lblIvesti = new System.Windows.Forms.Label();
            this.btnZaisti = new System.Windows.Forms.Button();
            this.btnLenta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtVardas
            // 
            this.txtVardas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVardas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtVardas.Location = new System.Drawing.Point(149, 73);
            this.txtVardas.Name = "txtVardas";
            this.txtVardas.Size = new System.Drawing.Size(271, 26);
            this.txtVardas.TabIndex = 0;
            this.txtVardas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblIvesti
            // 
            this.lblIvesti.AutoSize = true;
            this.lblIvesti.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblIvesti.Location = new System.Drawing.Point(123, 45);
            this.lblIvesti.Name = "lblIvesti";
            this.lblIvesti.Size = new System.Drawing.Size(337, 25);
            this.lblIvesti.TabIndex = 1;
            this.lblIvesti.Text = "PRAŠOME ĮVESTI SAVO VARDĄ:";
            // 
            // btnZaisti
            // 
            this.btnZaisti.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnZaisti.Location = new System.Drawing.Point(233, 105);
            this.btnZaisti.Name = "btnZaisti";
            this.btnZaisti.Size = new System.Drawing.Size(104, 47);
            this.btnZaisti.TabIndex = 2;
            this.btnZaisti.Text = "ŽAISTI";
            this.btnZaisti.UseVisualStyleBackColor = true;
            // 
            // btnLenta
            // 
            this.btnLenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnLenta.Location = new System.Drawing.Point(449, 203);
            this.btnLenta.Name = "btnLenta";
            this.btnLenta.Size = new System.Drawing.Size(104, 47);
            this.btnLenta.TabIndex = 3;
            this.btnLenta.Text = "LENTA";
            this.btnLenta.UseVisualStyleBackColor = true;
            // 
            // Titulinis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 262);
            this.Controls.Add(this.btnLenta);
            this.Controls.Add(this.btnZaisti);
            this.Controls.Add(this.lblIvesti);
            this.Controls.Add(this.txtVardas);
            this.Name = "Titulinis";
            this.Text = "TITULINIS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVardas;
        private System.Windows.Forms.Label lblIvesti;
        private System.Windows.Forms.Button btnZaisti;
        private System.Windows.Forms.Button btnLenta;
    }
}

