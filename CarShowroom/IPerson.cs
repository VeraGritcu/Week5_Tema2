using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_Tema2
{
    public interface IPerson
    {
        string PersonName { get;}
        void VisitShowroom(IStore store);
    }
}
