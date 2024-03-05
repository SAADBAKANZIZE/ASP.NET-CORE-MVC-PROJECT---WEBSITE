﻿using Bulky.DataAccess.Repository.IRepositoory;
using Bulky.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.Repository.IRepository
{
   public interface ICategoryRepository : IRepository<Category>
    {
        void update(Category obj);
        public Category GetById(int categoryId);


    }
}
