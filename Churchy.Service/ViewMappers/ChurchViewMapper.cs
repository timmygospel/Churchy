using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Churchy.Common.ViewModel;
using Churchy.Model;
using Churchy.Service.Abstractions;


namespace Churchy.Service.ViewMappers
{
    public class ChurchViewMapper : BaseViewMapper
    {
        private static ChurchViewMapper _instance;

        public static ChurchViewMapper Instance { get { return _instance ?? (_instance = new ChurchViewMapper()); } }

        public ChurchViewMapper()
            : base()
        { }
        public IEnumerable<ChurchViewModel> MapChurchesToViewModels(IEnumerable<Church> churches)
        {
            return _mapper.Map<IEnumerable<ChurchViewModel>>(churches);

        }


        protected override IMapper BuildMapper()
        {
            return new Mapper(new MapperConfiguration(config =>
            {
                config.CreateMap<ChurchViewModel, Church>();
                config.CreateMap<Church, ChurchViewModel>();
            }));
        }
    }
}
