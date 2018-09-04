using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HdHomeRunEpgXml.Data
{
   public class MovieData
    {
        public string TitleID { get; set; }
        public string TitleType { get; set; }
        public List<string> Genres { get; set; } = new List<string>();
        public string OriginalTitleType { get; set; }
    }
}
