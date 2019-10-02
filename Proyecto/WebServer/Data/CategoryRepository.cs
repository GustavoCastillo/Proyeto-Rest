using BookStore.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace WebServer.Data
{
    public class CategoryRepository
    {
        public BookStoreContext Context { get; }

        public CategoryRepository(BookStoreContext context)
        {
            Context = context;
        }

        public Category[] Get()
        {
            return Context.Category.ToArray();
        }
        public Category Get(int id)
        {
            return Context.Category.Find(id);
        }
        public int Add(Category viewModel)
        {


            Context.Category.Add(viewModel);

            Context.SaveChanges();

            return viewModel.Id;
        }

        public void Update(int id, Category model)
        {
            var match = Context.Category.FirstOrDefault(m => m.Id == id);

            if (match != null)
            {
                model.Id = id;
                match.Description = model.Description;
                match.Name = model.Name;
                Context.Category.Update(match);

                Context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var match = Context.Category.FirstOrDefault(m => m.Id == id);

            if (match != null)
            {
                Context.Category.Remove(match);
                Context.SaveChanges();
            }
        }
    }
}
