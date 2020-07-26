using System;
using System.Collections.Generic;
using Work_IO.Models;
using System.Text;


namespace Work_IO.Services
{
    //Métodos genéricos
    public interface IRepositoryW<T> where T : BaseEntity
    {
        public IEnumerable<T> GetAll();
       // public Empresa Get(int);
        public T Get(int id);
        public int Insert(T obj);
        public void Update(T obj);
        public void Delete(T obj);
    }
}
