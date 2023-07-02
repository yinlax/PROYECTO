using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inscripcionesbol.modelo;
using Inscripcionesbol.Vista;

namespace Inscripcionesbol.controlador
{
    internal class EstudianteController
    {
        InscripcionesBoliviaEntities _db = new InscripcionesBoliviaEntities();
        public List<TEstudiante> listar()
        {
            return _db.TEstudiante.ToList();
        }
        public bool registrar(TEstudiante oEstudiante)
        {
            _db.TEstudiante.Add(oEstudiante);
            return _db.SaveChanges() > 0;
        }
        public List<TEstudiante> buscar(string param)
        {
            if (param.Trim().Equals(string.Empty))
            {
                return listar();
            }
            else
            {
                return _db.TEstudiante.Where(q => q.Ci_Estudiante.Contains(param)).ToList();
            }
        }
        
        public bool eliminar(int paramestu)
        {
            TEstudiante oFila = _db.TEstudiante.Find(paramestu);
            _db.TEstudiante.Remove(oFila);
            return _db.SaveChanges() > 0;

        }
        public bool modificar(int Idestu, TEstudiante paramestu)
        {
            TEstudiante oFila = _db.TEstudiante.Find(Idestu);
            oFila.Ci_Estudiante = paramestu.Ci_Estudiante;
            oFila.Apellido = paramestu.Apellido;
            oFila.Nombre = paramestu.Nombre;
            oFila.Genero = paramestu.Genero;
            oFila.Celular = paramestu.Celular;
            _db.Entry(oFila).State = System.Data.EntityState.Modified;
            return _db.SaveChanges() > 0;
        }
    }
}