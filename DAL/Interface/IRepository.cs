using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interface
{
    public interface IRepository<T> : IGetAllRepository<T>,IGetOneRepository<T>,IDeleteRepository<T>,IUpdateRepository<T>,IInsertRepository<T>
    {
    }

    public interface IGetAllRepository<T>
    {
        public IEnumerable<T> GetAll();
    }

    public interface IGetOneRepository<T>
    {
        public T GetOne(int value);
    }

    public interface IDeleteRepository<T>
    {
        public int Delete(int value);
    }

    public interface IUpdateRepository<T>
    {
        public bool Update(T newValue);
    }

    public interface IInsertRepository<T>
    {
        public int Insert(T value);
    }
}
