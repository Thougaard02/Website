using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Website
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            StringBuilder html = new StringBuilder();

            foreach (Movie movie in MovieMananger.GetMovies())
            {
                html.Append("<div class='col-md-3'>");
                html.Append("<a class='movie' href='/MovieTemplate'>");
                html.Append("<div class='Movie-image'>");
                html.Append("<img src= 'Image/Marvel.jpg' width='230' height='345' alt='MOVIE NAME' />");
                html.Append("</div>");

                html.Append("<h2 class='Movie-title'>");
                html.Append($"<span class='Movie-name'>{movie.Title}");
                html.Append("</span>");
                html.Append("</h2>");

                html.Append("<button class='Movie-button' type='button' >Køb");
                html.Append("<i class='fa fa-ticket' aria-hidden='true' >");
                html.Append("</i>");
                html.Append("</button>");
                html.Append("</a>");
                html.Append("</div>");
            }

            MovieTitle.Controls.Add(new Literal { Text = html.ToString() });
        }


    }
}