using RemotingLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemotingLibrary.Dao
{
    public interface IProductDao
    {
        Product Find();
        List<Product> GetAll();
    }
}
