using DAL.Interface;
using DAL.Models;
using DAL.Tools;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Connection = Tools.Connection;

namespace DAL.Repository
{
    public class CategoryRepository : BaseRepository, ICategoryRepository
    {
        public CategoryRepository(IConfiguration config) : base(config)
        {
        }

        public int Delete(int value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> GetAllCategoriesByType(int IdType)
        {
            Connection.Command cmd = new Connection.Command("GetAllCategoriesByIdType", true);
            cmd.AddParameter("@IdType", IdType);// Categoy tag
            return _con.ExecuteReader(cmd, Mapper.CategoryToDAO);
        }

        public IEnumerable<Category> GetAllWineTypeCategory(int IdWine,int IdTag)
        {
            Connection.Command cmd = new Connection.Command("GetAllWineTypeCategory", true);
            cmd.AddParameter("@idWine", IdWine);
            cmd.AddParameter("@idTag", IdTag);
            return _con.ExecuteReader(cmd, Mapper.CategoryToDAO);
        }

        public Category GetOne(int value)
        {
            throw new NotImplementedException();
        }

        public int Insert(Category value)
        {
            throw new NotImplementedException();
        }

        public int InsertNewWineCategory(int IdWine, int IdCategory)
        {
            Connection.Command cmd = new Connection.Command("InsertWineCategory", true);
            cmd.AddParameter("@IdWine", IdWine);
            cmd.AddParameter("@IdCategory", IdCategory);
            return _con.ExecuteNonQuery(cmd);
        }

        public bool Update(Category newValue)
        {
            throw new NotImplementedException();
        }


    }
}
