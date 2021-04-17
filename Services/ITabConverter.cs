using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuitarTabPDF.Services
{
    public interface ITabConverter
    {
        string Convert(string link);
    }
}
