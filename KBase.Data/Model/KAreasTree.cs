using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBase.Data.Model
{
    public class KAreasTree
    {
        public List<KAreaItem> KAreaItems { get; set; }
    }
    public class KAreaItem
    {
        public string KAreaName { get; set; }
        public List<Them> Themes { get; set; }
    }
    public class Them
    {
        public string ThemeName { get; set; }
        public List<Artc> Articls { get; set; }
    }

    public class Artc
    {
        public Guid ArticleId { get; set; }
        public string ArticleTitle { get; set; }
        public string ArticleDescription { get; set; }
    }
}
