using FileHelpers;

namespace Asobancaria.Factura
{
    [FixedLengthRecord()]
    public class FacturaControlLote
    {

        [FieldFixedLength(2)]
        public string TipoRegistro;

        [FieldFixedLength(9)]
        public string TotRegistrosdelLote;

        [FieldFixedLength(18)]
        public string ValordeServicioPrincipal;

        [FieldFixedLength(18)]
        public string ValordeServicioAdicional;

        [FieldFixedLength(4)]
        public string NumerodeLote;

        [FieldFixedLength(169)]
        [FieldOptional]
        public string Reservado;

    }
}
