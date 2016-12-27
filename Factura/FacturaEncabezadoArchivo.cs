using FileHelpers;

namespace Asobancaria.Factura
{
    /// <summary>
    /// Summary description for FA_RecaudoEncabezadoArchivo
    /// </summary>

    [FixedLengthRecord()]
    public class FacturaEncabezadoArchivo
    {
        [FieldFixedLength(2)]
        [FieldAlign(AlignMode.Left, '0')]
        public string TipoRegistro;

        [FieldFixedLength(10)]
        [FieldAlign(AlignMode.Left, '0')]

        public string NitEmpresaFacturadora;

        [FieldFixedLength(10)]
        [FieldAlign(AlignMode.Left, '0')]
        public string NitEmpresaFacturadoraAdicional;

        [FieldFixedLength(3)]
        [FieldAlign(AlignMode.Left, '0')]
        public string CodigoEntidadFinancieraRecaudadora;

        [FieldFixedLength(8)]
        [FieldAlign(AlignMode.Left, '0')]
        public string FechaDelArchivo;

        [FieldFixedLength(4)]
        [FieldAlign(AlignMode.Left, '0')]
        public string HoraDeGrabacionDelArchivo;

        [FieldFixedLength(1)]
        [FieldAlign(AlignMode.Right, ' ')]
        public string ModificadorDeArchivo;

        [FieldFixedLength(182)]
        [FieldAlign(AlignMode.Right, ' ')]
        [FieldOptional]
        public string EaReservado;
    }
}
