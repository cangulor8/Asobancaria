using FileHelpers;

namespace Asobancaria.Recaudo
{
    [FixedLengthRecord()]
    public class RecaudoControlLote
    {

        [FieldFixedLength(2)]
        public int TipoRegistro;

        [FieldFixedLength(9)]
        public int TotalRegistrosEnLote;

        [FieldFixedLength(18)]
        public long ValorTotalRecaudadoEnLote;

        [FieldFixedLength(4)]
        public int NumeroDeLote;

        [FieldFixedLength(129)]
        [FieldOptional]
        public string Reservado;

    }
}
