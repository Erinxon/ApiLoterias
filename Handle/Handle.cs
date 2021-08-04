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

        private static List<ConcursoEspecialResultado> ObtenerNumerosGanadoresEspeciales(this HtmlNodeCollection htmlNodes, int posicion)
        {
            List<ConcursoEspecialResultado> concursoEspecial = new();
            foreach (var row in htmlNodes[posicion].SelectNodes(@"tr"))
            {
                var nodes = row.SelectNodes("td");
                if (nodes.Count > 1)
                {
                    var concurso = new ConcursoEspecialResultado
                    {
                        NumeroEspecial = nodes[0].InnerText.Replace("\n\n", "").Replace(" \n", ""),
                        Bonus = nodes[1].InnerText.Replace("\n\n", "").Replace(" \n", ""),
                    };
                    concursoEspecial.Add(concurso);
                }
                else
                {
                    var concurso = new ConcursoEspecialResultado
                    {
                        NumeroEspecial = nodes[0].InnerText.Replace("\n\n", "").Replace(" \n", ""),
                    };
                    concursoEspecial.Add(concurso);
                }
            }
            return concursoEspecial;
        }

        public static Concurso GetTipoConcurso(HtmlDocument htmlDoc, 
            XPathExpression _xPath, int posicion)
        {
            var titulos = htmlDoc.DocumentNode
                .SelectNodes(_xPath.XPATHTitulo);
            var fechas = htmlDoc.DocumentNode
            .SelectNodes(_xPath.XPATHFecha);
            var numeros = htmlDoc.DocumentNode
            .SelectNodes(_xPath.XPATHNumeros);

            return new Concurso
            {
                Nombre = titulos[posicion].InnerText,
                Fecha = fechas.ObtenerFecha(posicion),
                Numeros = numeros.ObtenerNumerosGanadores(posicion)
            };
        }

        public static ConcursoEspecial GetTipoConcursoEspecial(HtmlDocument htmlDoc,
            XPathExpression _xPath, int posicion)
        {
            var titulos = htmlDoc.DocumentNode
                .SelectNodes(_xPath.XPATHTitulo);
            var fechas = htmlDoc.DocumentNode
            .SelectNodes(_xPath.XPATHFecha);

            var numeros = htmlDoc.DocumentNode
            .SelectNodes(_xPath.XPATHNumerosEspeciales);
        
            return new ConcursoEspecial
            {
                Nombre = titulos[posicion].InnerText,
                Fecha = fechas.ObtenerFecha(posicion),
                Numeros = numeros.ObtenerNumerosGanadoresEspeciales(posicion)
            };
        }
    }
}
