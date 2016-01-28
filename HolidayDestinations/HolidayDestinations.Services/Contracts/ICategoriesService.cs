﻿namespace HolidayDestinations.Services.Contracts
{
    using Models;
    using System.Linq;

    public interface ICategoriesService
    {
        IQueryable<Category> GetAll();
    }
}
