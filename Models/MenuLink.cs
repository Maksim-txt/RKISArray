namespace Models;

public class MenuLink
{
    private string _link = "";
    private string _name = "";

    public string Link
    {
        get => _link;
        set
        {
            _link = value;
        }
    }

    public string Name
    {
        get => _name;
        set
        {
            _name = value;
        }
    }

    public MenuLink(string name, string link)
    {
        Name = name;
        Link = link;
    }

}