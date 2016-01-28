namespace HolidayDestinations.Web
{
    using System;
    using System.Collections;
    using System.Linq;
    using System.Web.ModelBinding;

    using HolidayDestinations.Services.Contracts;
    using Ninject;
    using Models;
    using System.Collections.Generic;
    using System.IO;
    public partial class Home : System.Web.UI.Page
    {
        private const int DefaultPageSize = 5;
        private IQueryable<Destination> cachedDestinations;
        private DateTime cachedDate;

        [Inject]
        public IDestinationsService DestinationsService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IEnumerable DestinationsRepeater_GetData([QueryString]string page)
        {
            if (this.cachedDestinations == null)
            {
                this.cachedDestinations = this.DestinationsService.GetLatest().ToList().AsQueryable();
                this.cachedDate = DateTime.Now;
            }
            else
            {
                if (this.cachedDate.AddMinutes(5) < DateTime.Now)
                {
                    this.cachedDestinations = this.DestinationsService.GetLatest().ToList().AsQueryable();
                    this.cachedDate = DateTime.Now;
                }
            }
            int currentPage;
            var firstPage = this.cachedDestinations.Take(DefaultPageSize);
            var secondPage = this.cachedDestinations.Skip(DefaultPageSize).Take(DefaultPageSize);
            if (!int.TryParse(page, out currentPage))
            {
                return firstPage;
            }
            if (currentPage == 1)
            {
                return firstPage;
            }
            if (currentPage == 2 && secondPage.Count() != 0)
            {
                return secondPage;
            }
            return firstPage;
        }
    }
}