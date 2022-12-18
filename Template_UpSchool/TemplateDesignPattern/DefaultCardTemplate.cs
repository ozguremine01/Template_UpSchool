namespace Template_UpSchool.TemplateDesignPattern
{
    public class DefaultCardTemplate : UserCardTemplate
    {
        protected override string SetFooter()
        {
            return string.Empty;
        }

        protected override string SetImage()
        {
            return "<img class='card-img-top' src='/Images/149071.jpg' style='width:50px; height:50px;'>";

        }
    }
}
