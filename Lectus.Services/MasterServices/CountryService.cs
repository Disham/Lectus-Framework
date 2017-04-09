using System;
using System.Collections.Generic;
using Lectus.Repository.Repositories;
using Lectus.Entity.Models;
using System.Linq.Expressions;
using Lectus.Domain.Models;
using AutoMapper;

namespace Lectus.Services.MasterServices
{
    internal class CountryService : IMasterService<ICountry>
    {
        IRepository<MstCountry> _repository;
        public CountryService(IRepository<MstCountry> repository)
        {
            _repository = repository;
        }

        public ICollection<ICountry> GetAllMasterData()
        {
            return Mapper.Map<ICollection<MstCountry>,ICollection<ICountry>>( _repository.GetAll());
        }

        public ICollection<ICountry> FindBy(Expression<Func<ICountry, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public ICountry AddMaster(ICountry entity)
        {
            throw new NotImplementedException();
        }

        public ICountry DeleteMaster(ICountry entity)
        {
            throw new NotImplementedException();
        }

        public void EditMaster(ICountry entity)
        {
            throw new NotImplementedException();
        }
    }
}
