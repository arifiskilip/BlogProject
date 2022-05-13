using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAboutService
    {
        void Add(About about);
        void Delete(About about);
        void Update(About about);
        List<About> GetAll();
        About GetById(int id);
    }
}
