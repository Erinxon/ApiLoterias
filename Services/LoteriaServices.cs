using ApiLoteria.AppSetting;
using ApiLoteria.Handle;
using ApiLoteria.Models;
using HtmlAgilityPack;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLoteria.Services
{
    public class LoteriaServices : ILoteriaServices
    {
        private readonly SectionUrlPage _UrlPage;
        private readonly XPathExpression _xPathExpression;

        public LoteriaServices(IOptions<SectionUrlPage> options, IOptions<XPathExpression> XPathExpression)
        {
            this._UrlPage = options.Value;
            this._xPathExpression = XPathExpression.Value;
        }
        public async Task<Nacional> GetLoteriaNacionalAsync()
        {
            Nacional nacional = new();
            try
            {
                var htmlDoc = await GetHtmlDocument(typeof(Nacional).Name.ToLower());

                var nacionalTitulo = htmlDoc.DocumentNode
                .SelectNodes(_xPathExpression.XPATHTitulo);

                var nacionalFechas = htmlDoc.DocumentNode
                .SelectNodes(_xPathExpression.XPATHFecha);

                var nacionalNumeros = htmlDoc.DocumentNode
                .SelectNodes(_xPathExpression.XPATHNumeros);

                nacional.JuegaPega = new TipoConcurso { Nombre = nacionalTitulo[0].InnerText,
                    Fecha = nacionalFechas.ConvertHtmlNodeToString(0),
                    Numeros = nacionalNumeros.ConvertHtmlNodeToArrayString(0)
                };

                nacional.GanaMas = new TipoConcurso { Nombre = nacionalTitulo[1].InnerText,
                    Fecha = nacionalFechas.ConvertHtmlNodeToString(1),
                    Numeros = nacionalNumeros.ConvertHtmlNodeToArrayString(1)
                };

                nacional.LoteriaNacional = new TipoConcurso { Nombre = nacionalTitulo[2].InnerText,
                    Fecha = nacionalFechas.ConvertHtmlNodeToString(2),
                    Numeros = nacionalNumeros.ConvertHtmlNodeToArrayString(2)
                };

      

                var loterianacionalPast = htmlDoc.DocumentNode
                .SelectNodes(@"//section[@class='col-content']/div[@class='game-block past']");

          
                   
            }
            catch (Exception ex)
            {
                var message = ex.Message;
            }
             
            return nacional;
        }

        private async Task<HtmlDocument> GetHtmlDocument(string tipoLoteria)
        {
            HtmlWeb htmlWeb = new();
            HtmlDocument htmlDoc = await htmlWeb.LoadFromWebAsync($"{this._UrlPage.Url}/{tipoLoteria}");
            return htmlDoc;
        }
    }
}
