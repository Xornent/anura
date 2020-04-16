using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anura.Developer.Application {
    public interface IHandler {
        Network.ResponseDocument Load (Network.ResponseDocument resp);
    }
}