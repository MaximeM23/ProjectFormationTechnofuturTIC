using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Service
{
    public interface IService<T> : IGetAllService<T>,IGetOneService<T>,IInsertService<T>, IUpdateService<T>,IDeleteService<T>
    {
    }

    public interface IGetAllService<T>
    {
        IEnumerable<T> GetAll();
    }

    public interface IGetOneService<T>
    {
        T GetOne(int Id);
    }

    public interface IInsertService<T>
    {
        int Insert(T Value);
    }

    public interface IUpdateService<T>
    {
        bool Update(T Value);
    }

    public interface IDeleteService<T>
    {
        bool Delete(int Id);
    }
}
