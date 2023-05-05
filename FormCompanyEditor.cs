using Microsoft.IdentityModel.Tokens;
using Prueba_Técnica.Context;
using Prueba_Técnica.Contollers;
using Prueba_Técnica.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_Técnica
{
    public partial class FormCompanyEditor : Form
    {
        public int accion = 0;
        public int idempresa = 0;
        public FormCompanyEditor()
        {
            InitializeComponent();
        }

        private void FormCompanyEditor_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            if (accion != 2)
            {
                var context = new AplicationDbContext();
                var controlador = new EmpresaController(context);
                var empresa = new Empresa();
                empresa.Nombre = txtnombre.Text.Trim();
                try
                {
                    empresa.Codigo = int.Parse(txtcodigo.Text);

                }
                catch (Exception)
                {
                    MessageBox.Show("Escriba un número válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
                empresa.Direccion = txtdireccion.Text.Trim();
                if (txtdireccion.Text.IsNullOrEmpty())
                {
                    MessageBox.Show("La dirección es requerida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                empresa.Telefono = txttelefono.Text.Trim();
                if (txttelefono.Text.IsNullOrEmpty())
                {
                    MessageBox.Show("El teléfono es requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                empresa.Ciudad = txtciudad.Text.Trim();
                if (txtciudad.Text.IsNullOrEmpty())
                {
                    MessageBox.Show("La ciudad es requerida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                empresa.Departamento = txtdepartamento.Text.Trim();
                if (txtdireccion.Text.IsNullOrEmpty())
                {
                    MessageBox.Show("El departamento es requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                empresa.Pais = txtpais.Text.Trim();
                if (txtdireccion.Text.IsNullOrEmpty())
                {
                    MessageBox.Show("El país es requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                empresa.FechayHoraCreacion = DateTime.Now;
                empresa.FechayHoraModificacion = DateTime.Now;
                if (controlador.GuardarEmpresa(empresa))
                {
                    MessageBox.Show("Empresa registrada exitosamente", "Registo exitoso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtnombre.Text = "";
                    txtcodigo.Text = "";
                    txtdireccion.Text = "";
                    txttelefono.Text = "";
                    txtciudad.Text = "";
                    txtdepartamento.Text = "";
                    txtpais.Text = "";

                }
                else
                {
                    MessageBox.Show("Se ha producido un error al registrar la empresa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                var context = new AplicationDbContext();
                var controlador = new EmpresaController(context);
                var empresa = new Empresa();
                empresa.Nombre = txtnombre.Text.Trim();
                try
                {
                    empresa.Codigo = int.Parse(txtcodigo.Text);

                }
                catch (Exception)
                {
                    MessageBox.Show("Escriba un número válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
                empresa.Direccion = txtdireccion.Text.Trim();
                if (txtdireccion.Text.IsNullOrEmpty())
                {
                    MessageBox.Show("La dirección es requerida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                empresa.Telefono = txttelefono.Text.Trim();
                if (txttelefono.Text.IsNullOrEmpty())
                {
                    MessageBox.Show("El teléfono es requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                empresa.Ciudad = txtciudad.Text.Trim();
                if (txtciudad.Text.IsNullOrEmpty())
                {
                    MessageBox.Show("La ciudad es requerida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                empresa.Departamento = txtdepartamento.Text.Trim();
                if (txtdireccion.Text.IsNullOrEmpty())
                {
                    MessageBox.Show("El departamento es requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                empresa.Pais = txtpais.Text.Trim();
                if (txtdireccion.Text.IsNullOrEmpty())
                {
                    MessageBox.Show("El país es requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                empresa.FechayHoraModificacion = DateTime.Now;
                empresa.Id = idempresa;
                empresa.FechayHoraCreacion = controlador.obtenerEmpresa(empresa.Id).FechayHoraCreacion;
             
                if (controlador.Actualizar(empresa))
                {
                    MessageBox.Show("Empresa actualizada exitosamente", "Actualziación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtnombre.Text = "";
                    txtcodigo.Text = "";
                    txtdireccion.Text = "";
                    txttelefono.Text = "";
                    txtciudad.Text = "";
                    txtdepartamento.Text = "";
                    txtpais.Text = "";

                }
                else
                {
                    MessageBox.Show("Se ha producido un error al actualizar la empresa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
