namespace Domain
{
	public class Item
	{
		public string Name { get; private set; }
		public double Value { get; private set; }

		public Item(string name, double value) 
		{ 
			this.Name = name;
			this.Value = value;
		}
    }
}
