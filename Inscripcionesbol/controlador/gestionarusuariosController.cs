using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inscripcionesbol.modelo;
using Inscripcionesbol.Vista;
//git
namespace Inscripcionesbol.controlador
{
    internal class gestionarusuariosController
    {
        InscripcionesBoliviaEntities _db = new InscripcionesBoliviaEntities();
        public List<TUsuario> listar()
        {
            return _db.TUsuario.ToList();
        }
        public bool registrar(TUsuario oUsuario)
        {
            _db.TUsuario.Add(oUsuario);
            return _db.SaveChanges() > 0;
        }
        public bool eliminar(int paramusu)
        {
            TUsuario oFila = _db.TUsuario.Find(paramusu);
            _db.TUsuario.Remove(oFila);
            return _db.SaveChanges() > 0;

        }
        public bool modificar(int Idusu, TUsuario paramusu)
        {
            TUsuario oFila = _db.TUsuario.Find(Idusu);
            oFila.Cuenta = paramusu.Cuenta;
            oFila.Password = paramusu.Password;
            oFila.Nombre = paramusu.Nombre;
            oFila.Genero = paramusu.Genero;
            oFila.Rol = paramusu.Rol;
            _db.Entry(oFila).State = System.Data.EntityState.Modified;
            return _db.SaveChanges() > 0;
        }
    }
}
