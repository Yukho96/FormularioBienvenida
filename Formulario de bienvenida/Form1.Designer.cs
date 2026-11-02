namespace Formulario_de_bienvenida
{
    partial class FormularioBienvenida
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
            lblNombre = new Label();
            lblEdad = new Label();
            lblResultado = new Label();
            txtNombre = new TextBox();
            txtEdad = new TextBox();
            btnAceptar = new Button();
            btnLimpiar = new Button();
            lblAvisoEdad = new Label();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(42, 132);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(59, 159);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(36, 15);
            lblEdad.TabIndex = 1;
            lblEdad.Text = "Edad:";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(308, 349);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(150, 15);
            lblResultado.TabIndex = 2;
            lblResultado.Text = "Aquí aparecerá el resultado";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(102, 124);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(188, 23);
            txtNombre.TabIndex = 3;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(101, 156);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(189, 23);
            txtEdad.TabIndex = 4;
            txtEdad.TextChanged += txtEdad_TextChanged;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(383, 263);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 5;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(302, 263);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblAvisoEdad
            // 
            lblAvisoEdad.AutoSize = true;
            lblAvisoEdad.ForeColor = Color.Red;
            lblAvisoEdad.Location = new Point(102, 182);
            lblAvisoEdad.Name = "lblAvisoEdad";
            lblAvisoEdad.Size = new Size(0, 15);
            lblAvisoEdad.TabIndex = 7;
            // 
            // FormularioBienvenida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblAvisoEdad);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAceptar);
            Controls.Add(txtEdad);
            Controls.Add(txtNombre);
            Controls.Add(lblResultado);
            Controls.Add(lblEdad);
            Controls.Add(lblNombre);
            Name = "FormularioBienvenida";
            Text = "Formulario de bienvenida";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblEdad;
        private Label lblResultado;
        private TextBox txtNombre;
        private TextBox txtEdad;
        private Button btnAceptar;
        private Button btnLimpiar;
        private Label lblAvisoEdad;
    }
}
