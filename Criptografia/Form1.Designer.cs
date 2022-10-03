namespace Criptografia
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
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnCriptografar = new System.Windows.Forms.Button();
            this.TxtDesceiptografado = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.TxtCriptografado = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.TxtCriptografar = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Location = new System.Drawing.Point(93, 179);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(78, 23);
            this.BtnLimpar.TabIndex = 23;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnCriptografar
            // 
            this.BtnCriptografar.Location = new System.Drawing.Point(15, 179);
            this.BtnCriptografar.Name = "BtnCriptografar";
            this.BtnCriptografar.Size = new System.Drawing.Size(72, 23);
            this.BtnCriptografar.TabIndex = 22;
            this.BtnCriptografar.Text = "Criptografar";
            this.BtnCriptografar.UseVisualStyleBackColor = true;
            this.BtnCriptografar.Click += new System.EventHandler(this.BtnCriptografar_Click);
            // 
            // TxtDesceiptografado
            // 
            this.TxtDesceiptografado.Location = new System.Drawing.Point(15, 137);
            this.TxtDesceiptografado.Name = "TxtDesceiptografado";
            this.TxtDesceiptografado.Size = new System.Drawing.Size(156, 20);
            this.TxtDesceiptografado.TabIndex = 21;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(12, 121);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(122, 13);
            this.Label3.TabIndex = 20;
            this.Label3.Text = "Texto descriptografado: ";
            // 
            // TxtCriptografado
            // 
            this.TxtCriptografado.Location = new System.Drawing.Point(15, 89);
            this.TxtCriptografado.Name = "TxtCriptografado";
            this.TxtCriptografado.Size = new System.Drawing.Size(156, 20);
            this.TxtCriptografado.TabIndex = 19;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(12, 73);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(105, 13);
            this.Label2.TabIndex = 18;
            this.Label2.Text = "Texto criptografado: ";
            // 
            // TxtCriptografar
            // 
            this.TxtCriptografar.Location = new System.Drawing.Point(15, 40);
            this.TxtCriptografar.Name = "TxtCriptografar";
            this.TxtCriptografar.Size = new System.Drawing.Size(156, 20);
            this.TxtCriptografar.TabIndex = 17;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 24);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(120, 13);
            this.Label1.TabIndex = 16;
            this.Label1.Text = "Texto para criptografar: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 448);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnCriptografar);
            this.Controls.Add(this.TxtDesceiptografado);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.TxtCriptografado);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TxtCriptografar);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button BtnLimpar;
        internal System.Windows.Forms.Button BtnCriptografar;
        internal System.Windows.Forms.TextBox TxtDesceiptografado;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox TxtCriptografado;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox TxtCriptografar;
        internal System.Windows.Forms.Label Label1;
    }
}

