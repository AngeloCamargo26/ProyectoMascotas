using System;
namespace ProyectoMascotas.App.Dominio
{

    public class Visitas
    {
        public int Cod_Vist { get; set; }
        public int Fecha_Ingreso { get; set; }
        public int Fecha_Salida { get; set; }
        public string Recomendaciones { get; set; }
        public string Diagnostico { get; set; }
        public int Temperatura { get; set; }
        public int Peso { get; set; }
        public string Frecuencia_Respiratoria { get; set; }
        public string Frecuencia_Cardiaca { get; set; }
        public string Estado_animo { get; set; }
        public int Cod_Hist { get; set; }
        public int Id_Vet { get; set; }
    }

}