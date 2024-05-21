namespace prySoftwareTeatroAguirre
{
    partial class frmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnQuenaken = new System.Windows.Forms.Button();
            this.btnOnas = new System.Windows.Forms.Button();
            this.btnTobas = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblLocal = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnTobas);
            this.panel1.Controls.Add(this.btnOnas);
            this.panel1.Controls.Add(this.btnQuenaken);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 509);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.GhostWhite;
            this.panel2.Controls.Add(this.lblDia);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(707, 509);
            this.panel2.TabIndex = 1;
            // 
            // btnQuenaken
            // 
            this.btnQuenaken.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnQuenaken.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuenaken.FlatAppearance.BorderSize = 0;
            this.btnQuenaken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuenaken.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuenaken.ForeColor = System.Drawing.Color.White;
            this.btnQuenaken.Location = new System.Drawing.Point(0, 143);
            this.btnQuenaken.Name = "btnQuenaken";
            this.btnQuenaken.Size = new System.Drawing.Size(200, 63);
            this.btnQuenaken.TabIndex = 0;
            this.btnQuenaken.Text = "LOCAL quenaken";
            this.btnQuenaken.UseVisualStyleBackColor = false;
            this.btnQuenaken.Click += new System.EventHandler(this.btnQuenaken_Click);
            // 
            // btnOnas
            // 
            this.btnOnas.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnOnas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOnas.FlatAppearance.BorderSize = 0;
            this.btnOnas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnas.ForeColor = System.Drawing.Color.White;
            this.btnOnas.Location = new System.Drawing.Point(0, 257);
            this.btnOnas.Name = "btnOnas";
            this.btnOnas.Size = new System.Drawing.Size(200, 63);
            this.btnOnas.TabIndex = 1;
            this.btnOnas.Text = "LOCAL onas";
            this.btnOnas.UseVisualStyleBackColor = false;
            this.btnOnas.Click += new System.EventHandler(this.btnOnas_Click);
            // 
            // btnTobas
            // 
            this.btnTobas.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnTobas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTobas.FlatAppearance.BorderSize = 0;
            this.btnTobas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTobas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTobas.ForeColor = System.Drawing.Color.White;
            this.btnTobas.Location = new System.Drawing.Point(0, 372);
            this.btnTobas.Name = "btnTobas";
            this.btnTobas.Size = new System.Drawing.Size(200, 63);
            this.btnTobas.TabIndex = 2;
            this.btnTobas.Text = "LOCAL tobas";
            this.btnTobas.UseVisualStyleBackColor = false;
            this.btnTobas.Click += new System.EventHandler(this.btnTobas_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(0, 468);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(200, 41);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblLocal);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 117);
            this.panel3.TabIndex = 4;
            // 
            // lblDia
            // 
            this.lblDia.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDia.Location = new System.Drawing.Point(166, 135);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(375, 216);
            this.lblDia.TabIndex = 0;
            // 
            // lblLocal
            // 
            this.lblLocal.BackColor = System.Drawing.Color.Transparent;
            this.lblLocal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocal.ForeColor = System.Drawing.Color.White;
            this.lblLocal.Location = new System.Drawing.Point(0, 23);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(200, 70);
            this.lblLocal.TabIndex = 0;
            this.lblLocal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(907, 509);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTobas;
        private System.Windows.Forms.Button btnOnas;
        private System.Windows.Forms.Button btnQuenaken;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblLocal;
    }
}

