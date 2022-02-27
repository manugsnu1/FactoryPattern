namespace FactoryPattern
{

    //This is an example of Factory pattern
    // where creation of factory is handled at one place
    // So if we want to change from Default Button to Defualt Button 1 
    // we will have to do it at one place only


    public class NavigationBar
    {
        public NavigationBar() => ButtonFactory.CreateButton();
    }

    public class DropdownMenu
    {
        public DropdownMenu() => ButtonFactory.CreateButton();
    }

    public class ButtonFactory
    {
        public static Button CreateButton()
        {
            return new Button { Type = "Default Button" };  // We can change the button type here
        }

    }

    public class Button
    {
        public string Type { get; set; }
    }

}
