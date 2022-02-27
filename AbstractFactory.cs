namespace FactoryPattern
{

	public class NavigationBarAbstractFactory
	{
		public NavigationBarAbstractFactory(IUIFactory factory) => factory.CreateButton();
	}

	public class DropdownMenuAbstractFactory
	{
		public DropdownMenuAbstractFactory(IUIFactory factory) => factory.CreateButton();
	}

	public interface IUIFactory
	{
		public Button CreateButton();

	}

	public class Apple : IUIFactory
	{
		public Button CreateButton()
		{
			return new Button { Type = "IOS Button" };
		}
	}

	public class Android : IUIFactory
	{
		public Button CreateButton()
		{
			return new Button { Type = "Android Button" };
		}
	}
}
