using ApiLoteria.AppSetting;
using ApiLoteria.Models;
using ApiLoteria.Response;
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

        public async Task<Response<Americanas>> GetLoteriaAmericanaAsync()
        {
            var response = new Response<Americanas>();
            try
            {
                var htmlDoc = await GetHtmlDocument(NameUrlLoteria.Americana);

                response.Data = new Americanas
                {
                    NewYorkTresTrenta = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, 0),
                    NewYorkOnceTrenta = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, 1),
                    FloridaDía = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, 2),
                    FloridaNoche = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, 3),
                    MegaMillions = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, 4),
                    PowerBall = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, 5),
                    CashFourLife = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, 6),
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
                    AnguilaDiesAM = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, 0),
                    AnguilaUnaPM = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, 1),
                    AnguilaCincoPM = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, 2),
                    AnguilaNuevePM = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, 3),
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
                    PickTresDia = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, 0),
                    PickCuatroDia = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, 1),
                    QuinielaDoceTrenta = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, 2),
                    PhilipsburgMedioDia = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, 3),
                    LotoPoolMedioDia = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, 4),
                    PickTresNoche = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, 5),
                    PickCuatroNoche = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, 6),
                    QuinielaSieteTrenta = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, 7),
                    PhilipsburgNoche = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, 8),
                    LotoPoolNoche = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, 9),
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
                    Quiniela = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, 0),
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
                    PegaTresMas = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, 0),
                    LotoPool = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, 1),
                    SuperKinoTV = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, 2),
                    QuinielaLeidsa = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, 3),
                    LotoMas = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, 4),
                    SuperPale = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, 5)
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
                    Quiniela = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, 0),
                    ElQuemaitoMayor = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, 1),
                    SuperPale = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, 2),
                    AgarraCuatro = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, 3)
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
                    TocaTres = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, 0),
                    QuinielaLoteka = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, 1),
                    MegaChances = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, 2),
                    MegaChancesRepartidera = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, 3),
                    ElExtra = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, 4),
                    MegaLotto = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, 5)

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
                    JuegaPega = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, 0),
                    GanaMas = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, 1),
                    LoteriaNacional = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, 2),
                    BilletesJueves = Handle.GetTipoConcursoEspecial(htmlDoc, _xPathExpression, 0),
                    BilletesDomingo = Handle.GetTipoConcursoEspecial(htmlDoc, _xPathExpression, 1)
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
                    LaPrimera = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, 0)
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
                    TuFechaReal = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, 0),
                    PegaCuatroReal = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, 1),
                    NuevaYolReal = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, 2),
                    QuinielaReal = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, 3),
                    LotoPool = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, 4),
                    LotoReal = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, 5),
                    SuperPale = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, 6)
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
