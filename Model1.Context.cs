﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Exam1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Exam11Entities2 : DbContext
    {
        public Exam11Entities2()
            : base("name=Exam11Entities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Posetit> Posetit { get; set; }
        public DbSet<Sotrudnik> Sotrudnik { get; set; }
        public DbSet<Zapisi> Zapisi { get; set; }
        public DbSet<Zayavky> Zayavky { get; set; }
    }
}
