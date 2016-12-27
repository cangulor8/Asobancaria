using System;
using FileHelpers;

namespace Asobancaria.Recaudo
{
    /// <summary>
    /// Encabezado del archivo
    /// </summary>
    [FixedLengthRecord()]
    public class RecaudoEncabezadoArchivo
    {
        [FieldFixedLength(2)]
        public int TipoRegistro;

        [FieldFixedLength(10)]
        public string NitEmpresaFacturadora;

        [FieldFixedLength(8)]
        [FieldConverter(ConverterKind.Date, "yyyyMMdd")]
        public DateTime FechaDelRecaudo;

        [FieldFixedLength(3)]
        public int CodigoEntidadFinancieraRecaudadora;

        [FieldFixedLength(17)]
        public int NumeroDeCuenta;

        [FieldFixedLength(8)]
        [FieldConverter(ConverterKind.Date, "yyyyMMdd")]
        public DateTime FechaDelArchivo;

        [FieldFixedLength(4)]
        public string HoraDeGrabacionDelArchivo;

        [FieldFixedLength(1)]
        public string ModificadorDeArchivo;

        [FieldFixedLength(2)]
        public int TipoDeCuenta;
    
        [FieldFixedLength(107)]
        [FieldOptional]
        public string Reservado;
    }
}
