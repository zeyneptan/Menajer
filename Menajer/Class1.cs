using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menajer
{
    public class peri : IPeri
    {
        public string socialize(string file_location)
        {
            return file_location;
        }
    }

    public class ego : IEgo, IPeri
    {
        public string eat(string file_location)
        {
            return file_location;
        }

        public string socialize(string file_location)
        {
            return file_location;
        }
    }
    public class zeyna : IZeyna, IEgo, IPeri
    {
        public string cry(string file_location)
        {
            return file_location;
        }

        public string eat(string file_location)
        {
            return file_location;
        }

        public string socialize(string file_location)
        {
            return file_location;
        }
    }








}

