using KBase.Data.Model2;
using KBase.Data.Model.Catalogs;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBase.Logic.Controllers
{
    public class CatalogeController
    {
        #region Atributes
        KBaseEntitiesSC dbContext;
        #endregion

        #region Properties
        public CatTypes Cataloge { get; set; }
        public Dictionary<string, object> DataObject { get; set; }
        #endregion

        #region Constructor
        public CatalogeController()
        {
            dbContext = new KBaseEntitiesSC();
        }
        public CatalogeController(CatTypes cataloge)
        {
            Cataloge = cataloge;
            dbContext = new KBaseEntitiesSC();
        }
        #endregion

        #region Methods
        public object GetData(DataTypes dataType)
        {
            try
            {
                switch (dataType)
                {
                    case DataTypes.LoadSeeds:
                        #region LoadSeeds
                        if (dbContext.CatTypes.Count() == 0)
                        {
                            foreach (var catTypeVal in Enum.GetValues(typeof(CatTypes)))
                            {
                                dbContext.Set<CatType>().Add(new CatType()
                                {
                                    CatTypeId = (int)catTypeVal,
                                    Name = Enum.GetName(typeof(CatTypes), catTypeVal),
                                    Description = Enum.GetName(typeof(CatTypes), catTypeVal)
                                });
                            }

                        }
                        break;
                    #endregion
                    case DataTypes.Load:
                        long? par0 = null;
                        if (DataObject.ContainsKey(DataFields.Parent0.ToString()))
                            par0 = (long)DataObject[DataFields.Parent0.ToString()];
                        var cat2Load = from cat in dbContext.CatVals
                                       where cat.CatTypeId == (int)Cataloge &&
                                       cat.CatParent0 == par0 && cat.Active.Value
                                       select new { cat.CatValId, cat.Val };
                        return cat2Load.ToList();
                    case DataTypes.LoadParentCat:
                        var parentCat = (from cat in dbContext.CatVals
                                         where cat.CatTypeId == (int)CatTypes.KnowledgeAreas && cat.Active.Value
                                         select new { cat.CatValId, cat.Val }).ToList();

                        long CatValId = -1;
                        string Val = "Select...";
                        parentCat.Add(new { CatValId, Val });

                        return parentCat.OrderBy(p => p.CatValId).ToList();

                    case DataTypes.Update:
                        long cId = (long)DataObject[DataFields.CatId.ToString()];
                        CatVal oldCat = dbContext.CatVals.Where(c => c.CatValId == cId).FirstOrDefault();
                        oldCat.CatTypeId = (int)Cataloge;
                        oldCat.Val = DataObject[DataFields.Value.ToString()].ToString();
                        if (DataObject.ContainsKey(DataFields.Parent0.ToString()))
                            oldCat.CatParent0 = (long)DataObject[DataFields.Parent0.ToString()];

                        break;
                    case DataTypes.Save:
                        if (!DataObject.ContainsKey(DataFields.CatId.ToString()))
                        {
                            CatVal newCat = new CatVal();
                            newCat.CatTypeId = (int)Cataloge;
                            newCat.Val = DataObject[DataFields.Value.ToString()].ToString();
                            newCat.Active = true;
                            if (DataObject.ContainsKey(DataFields.Parent0.ToString()))
                                newCat.CatParent0 = (long)DataObject[DataFields.Parent0.ToString()];

                            dbContext.CatVals.Add(newCat);
                        }
                        else
                            GetData(DataTypes.Update);
                        dbContext.SaveChanges();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                throw new CatalogeControllerException("CatalogeController. DataType:" + dataType.ToString(), ex);
            }
            return null;
        }
        #endregion

        #region Enums
        public enum DataTypes
        {
            LoadSeeds,
            Load,
            LoadParentCat,
            Update,
            Save
        }

        public enum DataFields
        {
            CatId,
            CatType,
            Value,
            Parent0,
            Parent1,
            Parent2
        }
        #endregion
    }

    public class CatalogeControllerException : Exception
    {
        public CatalogeControllerException() : base() { }
        public CatalogeControllerException(string message) : base(message) { }
        public CatalogeControllerException(string message, System.Exception inner) : base(message, inner) { }
    }
}
