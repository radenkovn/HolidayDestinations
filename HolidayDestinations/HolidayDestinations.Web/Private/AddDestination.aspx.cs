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
    using System.Text.RegularExpressions;
    public partial class AddDestination : System.Web.UI.Page
    {
        private const string PictureRegex = @"([^\s] + (\.(?i)(jpg|png|gif|bmp))$)";

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

                var imagePath = "." + filepath;
                newDestination.PhotoUrl = imagePath;
            }
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
                if (fileUploader.HasFile)
                {
                    fileUploader.SaveAs(Server.MapPath("~" + filepath));
                }
            }
            else
            {
                Response.Redirect("/Private/AddDestination");
            }
            Response.Redirect("/Home");
        }

        public IQueryable<Category> ddlInsertCategory_GetData()
        {
            return this.CategoriesService.GetAll();
        }

        public IQueryable<Location> ddlInsertLocation_GetData()
        {
            return this.LocationsService.GetAll();
        }

        protected void PriceValidate(object source, ServerValidateEventArgs args)
        {
            decimal number;
            args.IsValid = decimal.TryParse((this.fvAddDestination.FindControl("fvInsertPrice") as TextBox).Text, out number) && number > 0;
        }
        protected void DesctiptionValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = (this.fvAddDestination.FindControl("fvInsertDescription") as TextBox).Text.Length >= 10;
        }
        protected void PictureValidate(object source, ServerValidateEventArgs args)
        {
            var fileUploader = (this.fvAddDestination.FindControl("imageUploadControl") as FileUpload);
            if (fileUploader.HasFile)
            {
                string filename = Path.GetFileName(fileUploader.FileName);
                Regex regex = new Regex(@"(.*?)\.(jpg|JPG|jpeg|JPEG|png|PNG|gif|GIF|bmp|BMP)$");
                args.IsValid = regex.IsMatch(filename);
            }
        }
    }
}