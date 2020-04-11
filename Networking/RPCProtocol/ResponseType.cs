using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Networking
{
    [Serializable]
    public enum  ResponseType
    {
        OK,
        ERROR,
        NEW_SUBMIT,
        GET_DISP_CURSE,
        GET_SEARCH_RESULT
    }
}
