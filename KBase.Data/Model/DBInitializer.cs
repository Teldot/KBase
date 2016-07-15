using KBase.Data.Model2;
using System.Collections.Generic;
using System.Data.Entity;

namespace KBase.Data.Model
{
    public class DBInitializer : CreateDatabaseIfNotExists<KBaseEntitiesSC>
    {
        protected override void Seed(KBaseEntitiesSC context)
        {
            List<CatType> myCatTypes = new List<CatType>() {
                new CatType() { CatTypeId = 1, Name = "KnowledgeAreas", Description = "Knowledge Areas" },
            new CatType() { CatTypeId = 2, Name = "Themes", Description = "Themes" },
            new CatType() { CatTypeId = 3, Name = "Tags", Description = "Tags" },
            new CatType() { CatTypeId = 4, Name = "ObjectType", Description = "Object Type" }
            };
            context.CatTypes.AddRange(myCatTypes);

            List<CatVal> myCatVals = new List<CatVal>() {
                new CatVal() { CatValId=1, CatTypeId = 4, Val ="Image"},
            new CatVal() {CatValId=2, CatTypeId = 4, Val ="Plain Text" },
            new CatVal() {CatValId=3, CatTypeId = 4, Val ="Audio"},
            new CatVal() { CatValId=4, CatTypeId = 4, Val ="Video" },
            new CatVal() { CatValId=5, CatTypeId = 4, Val ="Web Content"},
            new CatVal() {CatValId=6, CatTypeId = 4, Val ="Other Content" },
            new CatVal() {CatValId=7, CatTypeId = 1, Val ="Development"},
            new CatVal() { CatValId=8, CatTypeId = 2, Val ="JavaScript" , CatParent0 = 7 },
            new CatVal() { CatValId=9, CatTypeId = 2, Val ="Java" , CatParent0 = 7},
            new CatVal() {CatValId=10, CatTypeId = 1, Val ="eLearning" },
            new CatVal() {CatValId=11, CatTypeId = 3, Val ="Linq"},
            new CatVal() {CatValId=13, CatTypeId = 2, Val ="C#", CatParent0=7 },
            new CatVal() { CatValId=12, CatTypeId = 3, Val ="jQuery" }
            };
            context.CatVals.AddRange(myCatVals);
            context.SaveChanges();
            base.Seed(context);
        }


    }
}