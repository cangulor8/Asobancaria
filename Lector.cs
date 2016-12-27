using System;
using Asobancaria.Recaudo;
using FileHelpers;

namespace Asobancaria
{
    public class Lector
    {
        public static  Recaudo.Recaudo Leer(string path)
        {
            var engine = new MultiRecordEngine(typeof(RecaudoEncabezadoArchivo), typeof(RecaudoEncabezadoLote), typeof(RecaudoDetalle), typeof(RecaudoControlLote), typeof(RecaudoControlArchivo))
            {
                RecordSelector = CustomSelector
            };


            var rows = engine.ReadFile(path);


            var recaudo = new Recaudo.Recaudo();

            foreach (var row in rows)
            {
                if (row.GetType() == typeof(RecaudoEncabezadoArchivo))
                {
                    recaudo.RecaudoEncabezadoArchivo = (RecaudoEncabezadoArchivo)row;
                }
                else if (row.GetType() == typeof(RecaudoEncabezadoLote))
                {
                    recaudo.RecaudoEncabezadoLote.Add((RecaudoEncabezadoLote)row);
                }
                else if (row.GetType() == typeof(RecaudoDetalle))
                {
                    recaudo.RecaudoDetalle.Add((RecaudoDetalle)row);
                }
                else if (row.GetType() == typeof(RecaudoControlLote))
                {
                    recaudo.RecaudoControlLote.Add((RecaudoControlLote)row);
                }
                else if (row.GetType() == typeof(RecaudoControlArchivo))
                {
                    recaudo.RecaudoControlArchivo = (RecaudoControlArchivo)row;
                }
            }


            return recaudo;
        }

        private static Type CustomSelector(MultiRecordEngine engine, string recordLine)
        {
            //if (string.IsNullOrWhiteSpace(recordLine))
            //{
            //    return null;
            //}

            if (recordLine.StartsWith("01"))
                return typeof(RecaudoEncabezadoArchivo);
            if (recordLine.StartsWith("05"))
                return typeof(RecaudoEncabezadoLote);
            if (recordLine.StartsWith("06"))
                return typeof(RecaudoDetalle);
            if (recordLine.StartsWith("08"))
                return typeof(RecaudoControlLote);
            if (recordLine.StartsWith("09"))
                return typeof(RecaudoControlArchivo);

            return null;
        }
    }
}
