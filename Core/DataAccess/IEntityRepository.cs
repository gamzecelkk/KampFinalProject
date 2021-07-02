using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //class: ref tip 
    //IEntity : IEntity olabilir veya IEntity implemente eden bir nesne olabilir.
    //new() : new'lenebilir olmalı (IEntity newlenemez)
    public interface IEntityRepository<T> where T:class,IEntity,new() //generic repo
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);    

        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        
    }
}
