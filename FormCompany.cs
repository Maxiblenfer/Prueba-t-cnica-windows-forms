using Microsoft.IdentityModel.Tokens;
using Prueba_Técnica.Context;
using Prueba_Técnica.Contollers;

namespace Prueba_Técnica
{
    public partial class FormCompany : Form
    {
        EmpresaController controlador;
        int IDEMPRESA = 0;

        public FormCompany()
        {
            AplicationDbContext context = new AplicationDbContext();
            controlador = new EmpresaController(context);

            InitializeComponent();
            LlenarTabla();
            timer1.Enabled = true;
        }
        public string MesEnLetra(int mes)
        {
            if (mes == 1)
            {
                return "Enero";
            }
            else if (mes == 2)
            {
                return "Febrero";
            }
            else if (mes == 3)
            {
                return "Marzo";
            }
            else if (mes == 4)
            {
                return "Abril";
            }
            else if (mes == 5)
            {
                return "Mayo";
            }
            else if (mes == 6)
            {
                return "junio";
            }
            else if (mes == 7)
            {
                return "Julio";
            }
            else if (mes == 8)
            {
                return "Agosto";
            }
            else if (mes == 9)
            {
                return "Septiembre";
            }
            else if (mes == 10)
            {
                return "Octubre";
            }
            else if (mes == 11)
            {
                return "Noviembre";
            }
            else
            {
                return "Diciembre";
            }
        }

        public void LlenarTabla()
        {
            txtfiltrar.Text = "";
            timer1.Enabled = true;
            datagridempresa.DataSource = null;
            datagridempresa.Rows.Clear();
            int contador = -1;
            foreach (var empresa in controlador.ObtenerEmpresas())
            {

                contador = datagridempresa.Rows.Add();

                datagridempresa.Rows[contador].Cells[0].Value = empresa.Nombre;
                datagridempresa.Rows[contador].Cells[1].Value = empresa.Id;
                datagridempresa.Rows[contador].Cells[2].Value = empresa.Codigo;
                datagridempresa.Rows[contador].Cells[3].Value = empresa.Direccion;
                datagridempresa.Rows[contador].Cells[4].Value = empresa.Telefono;
                datagridempresa.Rows[contador].Cells[5].Value = empresa.Ciudad;
                datagridempresa.Rows[contador].Cells[6].Value = empresa.Departamento;
                datagridempresa.Rows[contador].Cells[7].Value = empresa.Pais;
                datagridempresa.Rows[contador].Cells[8].Value = $"{empresa.FechayHoraCreacion.Day} de {MesEnLetra(empresa.FechayHoraCreacion.Month)} del {empresa.FechayHoraCreacion.Year}";
                datagridempresa.Rows[contador].Cells[9].Value = $"{empresa.FechayHoraModificacion.Day} de {MesEnLetra(empresa.FechayHoraModificacion.Month)} del {empresa.FechayHoraModificacion.Year}, a las {empresa.FechayHoraModificacion.Hour}:{empresa.FechayHoraModificacion.Minute}:{empresa.FechayHoraModificacion.Second}";
                contador++;

            }
        }

        public void Filtrar(string dato)
        {
            timer1.Enabled = false;
            datagridempresa.DataSource = null;
            datagridempresa.Rows.Clear();
            int contador = -1;
            foreach (var empresa in controlador.Filtrar(dato))
            {

                contador = datagridempresa.Rows.Add();

                datagridempresa.Rows[contador].Cells[0].Value = empresa.Nombre;
                datagridempresa.Rows[contador].Cells[1].Value = empresa.Id;
                datagridempresa.Rows[contador].Cells[2].Value = empresa.Codigo;
                datagridempresa.Rows[contador].Cells[3].Value = empresa.Direccion;
                datagridempresa.Rows[contador].Cells[4].Value = empresa.Telefono;
                datagridempresa.Rows[contador].Cells[5].Value = empresa.Ciudad;
                datagridempresa.Rows[contador].Cells[6].Value = empresa.Departamento;
                datagridempresa.Rows[contador].Cells[7].Value = empresa.Pais;
                datagridempresa.Rows[contador].Cells[8].Value = $"{empresa.FechayHoraCreacion.Day} de {MesEnLetra(empresa.FechayHoraCreacion.Month)} del {empresa.FechayHoraCreacion.Year}";
                datagridempresa.Rows[contador].Cells[9].Value = $"{empresa.FechayHoraModificacion.Day} de {MesEnLetra(empresa.FechayHoraModificacion.Month)} del {empresa.FechayHoraModificacion.Year}, a las {empresa.FechayHoraModificacion.Hour}:{empresa.FechayHoraModificacion.Minute}:{empresa.FechayHoraModificacion.Second}";
                contador++;

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormCompanyEditor form = new FormCompanyEditor();
            form.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void datagridempresa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            timer1.Enabled = false;
            if (e != null && e.RowIndex >= 0)
            {
                try
                {
                    IDEMPRESA = (int)datagridempresa.Rows[e.RowIndex].Cells[1].Value;
                }
                catch (Exception)
                {


                }

            }
        }

        private void datagridempresa_MultiSelectChanged(object sender, EventArgs e)
        {

        }

        private void datagridempresa_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void datagridempresa_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            if (IDEMPRESA != 0)
            {
                if (controlador.EliminarEmpresa(IDEMPRESA))
                {
                    MessageBox.Show("La empresa se ha removido exitosamente", "Empresa removida", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    LlenarTabla();
                }
                else
                {
                    MessageBox.Show("Se ha producido un error al eliminar la empresa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LlenarTabla();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            if (IDEMPRESA != 0)
            {
                var empresa = controlador.obtenerEmpresa(IDEMPRESA);
                if (empresa != null)
                {
                    FormCompanyEditor form = new FormCompanyEditor();
                    AddOwnedForm(form);
                    form.txtciudad.Text = empresa.Ciudad;
                    form.txtnombre.Text = empresa.Nombre;
                    form.txtcodigo.Text = empresa.Codigo.ToString();
                    form.txtdireccion.Text = empresa.Direccion;
                    form.txttelefono.Text = empresa.Telefono;
                    form.txtdepartamento.Text = empresa.Departamento;
                    form.txtpais.Text = empresa.Pais;
                    form.accion = 2;
                    form.labelnombre.Text = "Editar empresa";
                    form.btncrear.Text = "Editar empresa";
                    form.idempresa = empresa.Id;
                    form.Show();

                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtfiltrar.Text.IsNullOrEmpty())
            {
                LlenarTabla();
            }
            else
            {
                Filtrar(txtfiltrar.Text);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LlenarTabla();
            timer1.Enabled = true;
            timer1.Start();
        }
    }
}
