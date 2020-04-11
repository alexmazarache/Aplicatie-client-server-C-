using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Networking
{
    [Serializable]
    public enum RequestType
    {
        LOGIN,
        LOGOUT,
        SUBMIT_INSC,
        SEARCH_BY_TEAM,
        GET_CURRENT_CURSE
    }
}
