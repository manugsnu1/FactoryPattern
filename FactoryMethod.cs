namespace FactoryPattern
{
	public abstract class Element
	{
		protected abstract Button CreateButton();  // Factory Method

		public Element() => CreateButton();
	}

	public class NavigationBarFactoryMethod : Element   // Building blocks
	{                                                   // using inheritence for a structure    
		protected override Button CreateButton()
		{
			return new Button { Type = "Default Button" };
		}
	}

	public class DropdownMenuFactoryMethod : Element
	{
		protected override Button CreateButton()
		{
			return new Button { Type = "Default Button" };
		}
	}

	public class AndroidNavigationBar : Element
	{
		protected override Button CreateButton()
		{
			return new Button { Type = "Android Button" };
		}
	}

	public class AndroidDropdownMenu : Element
	{
		protected override Button CreateButton()
		{
			return new Button { Type = "Android Button" };
		}
	}
}
