using FileHelpers;

namespace Asobancaria.Recaudo
{
    /// <summary>
    /// Summary description for FA_RecaudoEncabezadoLote
    /// </summary>
    [FixedLengthRecord()]
    public class RecaudoEncabezadoLote
    {
        [FieldFixedLength(2)]
        public int TipoRegistro;

        [FieldFixedLength(13)]
        public string CodigoDelServicioRecaudado;

        [FieldFixedLength(4)]
        public int NumeroDeLote;

        [FieldFixedLength(143)]
        [FieldOptional]
        public string Reservado;
    }
}
