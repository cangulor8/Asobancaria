using FileHelpers;

namespace Asobancaria.Factura
{
    /// <summary>
    /// Summary description for FA_RecaudoRegistroControlArchivo
    /// </summary>

    [FixedLengthRecord()]
    public class FacturaControlArchivo
    {
        [FieldFixedLength(2)]
        public string TipoRegistro;

        [FieldFixedLength(9)]
        public string TotalRegistrosDeDetalle;

        [FieldFixedLength(18)]
        public string ValorTotalDeServicioPrincipal;

        [FieldFixedLength(18)]
        public string ValorTotalDeServicioAdicional;

        [FieldFixedLength(173)]
        [FieldOptional]
        public string Reservado;
    }
}
