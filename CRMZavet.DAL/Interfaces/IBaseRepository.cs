using System.Collections.Generic;
using System.Threading.Tasks;
using CRMZavet.DAL.Entities;
using System.Data.Entity;

namespace CRMZavet.DAL.Interfaces
{
    public interface IBaseRepository<T> 
        where T : IdProvider 
    {
        Task<IEnumerable<T>> GetAllAsync(); // получение всех объектов
        Task<T> GetAsync(int id); // получение одного объекта по id
        void Create(T item); // создание объекта
        void Update(T item); // обновление объекта
        void Delete(int id);
        DbSet<T> Entities { get; }
    }
}