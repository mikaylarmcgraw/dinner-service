using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerMenu.Core
{
    public interface IServiceBase<T> where T : ModelBase
    {
        List<string> Get();
        Task<T> Add(T input);
    }
}
