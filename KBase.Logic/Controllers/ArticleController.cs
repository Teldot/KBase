using KBase.Data.Model2;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using KBase.Data.Model.Catalogs;

namespace KBase.Logic.Controllers
{
    public class ArticleController
    {
        #region Atributes
        KBaseEntitiesSC dbContext;
        Guid ArticleId;
        #endregion

        #region Properties
        public string DataObject { get; set; }
        public Article CurrentArticle { get; set; }
        public ArticleController.DataType Action { get; set; }
        #endregion

        #region Constructor
        public ArticleController()
        {
            dbContext = new KBaseEntitiesSC();
        }
        public ArticleController(ArticleController.DataType action)
        {
            dbContext = new KBaseEntitiesSC();
            Action = action;
            if (Action == DataType.New)
                GetData(Action);

        }
        public ArticleController(ArticleController.DataType action, Guid articleId)
        {
            dbContext = new KBaseEntitiesSC();
            Action = action;
            ArticleId = articleId;
            if (Action == DataType.Edit)
                GetData(Action);

        }
        #endregion

        #region Methods
        public object GetData(DataType dataType)
        {
            //DataType dType = (DataType)Enum.Parse(typeof(DataType), dataType);
            Article art, newArt;
            ArticleContent newAc;
            List<int> kArea, theme;
            long CatValId = -1;
            string Val = "Select...";

            try
            {
                switch (dataType)
                {
                    case DataType.LoadKAreas:
                        #region LoadAreas
                        var kAreas = (from cat in dbContext.CatVals
                                      where cat.CatTypeId == (int)CatTypes.KnowledgeAreas && cat.Active.Value
                                      select new { cat.CatValId, cat.Val }).ToList();

                        kAreas.Add(new { CatValId, Val });

                        return kAreas.OrderBy(p => p.CatValId).ToList();
                    #endregion
                    case DataType.LoadThems:
                        #region LoadThemes
                        var themes = (from cat in dbContext.CatVals
                                      where cat.CatTypeId == (int)CatTypes.Themes && cat.Active.Value
                                      select new { cat.CatValId, cat.Val }).ToList();
                        themes.Add(new { CatValId, Val });

                        return themes.OrderBy(p => p.CatValId).ToList();
                    #endregion
                    case DataType.LoadTags:
                        #region LoadTags
                        var tags = (from cat in dbContext.CatVals
                                    where cat.CatTypeId == (int)CatTypes.Tags && cat.Active.Value
                                    select new { cat.CatValId, cat.Val }).OrderBy(t => t.Val).ToDictionary(t => t.CatValId, t => t.Val);
                        return tags;
                    #endregion
                    case DataType.LoadContenType:
                        #region LoadContenType
                        var ConTypes = (from cat in dbContext.CatVals
                                        where cat.CatTypeId == (int)CatTypes.ContentType && cat.Active.Value
                                        select new { cat.CatValId, cat.Val }).ToList();
                        ConTypes.Add(new { CatValId, Val });

                        return ConTypes.OrderBy(p => p.CatValId).ToDictionary(t => t.CatValId, t => t.Val);
                    #endregion
                    case DataType.LoadAll:
                        #region LoadAll
                        long kA = long.Parse(((int)CatTypes.KnowledgeAreas).ToString());
                        var algo = dbContext.CatVals.Where(al => al.CatTypeId == kA).ToList();
                        var artTree = (from _k in dbContext.CatVals
                                       where _k.CatTypeId == kA
                                       select new
                                       {
                                           KAreaName = _k.Val,
                                           Themes = dbContext.CatVals.Where(_t => _k.CatValId == _t.CatParent0).Select(_t => new
                                           {
                                               ThemeName = _t.Val,
                                               Articls = dbContext.Articles.Where(_a => _t.CatValId == _a.ThemeId).Select(_a => new
                                               {
                                                   ArticleId = _a.ArticleId,
                                                   ArticleTitle = _a.Title,
                                                   ArticleDescription = _a.Description
                                               }).ToList()
                                           }).ToList()
                                       }).ToList();

                        return JsonConvert.SerializeObject(artTree);

                    #endregion
                    case DataType.LoadById:
                        #region LoadById
                        art = JsonConvert.DeserializeObject<Article>(DataObject);
                        newArt = dbContext.Articles.Where(a => a.ArticleId == art.ArticleId).FirstOrDefault();
                        return newArt;
                    #endregion
                    case DataType.New:
                        CurrentArticle = new Article();
                        CurrentArticle.ArticleId = Guid.NewGuid();
                        break;
                    case DataType.Edit:
                        CurrentArticle = dbContext.Articles.Where(a => a.ArticleId == ArticleId).FirstOrDefault();
                        if (CurrentArticle == null) throw new ArticleControllerException(string.Format("Article not found: {0}", ArticleId));
                        break;
                    case DataType.Save:
                        #region Save
                        newArt = dbContext.Articles.Where(a => a.ArticleId == CurrentArticle.ArticleId).FirstOrDefault();
                        bool _new = newArt == null;
                        if (_new)
                        {
                            newArt = new Article();
                            newArt.ArticleId = CurrentArticle.ArticleId;
                            newArt.CreationDate = DateTime.Now;
                            newArt.ArticleContents = null;
                        }
                        newArt.Content = CurrentArticle.Content;
                        newArt.Description = CurrentArticle.Description;
                        newArt.KnowledgeAreaId = CurrentArticle.KnowledgeAreaId;
                        newArt.ModificationDate = DateTime.Now;
                        newArt.Tags = CurrentArticle.Tags;
                        newArt.ThemeId = CurrentArticle.ThemeId;
                        newArt.Title = CurrentArticle.Title;

                        foreach (ArticleContent aC in CurrentArticle.ArticleContents)
                        {
                            if ((newArt.ArticleContents == null))
                            {
                                newArt.ArticleContents = CurrentArticle.ArticleContents;
                                break;
                            }
                            newAc = newArt.ArticleContents.Where(ac => ac.ArticleContentId == aC.ArticleContentId).FirstOrDefault();

                            bool _newAc = newAc == null;
                            if (_newAc)
                            {
                                newAc = new ArticleContent();
                                newAc.ArticleId = aC.ArticleId;
                                newAc.ArticleContentId = aC.ArticleContentId;
                                newAc.CreationDate = aC.CreationDate;
                            }
                            newAc.ModificationDate = aC.ModificationDate;
                            newAc.Object = aC.Object;
                            newAc.ObjectIndex = aC.ObjectIndex;
                            newAc.ObjectTypeId = aC.ObjectTypeId;
                            newAc.ObjectUrl = aC.ObjectUrl;

                            if (_newAc) newArt.ArticleContents.Add(newAc);
                        }

                        if (_new) dbContext.Articles.Add(newArt);

                        dbContext.SaveChanges();

                        #endregion
                        break;
                    case DataType.DeleteById:
                        #region DeleteById
                        art = JsonConvert.DeserializeObject<Article>(DataObject);
                        newArt = dbContext.Articles.Where(a => a.ArticleId == art.ArticleId).FirstOrDefault();
                        if (newArt != null)
                            dbContext.Articles.Remove(newArt);
                        else
                            throw new ArticleControllerException("Article doesn't exist. Id: " + art.ArticleId.ToString());
                        dbContext.SaveChanges();
                        #endregion
                        break;
                    case DataType.UpdateById:
                        #region UpdateById
                        art = JsonConvert.DeserializeObject<Article>(DataObject);
                        newArt = dbContext.Articles.Where(a => a.ArticleId == art.ArticleId).FirstOrDefault();
                        newArt.Content = art.Content;
                        newArt.Description = art.Description;
                        newArt.KnowledgeAreaId = art.KnowledgeAreaId;
                        //newArt.Tags = art.Tags;
                        newArt.ThemeId = art.ThemeId;
                        newArt.Title = art.Title;

                        dbContext.SaveChanges();
                        #endregion
                        break;
                    case DataType.FindByKArea:
                        #region FindByArea
                        kArea = JsonConvert.DeserializeObject<List<int>>(DataObject);
                        return dbContext.Articles.Where(a => a.KnowledgeAreaId == kArea.FirstOrDefault());
                        #endregion
                        break;
                    case DataType.FindByTheme:
                        #region FindByTheme
                        theme = JsonConvert.DeserializeObject<List<int>>(DataObject);
                        return dbContext.Articles.Where(a => a.ThemeId == theme.FirstOrDefault());
                        #endregion
                        break;
                    case DataType.FindByTitle:
                        art = JsonConvert.DeserializeObject<Article>(DataObject);
                        return dbContext.Articles.Where(a => a.Title.ToLower().Contains(art.Title.ToLower()));
                        break;
                    case DataType.FindByDescrip:
                        art = JsonConvert.DeserializeObject<Article>(DataObject);
                        return dbContext.Articles.Where(a => a.Description.ToLower().Contains(art.Description.ToLower()));
                        break;
                    case DataType.FindByContent:
                        art = JsonConvert.DeserializeObject<Article>(DataObject);
                        return dbContext.Articles.Where(a => a.Content.ToLower().Contains(art.Content.ToLower()));
                        break;
                    case DataType.FindByTags:
                        //tags = JsonConvert.DeserializeObject<List<int>>(DataObject);
                        //var res = from ar in dbContext.Article
                        //          where ar.Tags.Any(t => tags.Contains(t.CatId))
                        //          select ar;
                        break;
                    default:
                        break;
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("ArticleController.GetData({0}) /r/n {1}", dataType, ex.Message), ex.InnerException);
            }
        }
        #endregion

        #region Enums
        public enum DataType
        {
            AddContent,
            CanRemoveContent,
            RemoveContent,
            Load,
            LoadThems,
            LoadKAreas,
            LoadTags,
            LoadContenType,
            LoadAll,
            LoadById,
            New,
            Edit,
            Save,
            DeleteById,
            UpdateById,
            FindByKArea,
            FindByTheme,
            FindByTitle,
            FindByDescrip,
            FindByContent,
            FindByTags,
            ValidateContent
        }

        #endregion
    }

    public class ArticleControllerException : Exception
    {
        public ArticleControllerException() : base() { }
        public ArticleControllerException(string message) : base(message) { }
        public ArticleControllerException(string message, System.Exception inner) : base(message, inner) { }
    }
}
