using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedraPapel
{
    class GameExeption : ApplicationException
    {
        public GameExeption(string mensagem) : base (mensagem)
        {

        }
    }
}
