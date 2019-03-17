using ShegzstuffPC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShegzstuffPC.zeLists  
{
    class PaperVersionList
    {
        public static List<PaperType> LoadPaperType()
        {
            List<PaperType> output = new List<PaperType>();

            output.Add(new PaperType  { PaperVersion ="V1", Subject = "English" });
            output.Add(new PaperType { PaperVersion = "V1", Subject = "Maths" });
            output.Add(new PaperType { PaperVersion = "V1", Subject = "Physics" });
            output.Add(new PaperType { PaperVersion = "V1", Subject = "Accounts" });
            output.Add(new PaperType { PaperVersion = "V1", Subject = "Economics" });
            output.Add(new PaperType { PaperVersion = "V1", Subject = "Chemistry" });
            output.Add(new PaperType { PaperVersion = "V1", Subject = "Biology" });
            output.Add(new PaperType { PaperVersion = "V1", Subject = "Commerce" });
            output.Add(new PaperType { PaperVersion = "V1", Subject = "Government" });
            output.Add(new PaperType { PaperVersion = "V1", Subject = "Literature" });
            output.Add(new PaperType { PaperVersion = "V1", Subject = "Geography" });
            output.Add(new PaperType { PaperVersion = "V1", Subject = "Christian Religious Knowledge(CRK)" });
            output.Add(new PaperType { PaperVersion = "V1", Subject = "Agricultural Science" });
            output.Add(new PaperType { PaperVersion = "V1", Subject = "Islamic Religious Knowledge (IRL)" });
            output.Add(new PaperType { PaperVersion = "V1", Subject = "History" });


            return output;
        }
    }
}
