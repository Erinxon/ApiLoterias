using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiLoteria.AppSetting;
using ApiLoteria.Models;
using HtmlAgilityPack;

namespace ApiLoteria
{
    public static class Handle
    {
        private static string[] ConvertHtmlNodeToArrayString(this HtmlNodeCollection htmlNodes, int posicion)
        {
            var numeros = htmlNodes[posicion].SelectNodes(@"span")
                    .Select(x => x.InnerText.Replace("\n", "").Replace(" ", ""))
                    .ToArray();
            return numeros;
        }

        private static string ConvertHtmlNodeToString(this HtmlNodeCollection htmlNodes, int posicion)
        {
            var titulo = htmlNodes[posicion].InnerText.Replace(" ", "").Replace("\n", "");
            return titulo;
        }

        public static TipoConcurso GetTipoConcurso(HtmlDocument htmlDoc, 
            XPathExpression _xPath, int posicion)
        {
            var nacionalTitulo = htmlDoc.DocumentNode
                .SelectNodes(_xPath.XPATHTitulo);
            var nacionalFechas = htmlDoc.DocumentNode
            .SelectNodes(_xPath.XPATHFecha);
            var nacionalNumeros = htmlDoc.DocumentNode
            .SelectNodes(_xPath.XPATHNumeros);

            return new TipoConcurso
            {
                Nombre = nacionalTitulo[posicion].InnerText,
                Fecha = nacionalFechas.ConvertHtmlNodeToString(posicion),
                Numeros = nacionalNumeros.ConvertHtmlNodeToArrayString(posicion)
            };
        }
    }
}
