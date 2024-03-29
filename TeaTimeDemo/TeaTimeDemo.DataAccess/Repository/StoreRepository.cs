using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaTimeDemo.Data;
using TeaTimeDemo.DataAccess.Repository.IRepository;
using TeaTimeDemo.Models;

namespace TeaTimeDemo.DataAccess.Repository
{
    public class StoreRepository : Repository<Store>,
    IStoreRepository
    {
        private ApplicationDBContext _db;
        public StoreRepository(ApplicationDBContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Store obj)
        {
            _db.Stores.Update(obj);
        }
    }
}
