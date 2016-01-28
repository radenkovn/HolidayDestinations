namespace HolidayDestinations.Web.Private
{
    using System;
    using System.Collections;
    using System.Linq;

    using Ninject;

    using HolidayDestinations.Services.Contracts;
    using Models;
    using Microsoft.AspNet.Identity;
    using System.Web.UI.WebControls;
    using System.IO;
    public partial class AddDestination : System.Web.UI.Page
    {
        [Inject]
        public ILocationsService LocationsService { get; set; }

        [Inject]
        public ICategoriesService CategoriesService { get; set; }

        [Inject]
        public IDestinationsService DestinationsService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void fvAddDestination_InsertItem()
        {
            var newDestination = new Destination()
            {
                UserId = User.Identity.GetUserId(),
                Date = DateTime.UtcNow.AddDays(3)
            };

            var fileUploader = this.fvAddDestination.FindControl("imageUploadControl") as FileUpload;
            string filepath = string.Empty;
            if (fileUploader.HasFile)
            {
                string filename = Path.GetFileName(fileUploader.FileName);
                filepath = "/Images/" + filename;
                fileUploader.SaveAs(Server.MapPath("~" + filepath));
            }
            filepath = "." + filepath;
            newDestination.PhotoUrl = filepath;
            TryUpdateModel(newDestination);
            if (ModelState.IsValid)
            {
                try
                {
                    this.DestinationsService.Create(newDestination);
                }
                catch
                {
                    Response.Redirect("/Private/AddDestination");
                }
            }
        }

        public IQueryable<Category> ddlInsertCategory_GetData()
        {
            return this.CategoriesService.GetAll();
        }

        public IQueryable<Location> ddlInsertLocation_GetData()
        {
            return this.LocationsService.GetAll();
        }
    }
}