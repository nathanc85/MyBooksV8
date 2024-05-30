using MyBooks.DataAccess.Data;
using MyBooks.DataAccess.Repository.IRepository;
using MyBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBooks.DataAccess.Repository
{
    internal class ProductRepository : Repository<Product>, IProductRepository
    {
        public ApplicationDbContext _db;

        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Product obj)
        {
            _db.Products.Update(obj);
        }
    }
}
