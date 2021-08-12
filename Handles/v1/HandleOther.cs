using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiLoteria.AppSettingModels;
using ApiLoteria.Models;
using ApiLoteria.Models.Consts;
using HtmlAgilityPack;

namespace ApiLoteria.Handles.v1
{
    public static class HandleOther
    {
        /*
        private static string[] ObtenerNumerosGanadores(this HtmlNodeCollection htmlNodes, int posicion)
        {
            return htmlNodes[posicion].SelectNodes(@"span")
                    .Select(x => x.InnerText.Replace("\n", "").Replace(" ", ""))
                    .ToArray();
        }

        private static string ObtenerTitulo(this HtmlNodeCollection htmlNodes, int posicion)
        {
            return htmlNodes[posicion].InnerText;
        }

        private static string ObtenerFecha(this HtmlNodeCollection htmlNodes, int posicion)
        {
            return htmlNodes[posicion].InnerText.Replace(" ", "").Replace("\n", "");
        }

        private static string ObtenerImagen(this HtmlNodeCollection htmlNodes, int posicion)
        {
            return htmlNodes[posicion].Attributes["src"].Value;
        }

        private static List<SorteoEspecialResultado> ObtenerNumerosGanadoresEspeciales(this HtmlNodeCollection htmlNodes, int posicion)
        {
            var nodes = htmlNodes[posicion].SelectNodes(@"tr");

            var numerosGanadoresEspciales = nodes.Select(number => new SorteoEspecialResultado { 
                NumeroEspecial = number.SelectNodes("td")[Posicion.Uno].InnerText.Replace("\n\n", "").Replace(" \n", ""),
                Bonus = number.SelectNodes("td").Count > 1 ? 
                        number.SelectNodes("td")[Posicion.Dos].InnerText.Replace("\n\n", "").Replace(" \n", "")
                        : null
            }).ToList();

            return numerosGanadoresEspciales;
        }

        public static Sorteo GetTipoConcurso(HtmlDocument htmlDoc, 
            XPathExpression _xPath, int posicion)
        {
            var titulos = htmlDoc.DocumentNode.SelectNodes(_xPath.V1.XPATHTitulo);
            var fechas = htmlDoc.DocumentNode.SelectNodes(_xPath.V1.XPATHFecha);
            var numeros = htmlDoc.DocumentNode.SelectNodes(_xPath.V1.XPATHNumeros);
            var imagenes = htmlDoc.DocumentNode.SelectNodes(_xPath.V1.XPATHImagenes);

            return new Sorteo
            {
                Nombre = titulos.ObtenerTitulo(posicion),
                Fecha = fechas.ObtenerFecha(posicion),
                Imagen = imagenes.ObtenerImagen(posicion),
                Numeros = numeros.ObtenerNumerosGanadores(posicion)
            };
        }

        public static SorteoEspecial GetTipoSorteoEspecial(HtmlDocument htmlDoc,
            XPathExpression _xPath, int posicion, int posicionImg)
        {
            var titulos = htmlDoc.DocumentNode.SelectNodes(_xPath.V1.XPATHTitulo);
            var fechas = htmlDoc.DocumentNode.SelectNodes(_xPath.V1.XPATHFecha);
            var numeros = htmlDoc.DocumentNode.SelectNodes(_xPath.V1.XPATHNumerosEspeciales);
            var imagenes = htmlDoc.DocumentNode.SelectNodes(_xPath.V1.XPATHImagenes);

            return new SorteoEspecial
            {
                Nombre = titulos.ObtenerTitulo(posicion),
                Fecha = fechas.ObtenerFecha(posicion),
                Imagen = imagenes.ObtenerImagen(posicionImg),
                Numeros = numeros.ObtenerNumerosGanadoresEspeciales(posicion)
            };
        }*/
    }
}
