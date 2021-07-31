using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace ApiLoteria.Handle
{
    public static class Handle
    {
        public static string[] ConvertHtmlNodeToArrayString(this HtmlNodeCollection htmlNodes, int posicion)
        {
            var numeros = htmlNodes[posicion].SelectNodes(@"span")
                    .Select(x => x.InnerText.Replace("\n", "").Replace(" ", ""))
                    .ToArray();
            return numeros;
        }

        public static string ConvertHtmlNodeToString(this HtmlNodeCollection htmlNodes, int posicion)
        {
            var titulo = htmlNodes[posicion].InnerText.Replace(" ", "").Replace("\n", "");
            return titulo;
        }


    }
}
