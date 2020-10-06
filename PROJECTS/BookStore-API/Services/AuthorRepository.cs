using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore_API.Contracts;
using BookStore_API.Data;
using Microsoft.EntityFrameworkCore;

namespace BookStore_API.Services
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly ApplicationDbContext _db;
        //Constructor to call upon with name: _db
        public AuthorRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        //Create a new Author
        public async Task<bool> Create(Author entity)
        {
            await _db.Authors.AddAsync(entity);
            return await Save();//returns Save method bool, see if it saved
        }

        //Remove a existing Author
        public async Task<bool> Delete(Author entity)
        {
            _db.Authors.Remove(entity);
            return await Save();
        }
        //Search for Authors by all entities
        public async Task<IList<Author>> FindAll()
        {
            var authors = await _db.Authors.ToListAsync();
            return authors;
        }
        //Search by ID - Book and Author
        public async Task<Author> FindById(int id)//pass in primary key
        {
            var author = await _db.Authors.FindAsync(id);
            return author;
        }
        //Save: shows if methods result is true or false
        public async Task<bool> Save()
        {
            var changes = await _db.SaveChangesAsync();
            return changes > 0;
        }
        //Edit Author Database
        public async Task<bool> Update(Author entity)
        {
            _db.Authors.Update(entity);
            return await Save();
        }
    }
}
