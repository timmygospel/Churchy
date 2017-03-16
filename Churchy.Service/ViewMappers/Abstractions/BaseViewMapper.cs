using AutoMapper;

namespace Churchy.Service.Abstractions
{
    public abstract class BaseViewMapper
    {
        protected readonly IMapper _mapper;

        protected BaseViewMapper()
        {
            _mapper = BuildMapper();
        }

        protected abstract IMapper BuildMapper();
    }
}
