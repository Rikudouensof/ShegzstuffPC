using ShegzstuffPC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShegzstuffPC.zeLists
{
    class VerList
    {
        public static List<PaperVer> LoadVer()
        {
            List<PaperVer> output = new List<PaperVer>();
            output.Add(new PaperVer { ID = 1, version = "V1" });
            return output;
        }

    }
}
