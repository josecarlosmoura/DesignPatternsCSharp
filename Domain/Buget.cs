namespace Domain
{
	public class Buget
	{
		public double Value { get; private set; }
		public IList<Item> Itens { get; private set; }

		public Buget(double value)
		{
			Value = value;
			Itens = new List<Item>();
		}

		public void AddItem(Item item)
		{
			Itens.Add(item);
		}
	}
}
