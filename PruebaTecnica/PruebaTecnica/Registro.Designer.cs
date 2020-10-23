namespace PruebaTecnica
{
    partial class Registro
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
            this.TexNombres = new System.Windows.Forms.TextBox();
            this.TexApellidos = new System.Windows.Forms.TextBox();
            this.TexDireccion = new System.Windows.Forms.TextBox();
            this.Guardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Direccion";
            // 
            // TexNombres
            // 
            this.TexNombres.Location = new System.Drawing.Point(74, 32);
            this.TexNombres.Name = "TexNombres";
            this.TexNombres.Size = new System.Drawing.Size(100, 20);
            this.TexNombres.TabIndex = 3;
            // 
            // TexApellidos
            // 
            this.TexApellidos.Location = new System.Drawing.Point(74, 67);
            this.TexApellidos.Name = "TexApellidos";
            this.TexApellidos.Size = new System.Drawing.Size(100, 20);
            this.TexApellidos.TabIndex = 4;
            // 
            // TexDireccion
            // 
            this.TexDireccion.Location = new System.Drawing.Point(74, 108);
            this.TexDireccion.Name = "TexDireccion";
            this.TexDireccion.Size = new System.Drawing.Size(100, 20);
            this.TexDireccion.TabIndex = 5;
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(53, 150);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 7;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 201);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.TexDireccion);
            this.Controls.Add(this.TexApellidos);
            this.Controls.Add(this.TexNombres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TexNombres;
        private System.Windows.Forms.TextBox TexApellidos;
        private System.Windows.Forms.TextBox TexDireccion;
        private System.Windows.Forms.Button Guardar;
    }
}