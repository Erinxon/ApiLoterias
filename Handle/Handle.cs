using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiLoteria.AppSettingModels;
using ApiLoteria.Models;
using HtmlAgilityPack;

namespace ApiLoteria
{
    public static class Handle
    {
        private static string[] ObtenerNumerosGanadores(this HtmlNodeCollection htmlNodes, int posicion)
        {
            var numeros = htmlNodes[posicion].SelectNodes(@"span")
                    .Select(x => x.InnerText.Replace("\n", "").Replace(" ", ""))
                    .ToArray();
            return numeros;
        }

        private static string ObtenerFecha(this HtmlNodeCollection htmlNodes, int posicion)
        {
            var titulo = htmlNodes[posicion].InnerText.Replace(" ", "").Replace("\n", "");
            return titulo;
        }

        private static string obtenerImagen(this HtmlNodeCollection htmlNodes, int posicion)
        {
            var imagen = htmlNodes[posicion].Attributes["src"].Value;           
            return imagen;
        }

        private static List<SorteoEspecialResultado> ObtenerNumerosGanadoresEspeciales(this HtmlNodeCollection htmlNodes, int posicion)
        {
            List<SorteoEspecialResultado> numerosGanadoresEspciales = new();
            foreach (var row in htmlNodes[posicion].SelectNodes(@"tr"))
            {
                var nodes = row.SelectNodes("td");
                if (nodes.Count > 1)
                {
                    numerosGanadoresEspciales.Add(new SorteoEspecialResultado
                    {
                        NumeroEspecial = nodes[0].InnerText.Replace("\n\n", "").Replace(" \n", ""),
                        Bonus = nodes[1].InnerText.Replace("\n\n", "").Replace(" \n", ""),
                    });
                }
                else
                {
                    numerosGanadoresEspciales.Add(new SorteoEspecialResultado
                    {
                        NumeroEspecial = nodes[0].InnerText.Replace("\n\n", "").Replace(" \n", ""),
                    });
                }
            }
            return numerosGanadoresEspciales;
        }

        public static Sorteo GetTipoConcurso(HtmlDocument htmlDoc, 
            XPathExpression _xPath, int posicion)
        {
            var titulos = htmlDoc.DocumentNode.SelectNodes(_xPath.XPATHTitulo);
            var fechas = htmlDoc.DocumentNode.SelectNodes(_xPath.XPATHFecha);
            var numeros = htmlDoc.DocumentNode.SelectNodes(_xPath.XPATHNumeros);
            var imagenes = htmlDoc.DocumentNode.SelectNodes(_xPath.XPATHImagenes);

            return new Sorteo
            {
                Nombre = titulos[posicion].InnerText,
                Fecha = fechas.ObtenerFecha(posicion),
                Imagen = imagenes.obtenerImagen(posicion),
                Numeros = numeros.ObtenerNumerosGanadores(posicion)
            };
        }

        public static SorteoEspecial GetTipoConcursoEspecial(HtmlDocument htmlDoc,
            XPathExpression _xPath, int posicion, int posicionImg)
        {
            var titulos = htmlDoc.DocumentNode.SelectNodes(_xPath.XPATHTitulo);
            var fechas = htmlDoc.DocumentNode.SelectNodes(_xPath.XPATHFecha);
            var numeros = htmlDoc.DocumentNode.SelectNodes(_xPath.XPATHNumerosEspeciales);
            var imagenes = htmlDoc.DocumentNode.SelectNodes(_xPath.XPATHImagenes);

            return new SorteoEspecial
            {
                Nombre = titulos[posicion].InnerText,
                Fecha = fechas.ObtenerFecha(posicion),
                Imagen = imagenes.obtenerImagen(posicionImg),
                Numeros = numeros.ObtenerNumerosGanadoresEspeciales(posicion)
            };
        }
    }
}
