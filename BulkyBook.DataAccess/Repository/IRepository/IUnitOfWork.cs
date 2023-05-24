﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ICateogryRepository Cateogry { get; }

        ICoverTypeRepository CoverType { get; }

        IProductRepository Product { get; }
        ICompanyRepository Company { get; }

        void Save();
    }
}
