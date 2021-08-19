using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiLoteria.AppSettingModels;
using ApiLoteria.Models;
using ApiLoteria.Models.Consts;
using HtmlAgilityPack;

namespace ApiLoteria.Handles
{
    public static class Handle
    {
        private static Sorteo GetSorteo(HtmlNode node, XPathExpression _xPath)
        {
            return new Sorteo
            {
                Nombre = node.SelectSingleNode(_xPath.XPATHTitulo).InnerText,
                Fecha = node.SelectSingleNode(_xPath.XPATHFecha).InnerText.Replace(" ", "").Replace("\n", ""),
                Imagen = node.SelectSingleNode(_xPath.XPATHImagenes).Attributes["src"].Value,
                Numeros = node.SelectNodes(_xPath.XPATHNumeros)
                    .Select(x => x.InnerText.Replace("\n", "").Replace(" ", "")).ToArray()
            };
        }
        public static List<Sorteo> GetSorteos(this HtmlDocument htmlDoc, XPathExpression _xPath)
        {
            var sorteos = htmlDoc.DocumentNode
                .SelectNodes(_xPath.XPATHGeneral)
                .Select(node => GetSorteo(node, _xPath)).ToList();
            return sorteos;
        }

        public static List<Sorteo> GetSorteosNacional(this HtmlDocument htmlDoc, XPathExpression _xPath)
        {
            var htmlNodes = htmlDoc.DocumentNode.SelectNodes(_xPath.XPATHGeneral).Take(3);
            var sorteos = htmlNodes
                .Select(node => GetSorteo(node, _xPath)).ToList().ToList();
            return sorteos;
        }

        public static List<SorteoEspecial> GetSorteosEspeciales(this HtmlDocument htmlDoc, XPathExpression _xPath)
        {
            var htmlNodes = htmlDoc.DocumentNode.SelectNodes(_xPath.XPATHGeneral).TakeLast(2);
            var sorteos = htmlNodes
                .Select(node => new SorteoEspecial
                {
                    Nombre = node.SelectSingleNode(_xPath.XPATHTitulo).InnerText,
                    Fecha = node.SelectSingleNode(_xPath.XPATHFecha).InnerText.Replace(" ", "").Replace("\n", ""),
                    Imagen = node.SelectSingleNode(_xPath.XPATHImagenes).Attributes["src"].Value,
                    Numeros = node.SelectNodes(_xPath.XPATHNumerosEspeciales).Select(number => new SorteoEspecialResultado
                    {
                        NumeroEspecial = number.SelectSingleNode("td").InnerText.Replace("\n\n", "").Replace(" \n", ""),
                        Bonus = number.SelectNodes("td").Count > 1 ?
                        number.SelectNodes("td")[Posicion.Dos].InnerText.Replace("\n\n", "").Replace(" \n", "")
                        : null
                    }).ToList()
                }).ToList();
            return sorteos;
        }
    }
}
