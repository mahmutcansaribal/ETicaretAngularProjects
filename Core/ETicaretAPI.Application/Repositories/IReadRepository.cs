using ETicaretAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Repositories
{
    //Class oldugunu söylüyoruz.
    // T herhangi bir class olabilir product customer vs..
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
    {
        //Read İşlemleri.
        //Sorgu üzerinde çalışacaksak IQueryable kullanılır. 
        IQueryable<T> GetAll();
        IQueryable<T> GetWhere(Expression<Func<T,   bool>>  method);
        //Asenkron Çalışacaktır.
        Task<T> GetSinglAsync(Expression<Func<T, bool>> method);
        Task<T> GetByIdAsync(string id);
    }
}
