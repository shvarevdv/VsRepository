﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataBaseModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ISFDSEntities2 : DbContext
    {
        public ISFDSEntities2()
            : base("name=ISFDSEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<NU> NUs { get; set; }
        public DbSet<DigitalMap> DigitalMaps { get; set; }
        public DbSet<Engine> Engines { get; set; }
        public DbSet<Map> Maps { get; set; }
        public DbSet<MassInertialCharacteristic> MassInertialCharacteristics { get; set; }
        public DbSet<SpacecraftInitialData> SpacecraftInitialDatas { get; set; }
        public DbSet<SpacecraftsEngine> SpacecraftsEngines { get; set; }
        public DbSet<SpaceсraftCommonData> SpaceсraftCommonData { get; set; }
    }
}
