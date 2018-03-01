namespace P_Elevador
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
            this.btnPisoUno = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.btnPisoCuatro = new System.Windows.Forms.Button();
            this.btnPisoDos = new System.Windows.Forms.Button();
            this.btnPisoCinco = new System.Windows.Forms.Button();
            this.btnPisoTres = new System.Windows.Forms.Button();
            this.btnPisoSeis = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPisoUno
            // 
            this.btnPisoUno.Location = new System.Drawing.Point(376, 108);
            this.btnPisoUno.Name = "btnPisoUno";
            this.btnPisoUno.Size = new System.Drawing.Size(75, 23);
            this.btnPisoUno.TabIndex = 0;
            this.btnPisoUno.Text = "1";
            this.btnPisoUno.UseVisualStyleBackColor = true;
            this.btnPisoUno.Click += new System.EventHandler(this.btnPisoUno_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(12, 92);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(274, 147);
            this.txtInfo.TabIndex = 1;
            // 
            // btnPisoCuatro
            // 
            this.btnPisoCuatro.Location = new System.Drawing.Point(482, 108);
            this.btnPisoCuatro.Name = "btnPisoCuatro";
            this.btnPisoCuatro.Size = new System.Drawing.Size(75, 23);
            this.btnPisoCuatro.TabIndex = 2;
            this.btnPisoCuatro.Text = "4";
            this.btnPisoCuatro.UseVisualStyleBackColor = true;
            this.btnPisoCuatro.Click += new System.EventHandler(this.btnPisoCuatro_Click);
            // 
            // btnPisoDos
            // 
            this.btnPisoDos.Location = new System.Drawing.Point(376, 161);
            this.btnPisoDos.Name = "btnPisoDos";
            this.btnPisoDos.Size = new System.Drawing.Size(75, 23);
            this.btnPisoDos.TabIndex = 3;
            this.btnPisoDos.Text = "2";
            this.btnPisoDos.UseVisualStyleBackColor = true;
            this.btnPisoDos.Click += new System.EventHandler(this.btnPisoDos_Click);
            // 
            // btnPisoCinco
            // 
            this.btnPisoCinco.Location = new System.Drawing.Point(482, 161);
            this.btnPisoCinco.Name = "btnPisoCinco";
            this.btnPisoCinco.Size = new System.Drawing.Size(75, 23);
            this.btnPisoCinco.TabIndex = 4;
            this.btnPisoCinco.Text = "5";
            this.btnPisoCinco.UseVisualStyleBackColor = true;
            this.btnPisoCinco.Click += new System.EventHandler(this.btnPisoCinco_Click);
            // 
            // btnPisoTres
            // 
            this.btnPisoTres.Location = new System.Drawing.Point(376, 216);
            this.btnPisoTres.Name = "btnPisoTres";
            this.btnPisoTres.Size = new System.Drawing.Size(75, 23);
            this.btnPisoTres.TabIndex = 5;
            this.btnPisoTres.Text = "3";
            this.btnPisoTres.UseVisualStyleBackColor = true;
            this.btnPisoTres.Click += new System.EventHandler(this.btnPisoTres_Click);
            // 
            // btnPisoSeis
            // 
            this.btnPisoSeis.Location = new System.Drawing.Point(482, 216);
            this.btnPisoSeis.Name = "btnPisoSeis";
            this.btnPisoSeis.Size = new System.Drawing.Size(75, 23);
            this.btnPisoSeis.TabIndex = 6;
            this.btnPisoSeis.Text = "6";
            this.btnPisoSeis.UseVisualStyleBackColor = true;
            this.btnPisoSeis.Click += new System.EventHandler(this.btnPisoSeis_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(312, 294);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 23);
            this.btnAbrir.TabIndex = 7;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(556, 294);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Estado: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 482);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.btnPisoSeis);
            this.Controls.Add(this.btnPisoTres);
            this.Controls.Add(this.btnPisoCinco);
            this.Controls.Add(this.btnPisoDos);
            this.Controls.Add(this.btnPisoCuatro);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.btnPisoUno);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPisoUno;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Button btnPisoCuatro;
        private System.Windows.Forms.Button btnPisoDos;
        private System.Windows.Forms.Button btnPisoCinco;
        private System.Windows.Forms.Button btnPisoTres;
        private System.Windows.Forms.Button btnPisoSeis;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label1;
    }
}

