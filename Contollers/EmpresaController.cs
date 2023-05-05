using Prueba_Técnica.Context;
using Prueba_Técnica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Técnica.Contollers
{
    internal class EmpresaController
    {
        private readonly AplicationDbContext context;

        public EmpresaController(AplicationDbContext context)
        {
            this.context = context;
        }

        public Boolean GuardarEmpresa(Empresa empresa)
        {
            try
            {
                context.Add(empresa);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public Boolean Actualizar(Empresa empresa)
        {
            try
            {
                empresa.FechayHoraCreacion = obtenerEmpresa(empresa.Id).FechayHoraCreacion;
                context.SaveChanges();
                context.Update(empresa);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public IEnumerable<Empresa> ObtenerEmpresas()
        {
            
            return context.Empresas.AsEnumerable();
        }

        public IEnumerable<Empresa> Filtrar(string dato)
        {

            return context.Empresas.Where(x=>x.Nombre.Contains(dato)).AsEnumerable();
        }

        public Boolean EliminarEmpresa(int id)
        {
            try
            {
                var empresa = context.Empresas.Single(x=>x.Id==id);
                context.Empresas.Remove(empresa);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }

           
        }
        public Empresa obtenerEmpresa(int id)
        {
            return context.Empresas.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
