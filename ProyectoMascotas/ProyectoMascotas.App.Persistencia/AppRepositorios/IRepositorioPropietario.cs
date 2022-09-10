//Directivas
using System;
using System.Collections.Generic;
using System.Linq;
using ProyectoMascotas.App.Dominio;
using ProyectoMascotas.App.Persistencia;

namespace ProyectoMascotas.App.Persistencia
{
    public interface IRepositorioPropietario
    {
        // Implementar la firma de los métodos del CRUD
        Propietario AddPropietario(Propietario propietario);
        Propietario UpdatePropietario(Propietario propietario);

        void DeletePropietario(int idPropietario);

        // IEnumerable - me permite retornar una lista de objetos

        IEnumerable<Propietario> GetAllPropietarios();

        Propietario GetPropietario(int idPropietario);
    }
}