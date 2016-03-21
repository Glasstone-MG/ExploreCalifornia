using ExploreCalifornia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExploreCalifornia.API
{
    public partial class APIClient : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpClient Client = new HttpClient();
            Client.BaseAddress = new Uri("http://localhost:1987/");
            Tour nuevoTour = new Tour()
            {
                Name = "Bici en el Golden Gate", Description="Disfrutar del atardecer pedaleando", IncludesMeals=true, Length=1, Price=(decimal)15.15, Rating="Easy"
            };
            Client.PostAsJsonAsync("api/Tours", nuevoTour);

        }
    }
}