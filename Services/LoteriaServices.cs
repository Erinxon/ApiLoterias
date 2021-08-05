using ApiLoteria.AppSettingModels;
using ApiLoteria.Models;
using ApiLoteria.Models.Consts;
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
                    NewYorkTresTrenta = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, Posicion.Uno),
                    NewYorkOnceTrenta = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, Posicion.Dos),
                    FloridaDía = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, Posicion.Tres),
                    FloridaNoche = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, Posicion.Cuatro),
                    MegaMillions = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, Posicion.Cinco),
                    PowerBall = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, Posicion.Seis),
                    CashFourLife = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, Posicion.Siete),
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
                    AnguilaDiesAM = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, Posicion.Uno),
                    AnguilaUnaPM = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, Posicion.Dos),
                    AnguilaCincoPM = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, Posicion.Tres),
                    AnguilaNuevePM = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, Posicion.Cuatro),
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
                    PickTresDia = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, Posicion.Uno),
                    PickCuatroDia = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, Posicion.Dos),
                    QuinielaDoceTrenta = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, Posicion.Tres),
                    PhilipsburgMedioDia = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, Posicion.Cuatro),
                    LotoPoolMedioDia = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, Posicion.Cinco),
                    PickTresNoche = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, Posicion.Seis),
                    PickCuatroNoche = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, Posicion.Siete),
                    QuinielaSieteTrenta = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, Posicion.Ocho),
                    PhilipsburgNoche = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, Posicion.Nueve),
                    LotoPoolNoche = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, Posicion.Diez),
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
                    Quiniela = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, Posicion.Uno),
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
                    PegaTresMas = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, Posicion.Uno),
                    LotoPool = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, Posicion.Dos),
                    SuperKinoTV = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, Posicion.Tres),
                    QuinielaLeidsa = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, Posicion.Cuatro),
                    LotoMas = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, Posicion.Cinco),
                    SuperPale = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, Posicion.Seis)
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
                    Quiniela = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, Posicion.Uno),
                    ElQuemaitoMayor = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, Posicion.Dos),
                    SuperPale = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, Posicion.Tres),
                    AgarraCuatro = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, Posicion.Cuatro)
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
                    TocaTres = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, Posicion.Uno),
                    QuinielaLoteka = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, Posicion.Dos),
                    MegaChances = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, Posicion.Tres),
                    MegaChancesRepartidera = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, Posicion.Cuatro),
                    ElExtra = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, Posicion.Cinco),
                    MegaLotto = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, Posicion.Seis)

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
                    JuegaPega = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, Posicion.Uno),
                    GanaMas = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, Posicion.Dos),
                    LoteriaNacional = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, Posicion.Tres),
                    BilletesJueves = Handle.GetTipoSorteoEspecial(htmlDoc, _xPathExpression, Posicion.Uno, Posicion.Cuatro),
                    BilletesDomingo = Handle.GetTipoSorteoEspecial(htmlDoc, _xPathExpression, Posicion.Dos, Posicion.Cinco)
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
                    LaPrimera = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, Posicion.Uno)
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
                    TuFechaReal = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, Posicion.Uno),
                    PegaCuatroReal = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, Posicion.Dos),
                    NuevaYolReal = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, Posicion.Tres),
                    QuinielaReal = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, Posicion.Cuatro),
                    LotoPool = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, Posicion.Cinco),
                    LotoReal = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, Posicion.Seis),
                    SuperPale = Handle.GetTipoConcurso(htmlDoc, _xPathExpression, Posicion.Siete)
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
