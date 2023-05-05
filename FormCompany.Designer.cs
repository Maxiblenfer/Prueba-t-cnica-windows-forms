namespace Prueba_Técnica
{
    partial class FormCompany
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            datagridempresa = new DataGridView();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            Codigo = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            Pais = new DataGridViewTextBoxColumn();
            fechac = new DataGridViewTextBoxColumn();
            fecham = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Código = new DataGridViewTextBoxColumn();
            Dirección = new DataGridViewTextBoxColumn();
            Teléfono = new DataGridViewTextBoxColumn();
            Ciudad = new DataGridViewTextBoxColumn();
            Departamento = new DataGridViewTextBoxColumn();
            País = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            btneliminar = new Button();
            button3 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            txtfiltrar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)datagridempresa).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(145, 48);
            button1.Name = "button1";
            button1.Size = new Size(204, 44);
            button1.TabIndex = 0;
            button1.Text = "Añadir empresa";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // datagridempresa
            // 
            datagridempresa.AllowUserToAddRows = false;
            datagridempresa.AllowUserToDeleteRows = false;
            datagridempresa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridempresa.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn9, ID, Codigo, Direccion, Telefono, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11, Pais, fechac, fecham });
            datagridempresa.Location = new Point(47, 261);
            datagridempresa.Name = "datagridempresa";
            datagridempresa.ReadOnly = true;
            datagridempresa.RowTemplate.Height = 25;
            datagridempresa.Size = new Size(1041, 150);
            datagridempresa.TabIndex = 1;
            datagridempresa.MultiSelectChanged += datagridempresa_MultiSelectChanged;
            datagridempresa.CellClick += datagridempresa_CellClick;
            datagridempresa.CellContentClick += dataGridView1_CellContentClick;
            datagridempresa.RowHeaderMouseClick += datagridempresa_RowHeaderMouseClick;
            datagridempresa.SelectionChanged += datagridempresa_SelectionChanged;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.HeaderText = "Nombre";
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Código";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            // 
            // Direccion
            // 
            Direccion.HeaderText = "Dirección";
            Direccion.Name = "Direccion";
            Direccion.ReadOnly = true;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Teléfono";
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.HeaderText = "Ciudad";
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.HeaderText = "Departamento";
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // Pais
            // 
            Pais.HeaderText = "País";
            Pais.Name = "Pais";
            Pais.ReadOnly = true;
            // 
            // fechac
            // 
            fechac.HeaderText = "Fecha de creación";
            fechac.Name = "fechac";
            fechac.ReadOnly = true;
            // 
            // fecham
            // 
            fecham.HeaderText = "Fecha de modificación";
            fecham.Name = "fecham";
            fecham.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Código
            // 
            Código.HeaderText = "Código";
            Código.Name = "Código";
            Código.ReadOnly = true;
            // 
            // Dirección
            // 
            Dirección.HeaderText = "Dircción";
            Dirección.Name = "Dirección";
            Dirección.ReadOnly = true;
            // 
            // Teléfono
            // 
            Teléfono.HeaderText = "Teléfono";
            Teléfono.Name = "Teléfono";
            Teléfono.ReadOnly = true;
            // 
            // Ciudad
            // 
            Ciudad.HeaderText = "Ciudad";
            Ciudad.Name = "Ciudad";
            Ciudad.ReadOnly = true;
            // 
            // Departamento
            // 
            Departamento.HeaderText = "Departamento";
            Departamento.Name = "Departamento";
            Departamento.ReadOnly = true;
            // 
            // País
            // 
            País.HeaderText = "País";
            País.Name = "País";
            País.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Código";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Dirección";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Teléfono";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Ciudad";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Departamento";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "País";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Nombre";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // btneliminar
            // 
            btneliminar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btneliminar.Location = new Point(47, 158);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(204, 44);
            btneliminar.TabIndex = 2;
            btneliminar.Text = "Eliminar empresa";
            btneliminar.UseVisualStyleBackColor = true;
            btneliminar.Click += btneliminar_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(257, 158);
            button3.Name = "button3";
            button3.Size = new Size(204, 44);
            button3.TabIndex = 4;
            button3.Text = "Editar empresa";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // txtfiltrar
            // 
            txtfiltrar.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            txtfiltrar.Location = new Point(47, 208);
            txtfiltrar.Multiline = true;
            txtfiltrar.Name = "txtfiltrar";
            txtfiltrar.Size = new Size(446, 47);
            txtfiltrar.TabIndex = 5;
            txtfiltrar.TextChanged += textBox1_TextChanged;
            // 
            // FormCompany
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOrange;
            ClientSize = new Size(1312, 577);
            Controls.Add(txtfiltrar);
            Controls.Add(button3);
            Controls.Add(btneliminar);
            Controls.Add(datagridempresa);
            Controls.Add(button1);
            Name = "FormCompany";
            Text = "FormCompany";
            ((System.ComponentModel.ISupportInitialize)datagridempresa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView datagridempresa;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Código;
        private DataGridViewTextBoxColumn Dirección;
        private DataGridViewTextBoxColumn Teléfono;
        private DataGridViewTextBoxColumn Ciudad;
        private DataGridViewTextBoxColumn Departamento;
        private DataGridViewTextBoxColumn País;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn Pais;
        private DataGridViewTextBoxColumn fechac;
        private DataGridViewTextBoxColumn fecham;
        private Button btneliminar;
        private Button button3;
        private System.Windows.Forms.Timer timer1;
        private TextBox txtfiltrar;
    }
}