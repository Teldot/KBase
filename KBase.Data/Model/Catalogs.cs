using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBase.Data.Model.Catalogs
{
    //ENTITIE ALLWAYS REMOVE THIS CONSTRUCTOR
    //
    //public KBaseDBEntities()
    //        : base("name=KBaseDBEntities")
    //    {
    //    AppDomain.CurrentDomain.SetData("DataDirectory", System.IO.Directory.GetCurrentDirectory());
    //}

    public enum CatTypes
    {
        KnowledgeAreas = 1,
        Themes = 2,
        Tags = 3,
        ContentType = 4
    }

    public enum CatContentType
    {
        Image = 1,
        PlainText = 2,
        Audio = 3,
        Video = 4,
        WebContent = 5,
        OtherContent = 6
    }
}
