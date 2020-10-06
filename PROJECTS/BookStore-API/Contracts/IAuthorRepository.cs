using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore_API.Data;

namespace BookStore_API.Contracts
{
    public interface IAuthorRepository : IRepositoryBase<Author>
    {
    }
}
