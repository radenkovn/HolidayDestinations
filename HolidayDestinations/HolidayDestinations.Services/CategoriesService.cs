namespace HolidayDestinations.Services
{
    using System.Linq;

    using HolidayDestinations.Services.Contracts;
    using Data.Repositories;
    using Models;
    public class CategoriesService : ICategoriesService
    {
        private IRepository<Category> categories;
        public CategoriesService(IRepository<Category> categories)
        {
            this.categories = categories;
        }

        public IQueryable<Category> GetAll()
        {
            return this.categories.All();
        }
    }
}
