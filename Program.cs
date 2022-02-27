namespace FactoryPattern
{
    internal static class Program
    {
        static void Main()
        {

            new NavigationBar();  // factory 
            new DropdownMenu();


            new NavigationBarFactoryMethod();  // factory method
            new DropdownMenuFactoryMethod();
            new AndroidNavigationBar();
            new AndroidDropdownMenu();

            new NavigationBarAbstractFactory(new Android());  // Abstract Factory
            new DropdownMenuAbstractFactory(new Android());

            new NavigationBarAbstractFactory(new Apple());  // Abstract Factory
            new DropdownMenuAbstractFactory(new Apple());
        }
    }
}