using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IBooksDbService<T>
    {
        Task CreateAsync(T item);
        Task UpdateAsync(T item);
        Task DeleteAsync(int itemId);
        T Get(int itemId);
        IEnumerable<T> GetAll();
    }
}
