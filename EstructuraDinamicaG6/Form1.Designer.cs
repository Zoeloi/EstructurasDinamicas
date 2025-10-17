namespace EstructuraDinamicaG6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tbEdad = new TextBox();
            btnAgregar = new Button();
            lblEdades = new Label();
            btnSacar = new Button();
            btnMostrar = new Button();
            btnOrdenar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 26);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 0;
            label1.Text = "Edad:";
            // 
            // tbEdad
            // 
            tbEdad.Location = new Point(91, 23);
            tbEdad.Name = "tbEdad";
            tbEdad.Size = new Size(186, 27);
            tbEdad.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(311, 12);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(160, 75);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += button1_Click;
            // 
            // lblEdades
            // 
            lblEdades.AutoSize = true;
            lblEdades.Location = new Point(28, 166);
            lblEdades.Name = "lblEdades";
            lblEdades.Size = new Size(57, 20);
            lblEdades.TabIndex = 3;
            lblEdades.Text = "edades";
            // 
            // btnSacar
            // 
            btnSacar.Location = new Point(505, 12);
            btnSacar.Name = "btnSacar";
            btnSacar.Size = new Size(139, 75);
            btnSacar.TabIndex = 4;
            btnSacar.Text = "Sacar";
            btnSacar.UseVisualStyleBackColor = true;
            btnSacar.Click += btnSacar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(675, 12);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(132, 75);
            btnMostrar.TabIndex = 5;
            btnMostrar.Text = "Mostrar Ultimo";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnOrdenar
            // 
            btnOrdenar.Location = new Point(832, 12);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(110, 75);
            btnOrdenar.TabIndex = 6;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 450);
            Controls.Add(btnOrdenar);
            Controls.Add(btnMostrar);
            Controls.Add(btnSacar);
            Controls.Add(lblEdades);
            Controls.Add(btnAgregar);
            Controls.Add(tbEdad);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbEdad;
        private Button btnAgregar;
        private Label lblEdades;
        private Button btnSacar;
        private Button btnMostrar;
        private Button btnOrdenar;
    }
}
