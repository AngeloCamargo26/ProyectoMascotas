using System;
namespace ProyectoMascotas.App.Dominio
{

    public class Veterinario
    {
        public int Id_Vet { get; set; }
        public string Nombres_Vet { get; set; }
        public string Apellidos_Vet { get; set; }
        public string Direccion_Vet { get; set; }
        public string Telefono_Vet { get; set; }
        public int TarjetadePropiedad_Vet { get; set; }

    }

}