namespace HolidayDestinations.Web
{
    using System;
    using System.Collections;
    using System.Linq;
    using System.Web.ModelBinding;

    using HolidayDestinations.Services.Contracts;
    using Ninject;

    public partial class Home : System.Web.UI.Page
    {
        private const int DefaultPageSize = 5;

        [Inject]
        public IDestinationsService DestinationsService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IEnumerable DestinationsRepeater_GetData([QueryString]string page)
        {
            int currentPage;
            var firstPage = this.DestinationsService.GetLatest().Take(DefaultPageSize);
            if (!int.TryParse(page, out currentPage))
            {
                return firstPage;
            }
            if (currentPage == 1)
            {
                return firstPage;
            }
            if (currentPage == 2)
            {
                return this.DestinationsService.GetLatest().Skip(DefaultPageSize).Take(DefaultPageSize);
            }
            return firstPage;
        }
    }
}