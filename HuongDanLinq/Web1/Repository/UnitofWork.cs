using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webdemo1.Models;

namespace Webdemo1.Repository
{
    public class UnitofWork : IUnitofWork
    {
        private readonly DataContext _dataContext;

        private IBaseService<Category> _categoryBaseService;
        private IBaseService<Product> _productBaseService;
        public UnitofWork(DataContext dataContext) => _dataContext = dataContext;

        public IBaseService<Category> CategoryBaseService => _categoryBaseService =
                    _categoryBaseService ?? new BaseService<Category>(_dataContext);

        public IBaseService<Product> ProductBaseService => _productBaseService =
                    _productBaseService ?? new BaseService<Product>(_dataContext);

        /// <summary>
        /// save change
        /// </summary>
        public void Save() => _dataContext.SaveChanges();

        /// <summary>
        /// save change async
        /// </summary>
        /// <returns></returns>
        public async Task SaveAsync() => await _dataContext.SaveChangesAsync();
    }
}
