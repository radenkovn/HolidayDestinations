namespace HolidayDestinations.Web
{
    using System;
    using System.Linq;
    using System.Web.ModelBinding;
    using System.Linq.Dynamic;
    using Ninject;

    using HolidayDestinations.Services.Contracts;

    public partial class Destinations : System.Web.UI.Page
    {
        private const string OrderType = "Descending";
        [Inject]
        public IDestinationsService DestinationsService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public IQueryable<Models.Destination> lvDestinations_GetData([QueryString]string orderBy)
        {
            var result = this.DestinationsService.GetAll();

            // TODO: validate orderBy parameter
            try
            {
                result = orderBy != null ? result.OrderBy(orderBy + " " + OrderType) : result.OrderBy(x => x.Id);
            }
            catch
            {
                Response.Redirect("/Destinations");
            }

            return result;
        }
    }
}