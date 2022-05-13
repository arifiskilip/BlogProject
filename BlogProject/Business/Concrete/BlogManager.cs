using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDa;
        public BlogManager(IBlogDal blogDal)
        {
            _blogDa = blogDal;
        }
        public void Add(Blog blog)
        {
            _blogDa.Add(blog);
        }

        public void Delete(Blog blog)
        {
            _blogDa.Delete(blog);
        }

        public List<Blog> GetAll()
        {
            return _blogDa.GetAll();
        }

        public Blog GetById(int id)
        {
            return _blogDa.Get(p => p.BlogId == id);
        }

        public void Update(Blog blog)
        {
            _blogDa.Update(blog);
        }
    }
}
