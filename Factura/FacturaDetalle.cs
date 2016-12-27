using FileHelpers;

namespace Asobancaria.Factura
{
    [FixedLengthRecord()]
    public sealed class FacturaDetalle
    {

        [FieldFixedLength(2)]
        [FieldAlign(AlignMode.Left, '0')]
        public string TipoRegistro;

        [FieldFixedLength(48)]
        [FieldAlign(AlignMode.Left, '0')]
        public string ReferenciaPrincipalUsuario;

        [FieldFixedLength(30)]
        [FieldAlign(AlignMode.Right, ' ')]
        public string ReferenciaSecundarialUsuario;

        [FieldFixedLength(2)]
        [FieldAlign(AlignMode.Left, '0')]
        public string PeriodosFacturados;

        [FieldFixedLength(3)]
        [FieldAlign(AlignMode.Right, ' ')]
        public string Ciclo;

        [FieldFixedLength(14)]
        [FieldAlign(AlignMode.Left, '0')]
        public string ValordeServicioPrincipal;

        [FieldFixedLength(13)]
        [FieldAlign(AlignMode.Right, ' ')]
        public string CodigoDelServicioFacturadoPorEmpresaAdicional;

        [FieldFixedLength(14)]
        [FieldAlign(AlignMode.Left, '0')]
        public string ValordeServicioAdicional;


        [FieldFixedLength(8)]
        [FieldAlign(AlignMode.Left, '0')]
        public string FechaDeVencimiento;

        [FieldFixedLength(8)]
        [FieldAlign(AlignMode.Left, '0')]
        public string IdentificacionEfr;

        [FieldFixedLength(17)]
        [FieldAlign(AlignMode.Right, ' ')]
        public string NoCuentadelclientereceptor;

        [FieldFixedLength(2)]
        [FieldAlign(AlignMode.Left, '0')]
        public string TipodeCuentadelClienteReceptor;

        [FieldFixedLength(10)]
        [FieldAlign(AlignMode.Right, ' ')]
        public string NoIdentificaciondelcliente;

        [FieldFixedLength(22)]
        [FieldAlign(AlignMode.Right, ' ')]
        public string NombredelClienteReceptor;


        [FieldFixedLength(3)]
        [FieldAlign(AlignMode.Left, '0')]
        public string CodigodelaEntidadFinancieraOriginadora;

        [FieldFixedLength(24)]
        [FieldOptional]
        [FieldAlign(AlignMode.Right, ' ')]
        public string Reservado;


    }
}

