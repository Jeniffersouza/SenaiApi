using Microsoft.EntityFrameworkCore.Migrations.Operations;
using SenaiApi.Domain.Entidades;
using SenaiApi.Repository.Context;
using SenaiApi.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenaiApi.Repository.Repository
{
    public class GenericRepository<T> : IGenericrepository<T> where T : BaseEntity 
    {
        private ApiContext _context;
        private T entity;

        public GenericRepository(ApiContext context)
        {
            _context = context;
        }
        public IQueryable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);        
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }

        public void Remover(long id)
        {
            var entidade = _context.Set<T>().First(C => C.Id == id);
            _context.Set<T>().Remove(entidade);
            _context.SaveChanges();
        }




        public T Salvar(T entity)
        {
            if ((entity as BaseEntity).Id == 0)
                Add(entity);
            else
                Update(entity);
            _context.SaveChanges();

            return entity;
            
        }
    }
}
