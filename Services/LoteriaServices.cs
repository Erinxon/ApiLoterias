using ApiLoteria.AppSettingModels;
using ApiLoteria.Models;
using ApiLoteria.Models.Consts;
using ApiLoteria.Response;
using ApiLoteria.Handles;
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
        public LoteriaServices(IOptions<SectionUrlPage> urlPage, IOptions<XPathExpression> XPathExpression)
        {
            this._UrlPage = urlPage.Value;
            this._xPathExpression = XPathExpression.Value;
        }

        public async Task<Response<Americanas>> GetLoteriaAmericanaAsync()
        {
            var response = new Response<Americanas>();
            try
            {
                var htmlDoc = await GetHtmlDocument(NameUrlLoteria.Americana);

                response.Data = new Americanas
                {
                    Sorteos = htmlDoc.GetSorteos(_xPathExpression)
                };

            }
            catch (Exception ex)
            {
                response.Success = false;
                response.message = ex.Message;
            }
            return response;
        }

        public async Task<Response<Anguila>> GetLoteriaAnguilaAsync()
        {
            var response = new Response<Anguila>();
            try
            {
                var htmlDoc = await GetHtmlDocument(NameUrlLoteria.Anguila);

                response.Data = new Anguila
                {
                    Sorteos = htmlDoc.GetSorteos(_xPathExpression)
                };

            }
            catch (Exception ex)
            {
                response.Success = false;
                response.message = ex.Message;
            }
            return response;
        }

        public async Task<Response<KingLottery>> GetLoteriaKingLotteryAsync()
        {
            var response = new Response<KingLottery>();
            try
            {
                var htmlDoc = await GetHtmlDocument(NameUrlLoteria.KingLottery);

                response.Data = new KingLottery
                {
                    Sorteos = htmlDoc.GetSorteos(_xPathExpression)
                };

            }
            catch (Exception ex)
            {
                response.Success = false;
                response.message = ex.Message;
            }
            return response;
        }

        public async Task<Response<LaSuerte>> GetLoteriaLaSuerteAsync()
        {
            var response = new Response<LaSuerte>();
            try
            {
                var htmlDoc = await GetHtmlDocument(NameUrlLoteria.LaSuerte);

                response.Data = new LaSuerte
                {
                    Sorteos = htmlDoc.GetSorteos(_xPathExpression)
                };

            }
            catch (Exception ex)
            {
                response.Success = false;
                response.message = ex.Message;
            }
            return response;
        }

        public async Task<Response<Leidsa>> GetLoteriaLeisaAsync()
        {
            var response = new Response<Leidsa>();  
            try
            {
                var htmlDoc = await GetHtmlDocument(NameUrlLoteria.Leidsa);

                response.Data = new Leidsa
                {
                    Sorteos = htmlDoc.GetSorteos(_xPathExpression)
                };
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.message = ex.Message;
            }
            return response;
        }

        public async Task<Response<LoteDom>> GetLoteriaLoteDomAsync()
        {
            var response = new Response<LoteDom>();
            try
            {
                var htmlDoc = await GetHtmlDocument(NameUrlLoteria.LoteDom);

                response.Data = new LoteDom
                {
                    Sorteos = htmlDoc.GetSorteos(_xPathExpression)
                };

            }
            catch (Exception ex)
            {
                response.Success = false;
                response.message = ex.Message;
            }
            return response;
        }

        public async Task<Response<Loteka>> GetLoteriaLotekaAsync()
        {
            var response = new Response<Loteka>();
            try
            {
                var htmlDoc = await GetHtmlDocument(NameUrlLoteria.Loteka);

                response.Data = new Loteka
                {
                    Sorteos = htmlDoc.GetSorteos(_xPathExpression)
                };
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.message = ex.Message;
            }
            return response;
        }

        public async Task<Response<Nacional>> GetLoteriaNacionalAsync()
        {
            var response = new Response<Nacional>();
            try
            {
                var htmlDoc = await GetHtmlDocument(NameUrlLoteria.Nacional);

                response.Data = new Nacional
                {
                    Sorteos = htmlDoc.GetSorteosNacional(_xPathExpression),
                    SorteoEspeciales = htmlDoc.GetSorteosEspeciales(_xPathExpression)
                };         
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.message = ex.Message;
            }     
            return response;
        }

        public async Task<Response<Primera>> GetLoteriaPrimeraAsync()
        {
            var response = new Response<Primera>();
            try
            {
                var htmlDoc = await GetHtmlDocument(NameUrlLoteria.Primera);

                response.Data = new Primera
                {
                    Sorteos = htmlDoc.GetSorteos(_xPathExpression)
                };

            }
            catch (Exception ex)
            {
                response.Success = false;
                response.message = ex.Message;
            }
            return response;
        }

        public async Task<Response<Real>> GetLoteriaRealAsync()
        {
            var response = new Response<Real>();
            try
            {
                var htmlDoc = await GetHtmlDocument(NameUrlLoteria.Real);

                response.Data = new Real
                {
                    Sorteos = htmlDoc.GetSorteos(_xPathExpression)
                };

            }
            catch (Exception ex)
            {
                response.Success = false;
                response.message = ex.Message;
            }
            return response;
        }

        private async Task<HtmlDocument> GetHtmlDocument(string tipoLoteria)
        {
            HtmlWeb htmlWeb = new();
            HtmlDocument htmlDoc = await htmlWeb.LoadFromWebAsync($"{this._UrlPage.Url}/{tipoLoteria}");
            return htmlDoc;
        }
    }
 
}
