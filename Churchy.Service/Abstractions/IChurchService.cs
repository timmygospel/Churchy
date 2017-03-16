using System.Collections.Generic;
using Churchy.Common.ViewModel;

namespace Churchy.Service.Abstractions
{
    public interface IChurchService
    {
        IEnumerable<ChurchViewModel> GetChurches();
    }
}
