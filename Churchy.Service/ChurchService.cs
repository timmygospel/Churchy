using System;
using System.Collections.Generic;
using Churchy.Common.ViewModel;
using Churchy.Model;
using Churchy.Repository;
using Churchy.Service.Abstractions;
using Churchy.Service.ViewMappers;


namespace Churchy.Service
{
    public class ChurchService : IChurchService
    {

        private readonly IRepository _repository;

        public ChurchService(IRepository repository)
        {

        }

        public IEnumerable<ChurchViewModel> GetChurchs()
        {
            IEnumerable<Church> churches = _repository.Get<Church>();
            return ChurchViewMapper.Instance.MapChurchesToViewModels(churches);
        }
    }
}
