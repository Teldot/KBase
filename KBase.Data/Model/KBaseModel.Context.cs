﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KBase.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class KBaseDBEntities : DbContext
    {
        public KBaseDBEntities()
            : base("name=KBaseDBEntities")
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", System.IO.Directory.GetCurrentDirectory());
            Database.SetInitializer(new DBInitializer());
        }
        
        public virtual DbSet<CatType> CatType { get; set; }
        public virtual DbSet<CatVal> CatVal { get; set; }
        public virtual DbSet<Article> Article { get; set; }
        public virtual DbSet<ArticleContent> ArticleContent { get; set; }
    }
}
