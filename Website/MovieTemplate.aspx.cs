using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Website
{
    public partial class MovieTemplate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            StringBuilder html = new StringBuilder();


            foreach (Movie movie in MovieMananger.GetMovies())
            {
                if (movie.Id == 1)
                {
                    html.Append("<div class='content'>");

                    //Left column
                    html.Append("<div class='left-column'>");
                    html.Append("<div class='image-movie'>");

                    //Movie image
                    html.Append("<img src='Image/Marvel.jpg' alt='movie image' width='420' height='630'/>");
                    html.Append("</div>");

                    //Movie trailer
                    html.Append("<div class='movie-trailer'>");
                    html.Append("<div class='video'>");
                    html.Append("<iframe width='420' height='260' allow='fullscreen' src='https://www.youtube-nocookie.com/embed/eOrNdBpGMv8?autoplay=1&start=0&rel=0&enablejsapi=1&origin=https%3A%2F%2F'>");
                    html.Append("</iframe>");
                    html.Append("</div>");
                    html.Append("</div>");

                    //Close left column
                    html.Append("</div>");

                    //Right column
                    html.Append("<div class='right-column'>");

                    html.Append($"<h1 class='movie-name'>{movie.Title}</h1>");

                    //html.Append("")
                    //Movie info
                    html.Append("<div class='movie-info'>");
                    html.Append("<div class='info'>");
                    html.Append("<div class='row1'>");

                    // ########## CENSUR ##########

                    //field name
                    html.Append("<div class='field-name'>");

                    //field-label
                    html.Append("<div class='field-label'>Censur:</div>");

                    //Field Item
                    html.Append("<div class='field-item'>");
                    html.Append("<div class='movie-censur'>");
                    html.Append("<div class='censur'>Tilladt for børn over 15</div>");
                    html.Append("</div>");
                    html.Append("</div>");
                    //field name close
                    html.Append("</div>");

                    // ########## SHOW TIME ##########
                    //field-name
                    html.Append("<div class='field-name'>");

                    //field-label
                    html.Append("<div class='field-label'>Show Time:</div>");

                    //Field Item
                    html.Append($"<div class='field-item'>{movie.Showtime}</div>");

                    //field name close
                    html.Append("</div>");

                    // ########## ORIGINAL TITLE ##########
                    //field-name
                    html.Append("<div class='field-name'>");

                    //field-label
                    html.Append("<div class='field-label'>Original title:</div>");

                    //Field Item
                    html.Append($"<div class='field-item'>{movie.Title}</div>");

                    //field name close
                    html.Append("</div>");

                    // ########## ACTOR ##########
                    //field-name
                    html.Append("<div class='field-name'>");

                    //field-label
                    html.Append("<div class='field-label'>Actors:</div>");

                    //Field Item
                    html.Append("<div class='field-item'>Skuespiller!</div>");

                    //field name close
                    html.Append("</div>");

                    // ########## Genre ##########
                    //field-name
                    html.Append("<div class='field-name'>");

                    //field-label
                    html.Append("<div class='field-label'>Genre:</div>");

                    //Field Item
                    html.Append($"<div class='field-item'>{movie.Genre}</div>");
                    //field name close
                    html.Append("</div>");

                    html.Append("</div>");
                    html.Append("</div>");
                    html.Append("</div>");

                    //Body Info
                    html.Append("<div class='body-info'>");
                    html.Append("<div class='body-text'>");
                    html.Append($"<p>{movie.Description}</p>");
                    //Close body text
                    html.Append("</div>");

                    //Close body info
                    html.Append("</div>");
                    html.Append("</div>");

                    //Close Right column
                    html.Append("</div>");

                    //Close content
                    html.Append("</div>");
                }
            }
            Movie.Controls.Add(new Literal { Text = html.ToString() });
        }
    }
}