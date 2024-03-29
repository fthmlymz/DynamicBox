﻿using System.Linq.Expressions;

namespace DynamicBox.PurchasingManagement.Core.Repositeries
{
    public interface IGenericRepository<T> where T : class
    {
        //Tüm sorguların ve işlemlerin yapıldığı repo
        Task<T> GetByIdAsync(long id);
        IQueryable<T> GetAll();//(Expression<Func<T, bool>> expression);




        //Daha performanslı çalışabilmek için db ye gitmeden önce orderby, where, gibi sorguları önceden hazırlayıp sonra db ye gitmesine yarar
        //örnek; documentRepository.where(where(x => x.id>5) burayı gidip db den çeker, ardından    .OrderBy.ToListAsync(); ile tekrar db ye gidip performansı düşürür
        IQueryable<T> Where(Expression<Func<T, bool>> expression);


        //var mı yok mu diye any metodu
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);



        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        void Update(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}
