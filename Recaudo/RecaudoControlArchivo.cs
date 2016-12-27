using FileHelpers;

namespace Asobancaria.Recaudo
{
    /// <summary>
    /// Summary description for FA_RecaudoRegistroControlArchivo
    /// </summary>

    [FixedLengthRecord()]
    public class RecaudoControlArchivo
    {
        [FieldFixedLength(2)]
        public int TipoRegistro;

        [FieldFixedLength(9)]
        public int TotalRegistrosRecaudadosEnArchivo;

        [FieldFixedLength(18)]
        public long ValorTotalRecaudadoEnArchivo;

        [FieldFixedLength(133)]
        [FieldOptional]
        public string Reservado;
    }
}
