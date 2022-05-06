namespace Teste
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
            this.bnt1 = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bnt1
            // 
            this.bnt1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bnt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt1.ForeColor = System.Drawing.Color.DarkRed;
            this.bnt1.Location = new System.Drawing.Point(186, 162);
            this.bnt1.Name = "bnt1";
            this.bnt1.Size = new System.Drawing.Size(169, 78);
            this.bnt1.TabIndex = 0;
            this.bnt1.Text = "Executar";
            this.bnt1.UseVisualStyleBackColor = false;
            this.bnt1.Click += new System.EventHandler(this.bnt1_Click);
            this.bnt1.MouseEnter += new System.EventHandler(this.bnt1_MouseEnter);
            this.bnt1.MouseLeave += new System.EventHandler(this.bnt1_MouseLeave);
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.White;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(528, 80);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Titulo da Aplicação";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 353);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.bnt1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(200, 100);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minha Aplicação";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bnt1;
        private System.Windows.Forms.Label lblTitulo;
    }
}

