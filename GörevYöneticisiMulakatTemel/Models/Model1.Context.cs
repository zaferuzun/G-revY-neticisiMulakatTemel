﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GörevYöneticisiMulakatTemel.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DB_A633FB_gorevtakipEntities1 : DbContext
    {
        public DB_A633FB_gorevtakipEntities1()
            : base("name=DB_A633FB_gorevtakipEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Jobs> Jobs { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}
