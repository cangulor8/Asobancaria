using System.Collections.Generic;

namespace Asobancaria.Recaudo
{
    public class Recaudo
    {
        public Recaudo()
        {
            RecaudoEncabezadoLote = new List<RecaudoEncabezadoLote>();
            RecaudoDetalle = new List<RecaudoDetalle>();
            RecaudoControlLote = new List<RecaudoControlLote>();
        }

        public RecaudoEncabezadoArchivo RecaudoEncabezadoArchivo { get; set; }
        public List<RecaudoEncabezadoLote> RecaudoEncabezadoLote { get; set; }
        public List<RecaudoDetalle> RecaudoDetalle { get; set; }
        public List<RecaudoControlLote> RecaudoControlLote { get; set; }
        public RecaudoControlArchivo RecaudoControlArchivo { get; set; }
    }
}
