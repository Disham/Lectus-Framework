using Lectus.Domain.Models;
using Lectus.Services.MasterServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Lectus.WebApi.Controllers
{
    public class CountryController : ApiController
    {
        private readonly IMasterService<ICountry> _countryService;
        public CountryController(IMasterService<ICountry> countryService)
        {
            this._countryService = countryService;
        }

        public List<ICountry> Get()
        {
            return _countryService.GetAllMasterData().ToList();
        }
    }
}
