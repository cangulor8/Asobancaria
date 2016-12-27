using FileHelpers;

namespace Asobancaria.Recaudo
{
    [FixedLengthRecord()]
    public class RecaudoDetalle
    {
        [FieldFixedLength(2)]
        public int TipoRegistro;

        [FieldFixedLength(48)]
        public string ReferenciaPrincipalUsuario;

        [FieldFixedLength(14)]
        public long ValorRecaudado;

        [FieldFixedLength(2)]
        public int ProcedenciaPago;

        [FieldFixedLength(2)]
        public int MediosPago;

        [FieldFixedLength(6)]
        public int NoOperacion;

        [FieldFixedLength(6)]
        public int NoAutorizacion;

        [FieldFixedLength(3)]
        public int CodigoEntidadFinancieraDebitada;

        [FieldFixedLength(4)]
        public int CodigoSucursal;

        [FieldFixedLength(7)]
        public int Secuencia;

        [FieldFixedLength(3)]
        [FieldOptional]
        public string CausalDevolucion;

        [FieldFixedLength(65)]
        [FieldOptional]
        public string Reservado;

    }
}
