﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;


namespace DataBaseModel
{
    public partial class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        internal ISFDSEntities2 Context;
        internal DbSet<TEntity> DbSet;

        public GenericRepository(ISFDSEntities2 context)
        {
            Context = context;
            DbSet = context.Set<TEntity>();
        } 

        public virtual IEnumerable<TEntity> Get()
        {
            IQueryable<TEntity> query = DbSet;
            return query.ToList();
        } 
        public virtual TEntity GetById(object id)
        {
            return DbSet.Find(id);
        }
        public virtual void Insert(TEntity entity)
        {
            DbSet.Add(entity);
        }
        public virtual void Delete(object id)
        {
            TEntity entityToDelete = DbSet.Find(id);
            DbSet.Remove(entityToDelete);
        }

        public virtual void Delete(TEntity entityToDelete)
        {
            if (Context.Entry(entityToDelete).State == EntityState.Detached)
            {
                DbSet.Attach(entityToDelete);
            }
            DbSet.Remove(entityToDelete);
        }
        public virtual void Update(TEntity entityToUpdate)
        {
            DbSet.Attach(entityToUpdate);
            Context.Entry(entityToUpdate).State = EntityState.Modified;
        }
    }
}
