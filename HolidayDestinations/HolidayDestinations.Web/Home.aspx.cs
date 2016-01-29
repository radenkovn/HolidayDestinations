namespace HolidayDestinations.Web
{
    using System;
    using System.Linq;
    using System.Web.ModelBinding;

    using HolidayDestinations.Services.Contracts;
    using Ninject;
    using Models;
    using Cache;

    public partial class Home : System.Web.UI.Page
    {
        private const int DefaultPageSize = 5;

        [Inject]
        public IDestinationsService DestinationsService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Destination> DestinationsRepeater_GetData([QueryString]string page)
        {
            Response.Cache.SetCacheability(System.Web.HttpCacheability.Public);
            if (CachedData.cachedDestinations == null)
            {
                CachedData.cachedDestinations = this.DestinationsService.GetLatest().ToList().AsQueryable();
                CachedData.cachedDate = DateTime.Now;
            }
            else
            {
                if (CachedData.cachedDate.AddMinutes(5) < DateTime.Now)
                {
                    CachedData.cachedDestinations = this.DestinationsService.GetLatest().ToList().AsQueryable();
                    CachedData.cachedDate = DateTime.Now;
                }
            }
            int currentPage;
            var firstPage = CachedData.cachedDestinations.Take(DefaultPageSize);
            var secondPage = CachedData.cachedDestinations.Skip(DefaultPageSize).Take(DefaultPageSize);
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