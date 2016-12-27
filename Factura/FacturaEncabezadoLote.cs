using FileHelpers;

namespace Asobancaria.Factura
{
    /// <summary>
    /// Summary description for FA_RecaudoEncabezadoLote
    /// </summary>
    [FixedLengthRecord()]
    public class FacturaEncabezadoLote
    {
        [FieldFixedLength(2)]
        [FieldAlign(AlignMode.Left, '0')]
        public string TipoRegistro;

        [FieldFixedLength(13)]
        [FieldAlign(AlignMode.Left, '0')]
        public string CodigoDelServicioRecaudado;

        [FieldFixedLength(4)]
        [FieldAlign(AlignMode.Left, '0')]
  
        public string NumeroDeLote;

        [FieldFixedLength(15)]
        [FieldAlign(AlignMode.Right, ' ')]
        public string DescripciondelServicioFacturado;

        [FieldFixedLength(186)]
        [FieldAlign(AlignMode.Right, ' ')]
        [FieldOptional]
        public string Reservado;
    }
}
