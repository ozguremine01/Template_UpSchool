using System.Text;

namespace Template_UpSchool.TemplateDesignPattern
{
    public class GoldCardTemplate : UserCardTemplate
    {
        protected override string SetFooter()
        {
            var sb = new StringBuilder();
            sb.Append("<a href='#' class='card-link'>Profili Gör</a>");
            sb.Append("<a href='#' class='card-link'>Mesaj Gönder</a>");
            return sb.ToString();
        }

        protected override string SetImage()
        {
            return $"<img class='card-img-top' src='{AppUser.Image}' style='width:50px; height:50px;'>";

        }
    }
}
