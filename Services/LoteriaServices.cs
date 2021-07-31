using ApiLoteria.AppSetting;
using ApiLoteria.Handle;
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

                var nacionalTitulo = htmlDoc.DocumentNode
                .SelectNodes(_xPathExpression.XPATHTitulo);

                var nacionalFechas = htmlDoc.DocumentNode
                .SelectNodes(_xPathExpression.XPATHFecha);

                var nacionalNumeros = htmlDoc.DocumentNode
                .SelectNodes(_xPathExpression.XPATHNumeros);

                response.Data = new Americanas
                {
                    NewYorkTresTrenta = new TipoConcurso
                    {
                        Nombre = nacionalTitulo[0].InnerText,
                        Fecha = nacionalFechas.ConvertHtmlNodeToString(0),
                        Numeros = nacionalNumeros.ConvertHtmlNodeToArrayString(0)
                    },
                    NewYorkOnceTrenta = new TipoConcurso
                    {
                        Nombre = nacionalTitulo[1].InnerText,
                        Fecha = nacionalFechas.ConvertHtmlNodeToString(1),
                        Numeros = nacionalNumeros.ConvertHtmlNodeToArrayString(1)
                    },
                    FloridaDía = new TipoConcurso
                    {
                        Nombre = nacionalTitulo[2].InnerText,
                        Fecha = nacionalFechas.ConvertHtmlNodeToString(2),
                        Numeros = nacionalNumeros.ConvertHtmlNodeToArrayString(2)
                    },
                    FloridaNoche = new TipoConcurso
                    {
                        Nombre = nacionalTitulo[3].InnerText,
                        Fecha = nacionalFechas.ConvertHtmlNodeToString(3),
                        Numeros = nacionalNumeros.ConvertHtmlNodeToArrayString(3)
                    },
                    MegaMillions = new TipoConcurso
                    {
                        Nombre = nacionalTitulo[4].InnerText,
                        Fecha = nacionalFechas.ConvertHtmlNodeToString(4),
                        Numeros = nacionalNumeros.ConvertHtmlNodeToArrayString(4)
                    },
                    PowerBall = new TipoConcurso
                    {
                        Nombre = nacionalTitulo[5].InnerText,
                        Fecha = nacionalFechas.ConvertHtmlNodeToString(5),
                        Numeros = nacionalNumeros.ConvertHtmlNodeToArrayString(5)
                    },
                    CashFourLife = new TipoConcurso
                    {
                        Nombre = nacionalTitulo[6].InnerText,
                        Fecha = nacionalFechas.ConvertHtmlNodeToString(6),
                        Numeros = nacionalNumeros.ConvertHtmlNodeToArrayString(6)
                    },
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

                var nacionalTitulo = htmlDoc.DocumentNode
                .SelectNodes(_xPathExpression.XPATHTitulo);

                var nacionalFechas = htmlDoc.DocumentNode
                .SelectNodes(_xPathExpression.XPATHFecha);

                var nacionalNumeros = htmlDoc.DocumentNode
                .SelectNodes(_xPathExpression.XPATHNumeros);

                response.Data = new Anguila
                {
                    AnguilaDiesAM = new TipoConcurso
                    {
                        Nombre = nacionalTitulo[0].InnerText,
                        Fecha = nacionalFechas.ConvertHtmlNodeToString(0),
                        Numeros = nacionalNumeros.ConvertHtmlNodeToArrayString(0)
                    },
                    AnguilaUnaPM = new TipoConcurso
                    {
                        Nombre = nacionalTitulo[1].InnerText,
                        Fecha = nacionalFechas.ConvertHtmlNodeToString(1),
                        Numeros = nacionalNumeros.ConvertHtmlNodeToArrayString(1)
                    },
                    AnguilaCincoPM = new TipoConcurso
                    {
                        Nombre = nacionalTitulo[2].InnerText,
                        Fecha = nacionalFechas.ConvertHtmlNodeToString(2),
                        Numeros = nacionalNumeros.ConvertHtmlNodeToArrayString(2)
                    },
                    AnguilaNuevePM = new TipoConcurso
                    {
                        Nombre = nacionalTitulo[3].InnerText,
                        Fecha = nacionalFechas.ConvertHtmlNodeToString(3),
                        Numeros = nacionalNumeros.ConvertHtmlNodeToArrayString(3)
                    },
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

                var nacionalTitulo = htmlDoc.DocumentNode
                .SelectNodes(_xPathExpression.XPATHTitulo);

                var nacionalFechas = htmlDoc.DocumentNode
                .SelectNodes(_xPathExpression.XPATHFecha);

                var nacionalNumeros = htmlDoc.DocumentNode
                .SelectNodes(_xPathExpression.XPATHNumeros);

                response.Data = new KingLottery
                {
                    PickTresDia = new TipoConcurso
                    {
                        Nombre = nacionalTitulo[0].InnerText,
                        Fecha = nacionalFechas.ConvertHtmlNodeToString(0),
                        Numeros = nacionalNumeros.ConvertHtmlNodeToArrayString(0)
                    },
                    PickCuatroDia = new TipoConcurso
                    {
                        Nombre = nacionalTitulo[1].InnerText,
                        Fecha = nacionalFechas.ConvertHtmlNodeToString(1),
                        Numeros = nacionalNumeros.ConvertHtmlNodeToArrayString(1)
                    },
                    QuinielaDoceTrenta = new TipoConcurso
                    {
                        Nombre = nacionalTitulo[2].InnerText,
                        Fecha = nacionalFechas.ConvertHtmlNodeToString(2),
                        Numeros = nacionalNumeros.ConvertHtmlNodeToArrayString(2)
                    },
                    PhilipsburgMedioDia = new TipoConcurso
                    {
                        Nombre = nacionalTitulo[3].InnerText,
                        Fecha = nacionalFechas.ConvertHtmlNodeToString(3),
                        Numeros = nacionalNumeros.ConvertHtmlNodeToArrayString(3)
                    },
                    LotoPoolMedioDia = new TipoConcurso
                    {
                        Nombre = nacionalTitulo[4].InnerText,
                        Fecha = nacionalFechas.ConvertHtmlNodeToString(4),
                        Numeros = nacionalNumeros.ConvertHtmlNodeToArrayString(4)
                    },
                    PickTresNoche = new TipoConcurso
                    {
                        Nombre = nacionalTitulo[5].InnerText,
                        Fecha = nacionalFechas.ConvertHtmlNodeToString(5),
                        Numeros = nacionalNumeros.ConvertHtmlNodeToArrayString(5)
                    },
                    PickCuatroNoche = new TipoConcurso
                    {
                        Nombre = nacionalTitulo[6].InnerText,
                        Fecha = nacionalFechas.ConvertHtmlNodeToString(6),
                        Numeros = nacionalNumeros.ConvertHtmlNodeToArrayString(6)
                    },
                    QuinielaSieteTrenta = new TipoConcurso
                    {
                        Nombre = nacionalTitulo[7].InnerText,
                        Fecha = nacionalFechas.ConvertHtmlNodeToString(7),
                        Numeros = nacionalNumeros.ConvertHtmlNodeToArrayString(7)
                    },
                    PhilipsburgNoche = new TipoConcurso
                    {
                        Nombre = nacionalTitulo[8].InnerText,
                        Fecha = nacionalFechas.ConvertHtmlNodeToString(8),
                        Numeros = nacionalNumeros.ConvertHtmlNodeToArrayString(8)
                    },
                    LotoPoolNoche = new TipoConcurso
                    {
                        Nombre = nacionalTitulo[9].InnerText,
                        Fecha = nacionalFechas.ConvertHtmlNodeToString(9),
                        Numeros = nacionalNumeros.ConvertHtmlNodeToArrayString(9)
                    },
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

                var nacionalTitulo = htmlDoc.DocumentNode
                .SelectNodes(_xPathExpression.XPATHTitulo);

                var nacionalFechas = htmlDoc.DocumentNode
                .SelectNodes(_xPathExpression.XPATHFecha);

                var nacionalNumeros = htmlDoc.DocumentNode
                .SelectNodes(_xPathExpression.XPATHNumeros);

                response.Data = new LaSuerte
                {
                    Quiniela = new TipoConcurso
                    {
                        Nombre = nacionalTitulo[0].InnerText,
                        Fecha = nacionalFechas.ConvertHtmlNodeToString(0),
                        Numeros = nacionalNumeros.ConvertHtmlNodeToArrayString(0)
                    },
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

                var nacionalTitulo = htmlDoc.DocumentNode
                .SelectNodes(_xPathExpression.XPATHTitulo);

                var nacionalFechas = htmlDoc.DocumentNode
                .SelectNodes(_xPathExpression.XPATHFecha);

                var nacionalNumeros = htmlDoc.DocumentNode
                .SelectNodes(_xPathExpression.XPATHNumeros);

                response.Data = new Leidsa
                {
                    PegaTresMas = new TipoConcurso
                    {
                        Nombre = nacionalTitulo[0].InnerText,
                        Fecha = nacionalFechas.ConvertHtmlNodeToString(0),
                        Numeros = nacionalNumeros.ConvertHtmlNodeToArrayString(0)
                    },
                    LotoPool = new TipoConcurso
                    {
                        Nombre = nacionalTitulo[1].InnerText,
                        Fecha = nacionalFechas.ConvertHtmlNodeToString(1),
                        Numeros = nacionalNumeros.ConvertHtmlNodeToArrayString(1)
                    },
                    SuperKinoTV = new TipoConcurso
                    {
                        Nombre = nacionalTitulo[2].InnerText,
                        Fecha = nacionalFechas.ConvertHtmlNodeToString(2),
                        Numeros = nacionalNumeros.ConvertHtmlNodeToArrayString(2)
                    },
                    QuinielaLeidsa = new TipoConcurso
                    {
                        Nombre = nacionalTitulo[3].InnerText,
                        Fecha = nacionalFechas.ConvertHtmlNodeToString(3),
                        Numeros = nacionalNumeros.ConvertHtmlNodeToArrayString(3)
                    },
                    LotoMas = new TipoConcurso
                    {
                        Nombre = nacionalTitulo[4].InnerText,
                        Fecha = nacionalFechas.ConvertHtmlNodeToString(4),
                        Numeros = nacionalNumeros.ConvertHtmlNodeToArrayString(4)
                    },
                    SuperPale = new TipoConcurso
                    {
                        Nombre = nacionalTitulo[5].InnerText,
                        Fecha = nacionalFechas.ConvertHtmlNodeToString(5),
                        Numeros = nacionalNumeros.ConvertHtmlNodeToArrayString(5)
                    }
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

                var nacionalTitulo = htmlDoc.DocumentNode
                .SelectNodes(_xPathExpression.XPATHTitulo);

                var nacionalFechas = htmlDoc.DocumentNode
                .SelectNodes(_xPathExpression.XPATHFecha);

                var nacionalNumeros = htmlDoc.DocumentNode
                .SelectNodes(_xPathExpression.XPATHNumeros);

                response.Data = new LoteDom
                {
                    Quiniela = new TipoConcurso
                    {
                        Nombre = nacionalTitulo[0].InnerText,
                        Fecha = nacionalFechas.ConvertHtmlNodeToString(0),
                        Numeros = nacionalNumeros.ConvertHtmlNodeToArrayString(0)
                    },
                    ElQuemaitoMayor = new TipoConcurso
                    {
                        Nombre = nacionalTitulo[1].InnerText,
                        Fecha = nacionalFechas.ConvertHtmlNodeToString(1),
                        Numeros = nacionalNumeros.ConvertHtmlNodeToArrayString(1)
                    },
                    SuperPale = new TipoConcurso
                    {
                        Nombre = nacionalTitulo[2].InnerText,
                        Fecha = nacionalFechas.ConvertHtmlNodeToString(2),
                        Numeros = nacionalNumeros.ConvertHtmlNodeToArrayString(2)
                    },
                    AgarraCuatro = new TipoConcurso
                    {
                        Nombre = nacionalTitulo[3].InnerText,
                        Fecha = nacionalFechas.ConvertHtmlNodeToString(3),
                        Numeros = nacionalNumeros.ConvertHtmlNodeToArrayString(3)
                    },
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

                var nacionalTitulo = htmlDoc.DocumentNode
                .SelectNodes(_xPathExpression.XPATHTitulo);

                var nacionalFechas = htmlDoc.DocumentNode
                .SelectNodes(_xPathExpression.XPATHFecha);

                var nacionalNumeros = htmlDoc.DocumentNode
                .SelectNodes(_xPathExpression.XPATHNumeros);

                response.Data = new Loteka
                {
                    TocaTres = new TipoConcurso
                    {
                        Nombre = nacionalTitulo[0].InnerText,
                        Fecha = nacionalFechas.ConvertHtmlNodeToString(0),
                        Numeros = nacionalNumeros.ConvertHtmlNodeToArrayString(0)
                    },
                    QuinielaLoteka = new TipoConcurso
                    {
                        Nombre = nacionalTitulo[1].InnerText,
                        Fecha = nacionalFechas.ConvertHtmlNodeToString(1),
                        Numeros = nacionalNumeros.ConvertHtmlNodeToArrayString(1)
                    },
                    MegaChances = new TipoConcurso
                    {
                        Nombre = nacionalTitulo[2].InnerText,
                        Fecha = nacionalFechas.ConvertHtmlNodeToString(2),
                        Numeros = nacionalNumeros.ConvertHtmlNodeToArrayString(2)
                    },
                    MegaChancesRepartidera = new TipoConcurso
                    {
                        Nombre = nacionalTitulo[3].InnerText,
                        Fecha = nacionalFechas.ConvertHtmlNodeToString(3),
                        Numeros = nacionalNumeros.ConvertHtmlNodeToArrayString(3)
                    },
                    ElExtra = new TipoConcurso
                    {
                        Nombre = nacionalTitulo[4].InnerText,
                        Fecha = nacionalFechas.ConvertHtmlNodeToString(4),
                        Numeros = nacionalNumeros.ConvertHtmlNodeToArrayString(4)
                    },
                    MegaLotto = new TipoConcurso
                    {
                        Nombre = nacionalTitulo[5].InnerText,
                        Fecha = nacionalFechas.ConvertHtmlNodeToString(5),
                        Numeros = nacionalNumeros.ConvertHtmlNodeToArrayString(5)
                    },

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

                var nacionalTitulo = htmlDoc.DocumentNode
                .SelectNodes(_xPathExpression.XPATHTitulo);

                var nacionalFechas = htmlDoc.DocumentNode
                .SelectNodes(_xPathExpression.XPATHFecha);

                var nacionalNumeros = htmlDoc.DocumentNode
                .SelectNodes(_xPathExpression.XPATHNumeros);

                response.Data = new Nacional
                {
                    JuegaPega = new TipoConcurso
                    {
                        Nombre = nacionalTitulo[0].InnerText,
                        Fecha = nacionalFechas.ConvertHtmlNodeToString(0),
                        Numeros = nacionalNumeros.ConvertHtmlNodeToArrayString(0)
                    },
                    GanaMas = new TipoConcurso
                    {
                        Nombre = nacionalTitulo[1].InnerText,
                        Fecha = nacionalFechas.ConvertHtmlNodeToString(1),
                        Numeros = nacionalNumeros.ConvertHtmlNodeToArrayString(1)
                    },
                    LoteriaNacional = new TipoConcurso
                    {
                        Nombre = nacionalTitulo[2].InnerText,
                        Fecha = nacionalFechas.ConvertHtmlNodeToString(2),
                        Numeros = nacionalNumeros.ConvertHtmlNodeToArrayString(2)
                    }
                };

                /*
                nacional.BilletesJueves = new TipoConcurso
                {
                    Nombre = nacionalTitulo[3].InnerText,
                    Fecha = nacionalFechas.ConvertHtmlNodeToString(3),
                    Numeros = nacionalNumeros.ConvertHtmlNodeToArrayString(3)
                };

                nacional.BilletesDomingo = new TipoConcurso
                {
                    Nombre = nacionalTitulo[4].InnerText,
                    Fecha = nacionalFechas.ConvertHtmlNodeToString(4),
                    Numeros = nacionalNumeros.ConvertHtmlNodeToArrayString(4)
                };*/

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

                var nacionalTitulo = htmlDoc.DocumentNode
                .SelectNodes(_xPathExpression.XPATHTitulo);

                var nacionalFechas = htmlDoc.DocumentNode
                .SelectNodes(_xPathExpression.XPATHFecha);

                var nacionalNumeros = htmlDoc.DocumentNode
                .SelectNodes(_xPathExpression.XPATHNumeros);

                response.Data = new Primera
                {
                    LaPrimera = new TipoConcurso
                    {
                        Nombre = nacionalTitulo[0].InnerText,
                        Fecha = nacionalFechas.ConvertHtmlNodeToString(0),
                        Numeros = nacionalNumeros.ConvertHtmlNodeToArrayString(0)
                    },
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

                var nacionalTitulo = htmlDoc.DocumentNode
                .SelectNodes(_xPathExpression.XPATHTitulo);

                var nacionalFechas = htmlDoc.DocumentNode
                .SelectNodes(_xPathExpression.XPATHFecha);

                var nacionalNumeros = htmlDoc.DocumentNode
                .SelectNodes(_xPathExpression.XPATHNumeros);

                response.Data = new Real
                {
                    TuFechaReal = new TipoConcurso
                    {
                        Nombre = nacionalTitulo[0].InnerText,
                        Fecha = nacionalFechas.ConvertHtmlNodeToString(0),
                        Numeros = nacionalNumeros.ConvertHtmlNodeToArrayString(0)
                    },
                    PegaCuatroReal = new TipoConcurso
                    {
                        Nombre = nacionalTitulo[1].InnerText,
                        Fecha = nacionalFechas.ConvertHtmlNodeToString(1),
                        Numeros = nacionalNumeros.ConvertHtmlNodeToArrayString(1)
                    },
                    NuevaYolReal = new TipoConcurso
                    {
                        Nombre = nacionalTitulo[2].InnerText,
                        Fecha = nacionalFechas.ConvertHtmlNodeToString(2),
                        Numeros = nacionalNumeros.ConvertHtmlNodeToArrayString(2)
                    },
                    QuinielaReal = new TipoConcurso
                    {
                        Nombre = nacionalTitulo[3].InnerText,
                        Fecha = nacionalFechas.ConvertHtmlNodeToString(3),
                        Numeros = nacionalNumeros.ConvertHtmlNodeToArrayString(3)
                    },
                    LotoPool = new TipoConcurso
                    {
                        Nombre = nacionalTitulo[4].InnerText,
                        Fecha = nacionalFechas.ConvertHtmlNodeToString(4),
                        Numeros = nacionalNumeros.ConvertHtmlNodeToArrayString(4)
                    },
                    LotoReal = new TipoConcurso
                    {
                        Nombre = nacionalTitulo[5].InnerText,
                        Fecha = nacionalFechas.ConvertHtmlNodeToString(5),
                        Numeros = nacionalNumeros.ConvertHtmlNodeToArrayString(5)
                    },
                    SuperPale = new TipoConcurso
                    {
                        Nombre = nacionalTitulo[6].InnerText,
                        Fecha = nacionalFechas.ConvertHtmlNodeToString(6),
                        Numeros = nacionalNumeros.ConvertHtmlNodeToArrayString(6)
                    },
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
