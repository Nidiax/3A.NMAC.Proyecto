using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Work_IO.Models;
using Microsoft.EntityFrameworkCore;

namespace Work_IO.Services
{
   public class SQLRepository<T> : IRepositoryW<T> where T : BaseEntity
   {
        protected readonly AppDBContext context;
        private DbSet<T> Entities;
        public SQLRepository(AppDBContext context)
        {
            this.context = context;
            Entities = context.Set<T>();
        }

        public SQLRepository()
        {

        }


        //Métodos de la interfaz
        public void Delete(T obj)
        {
            if (obj == null) throw new ArgumentNullException("Entity");
            if (obj.Id <= 0) throw new ArgumentNullException("Entity");
            obj.UpdatedAT = DateTime.Now;
            obj.Estatus = false;
            var entity = Entities.Attach(obj);
            entity.State = EntityState.Modified;
            context.SaveChanges();
        }

        public T Get(int id)
        {
            return Entities.SingleOrDefault(x => x.Id == id);
        }

        public IEnumerable<T> GetAll()
        {
            return Entities.AsEnumerable();
        }

        public int Insert(T obj)
        {
            if (obj == null) throw new ArgumentNullException("Entity");
            Entities.Add(obj);
            context.SaveChanges();
            return obj.Id;
        }

        public void Update(T obj)
        {
            if (obj == null) throw new ArgumentNullException("Entity");
            if (obj.Id <= 0) throw new ArgumentNullException("Entity");
            var entity = Entities.Attach(obj);
            entity.State = EntityState.Modified;
            context.SaveChanges();
        }
   }
}
