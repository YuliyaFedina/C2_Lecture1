﻿using Generics_6.Model;

namespace Generics_6.Data
{
    internal interface IRepository<TEntity> where TEntity : IEntity
    {
        void Add(TEntity contact);

        void Remove(TEntity contact);

        TEntity GetById(long id);

        TEntity[] GetAll();
    }
}
