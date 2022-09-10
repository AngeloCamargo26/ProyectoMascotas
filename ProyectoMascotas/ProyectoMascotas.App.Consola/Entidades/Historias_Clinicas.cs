using System;
namespace ProyectoMascotas.App.Dominio {
    public class HistoriasClinicas
    {
        public int Cod_Hist { get; set; }
        public int Fecha_Apertura { get; set; }
        public int Fecha_Cierre { get; set; }
        public string Observaciones { get; set; }
        public int Id_Masc { get; set; }
    }
}