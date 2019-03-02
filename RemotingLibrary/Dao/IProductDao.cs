using RemotingLibrary.Models;
using System.Collections.Generic;

namespace RemotingLibrary.Dao
{
    public interface IProductDao
    {
        Product FindById(int id);
        List<Product> GetAll();
    }
}
