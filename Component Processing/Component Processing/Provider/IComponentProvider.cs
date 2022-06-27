using Component_Processing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Component_Processing.Provider
{
    public interface IComponentProvider
    {
        public ProcessResponse GetResponse(string type, int quantity, bool Priority);
    }
}
