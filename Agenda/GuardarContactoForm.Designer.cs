namespace Agenda
{
    partial class GuardarContactoForm
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
            label1 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            label2 = new Label();
            label3 = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            txtTelefono = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 21);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(170, 18);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(170, 67);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(200, 23);
            txtApellido.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 70);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 2;
            label2.Text = "Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 123);
            label3.Name = "label3";
            label3.Size = new Size(122, 15);
            label3.TabIndex = 4;
            label3.Text = "Fecha de Nacimiento:";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(170, 117);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(200, 23);
            dtpFechaNacimiento.TabIndex = 5;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(170, 170);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(200, 23);
            txtTelefono.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 173);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 6;
            label4.Text = "Teléfono:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(170, 220);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 23);
            txtEmail.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 223);
            label5.Name = "label5";
            label5.Size = new Size(108, 15);
            label5.TabIndex = 8;
            label5.Text = "Correo Electrónico:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(295, 269);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // GuardarContactoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 313);
            Controls.Add(btnGuardar);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(txtTelefono);
            Controls.Add(label4);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(label3);
            Controls.Add(txtApellido);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "GuardarContactoForm";
            Text = "GuardarContactoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpFechaNacimiento;
        private TextBox txtTelefono;
        private Label label4;
        private TextBox txtEmail;
        private Label label5;
        private Button btnGuardar;
    }
}