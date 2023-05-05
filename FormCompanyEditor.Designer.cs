namespace Prueba_Técnica
{
    partial class FormCompanyEditor
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
            labelnombre = new Label();
            txtnombre = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtcodigo = new TextBox();
            label4 = new Label();
            txtdireccion = new TextBox();
            label5 = new Label();
            txttelefono = new TextBox();
            label6 = new Label();
            txtciudad = new TextBox();
            label7 = new Label();
            txtdepartamento = new TextBox();
            label8 = new Label();
            txtpais = new TextBox();
            btncrear = new Button();
            SuspendLayout();
            // 
            // labelnombre
            // 
            labelnombre.AutoSize = true;
            labelnombre.Font = new Font("Segoe UI", 29F, FontStyle.Regular, GraphicsUnit.Point);
            labelnombre.Location = new Point(358, 29);
            labelnombre.Name = "labelnombre";
            labelnombre.Size = new Size(294, 52);
            labelnombre.TabIndex = 0;
            labelnombre.Text = "Añadir Empresa";
            labelnombre.Click += label1_Click;
            // 
            // txtnombre
            // 
            txtnombre.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtnombre.Location = new Point(165, 156);
            txtnombre.Multiline = true;
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(225, 36);
            txtnombre.TabIndex = 1;
            txtnombre.TextChanged += txtnombre_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(54, 154);
            label2.Name = "label2";
            label2.Size = new Size(109, 36);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(66, 209);
            label3.Name = "label3";
            label3.Size = new Size(97, 36);
            label3.TabIndex = 4;
            label3.Text = "Código";
            // 
            // txtcodigo
            // 
            txtcodigo.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtcodigo.Location = new Point(165, 211);
            txtcodigo.Multiline = true;
            txtcodigo.Name = "txtcodigo";
            txtcodigo.Size = new Size(225, 36);
            txtcodigo.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(41, 271);
            label4.Name = "label4";
            label4.Size = new Size(122, 36);
            label4.TabIndex = 6;
            label4.Text = "Dirección";
            // 
            // txtdireccion
            // 
            txtdireccion.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtdireccion.Location = new Point(165, 273);
            txtdireccion.Multiline = true;
            txtdireccion.Name = "txtdireccion";
            txtdireccion.Size = new Size(225, 36);
            txtdireccion.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(50, 325);
            label5.Name = "label5";
            label5.Size = new Size(113, 36);
            label5.TabIndex = 8;
            label5.Text = "Teléfono";
            // 
            // txttelefono
            // 
            txttelefono.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txttelefono.Location = new Point(165, 329);
            txttelefono.Multiline = true;
            txttelefono.Name = "txttelefono";
            txttelefono.Size = new Size(225, 36);
            txttelefono.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(514, 209);
            label6.Name = "label6";
            label6.Size = new Size(95, 36);
            label6.TabIndex = 10;
            label6.Text = "Ciudad";
            // 
            // txtciudad
            // 
            txtciudad.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtciudad.Location = new Point(617, 211);
            txtciudad.Multiline = true;
            txtciudad.Name = "txtciudad";
            txtciudad.Size = new Size(225, 36);
            txtciudad.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(430, 154);
            label7.Name = "label7";
            label7.Size = new Size(181, 36);
            label7.TabIndex = 12;
            label7.Text = "Departamento";
            // 
            // txtdepartamento
            // 
            txtdepartamento.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtdepartamento.Location = new Point(617, 156);
            txtdepartamento.Multiline = true;
            txtdepartamento.Name = "txtdepartamento";
            txtdepartamento.Size = new Size(225, 36);
            txtdepartamento.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(552, 271);
            label8.Name = "label8";
            label8.Size = new Size(59, 36);
            label8.TabIndex = 14;
            label8.Text = "País";
            // 
            // txtpais
            // 
            txtpais.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtpais.Location = new Point(617, 273);
            txtpais.Multiline = true;
            txtpais.Name = "txtpais";
            txtpais.Size = new Size(225, 36);
            txtpais.TabIndex = 13;
            txtpais.TextChanged += textBox1_TextChanged;
            // 
            // btncrear
            // 
            btncrear.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btncrear.Location = new Point(381, 412);
            btncrear.Name = "btncrear";
            btncrear.Size = new Size(165, 47);
            btncrear.TabIndex = 15;
            btncrear.Text = "Añadir empresa";
            btncrear.UseVisualStyleBackColor = true;
            btncrear.Click += btncrear_Click;
            // 
            // FormCompanyEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Orange;
            ClientSize = new Size(1014, 655);
            Controls.Add(btncrear);
            Controls.Add(label8);
            Controls.Add(txtpais);
            Controls.Add(label7);
            Controls.Add(txtdepartamento);
            Controls.Add(label6);
            Controls.Add(txtciudad);
            Controls.Add(label5);
            Controls.Add(txttelefono);
            Controls.Add(label4);
            Controls.Add(txtdireccion);
            Controls.Add(label3);
            Controls.Add(txtcodigo);
            Controls.Add(label2);
            Controls.Add(txtnombre);
            Controls.Add(labelnombre);
            Name = "FormCompanyEditor";
            Text = "FormCompanyEditor";
            Load += FormCompanyEditor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        public Label labelnombre;
        public TextBox txtnombre;
        public TextBox txtcodigo;
        public TextBox txtdireccion;
        public TextBox txttelefono;
        public TextBox txtciudad;
        public TextBox txtdepartamento;
        public TextBox txtpais;
        public Button btncrear;
    }
}