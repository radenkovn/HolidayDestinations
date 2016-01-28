using HolidayDestinations.Models;
using HolidayDestinations.Services.Contracts;
using Ninject;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HolidayDestinations.Web
{
    public partial class Home : System.Web.UI.Page
    {

        [Inject]
        public IDestinationsService DestinationsService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IEnumerable DestinationsRepeater_GetData()
        {
            var destinations = this.DestinationsService.GetLatest();
            return destinations;
        }
    }
}