using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        EfCategoyRepository efCategoyRepository;

        public CategoryManager()
        {
            efCategoyRepository = new EfCategoyRepository();
        }

        public void CategoryAdd(Category category)
        {
            efCategoyRepository.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            efCategoyRepository.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            efCategoyRepository.Update(category);
        }

        public Category GetById(int id)
        {
            return efCategoyRepository.GetById(id);
        }

        public List<Category> GetList()
        {
            return efCategoyRepository.GetListAll();
        }
    }
}
