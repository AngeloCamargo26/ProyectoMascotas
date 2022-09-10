//Directivas
using System;
using Microsoft.EntityFrameworkCore;

// Esta clase implementa la interfaz IRepositorioPropietario

/* Contiene interfaces y clases que definen colecciones genéricas,
que permiten a los usuarios crear colecciones fuertemente tipadas 
y brindan una mejor seguridad y rendimiento.
*/
using System.Collections.Generic;

// Hacer referencia a la capa de dominio para acceder a las entidades
using ProyectoMascotas.App.Dominio;

using ProyectoMascotas.App.Persistencia;

/* LINQ(Language Integrated Query)
Es un conjunto de instrucciones integradas en el lenguaje C#, que nos
permite trabajar de manera flexible y rápida con colecciones de datos.
*/
using System.Linq;

//trazabilidad y jerarquia con namespace
namespace ProyectoMascotas.App.Persistencia.AppRepositorios
{

    public class RepositorioPropietario : IRepositorioPropietario
    {
        private readonly AppContext _appContext;

        public RepositorioPropietario(AppContext appContext)
        {
            _appContext = appContext;
        }

        Propietario IRepositorioPropietario.AddPropietario(Propietario propietario)
        {
            var propietarioAdicionado = _appContext.propietarios.Add(propietario);
            _appContext.SaveChanges();
            return propietarioAdicionado.Entity;

        }
        Propietario IRepositorioPropietario.UpdatePropietario(Propietario propietario)
        {
            var propietarioActualizar = _appContext.propietarios.SingleOrDefault(r => r.id == propietario.id);
            if (propietarioActualizar != null)
            {
                propietarioActualizar.Id_Prop = propietario.Id_Prop;  // nombres iguales a las entidades?
                propietarioActualizar.Nombres_Prop = propietario.Nombres_Prop;
                propietarioActualizar.Apellidos_Prop = propietario.Apellidos_Prop;
                propietarioActualizar.Direccion_Prop = propietario.Direccion_Prop;
                propietarioActualizar.Telefono_Prop = propietario.Telefono_Prop;
                propietarioActualizar.CorreoElectronico_Prop = propietario.CorreoElectronico_Prop;
                _appContext.SaveChanges();
            }
            return propietarioActualizar;
        }

        void IRepositorioPropietario.DeletePropietario(int idPropietario)
        {
            var propietarioEncontrado = _appContext.propietarios.FirstOrDefault(c => c.id == idPropietario);
            if (propietarioEncontrado == null)
            {
                return;
            }
            _appContext.propietarios.Remove(propietarioEncontrado);
            _appContext.SaveChanges();

        }

        // IEnumerable - me permite retornar una lista de objetos

        IEnumerable<Propietario> IRepositorioPropietario.GetAllPropietarios()
        {
            return _appContext.propietarios;
        }

        Propietario IRepositorioPropietario.GetPropietario(int idPropietario)
        {
            return _appContext.propietarios.FirstOrDefault(c => c.id == idPropietario);
        }

    }
}