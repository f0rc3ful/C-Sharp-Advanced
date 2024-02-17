namespace SharkTaxonomy
{
    public class Shark
    {
		private string kind;

		public string Kind
		{
			get { return kind; }
			set { kind = value; }
		}
		private int length;

		public int Length
		{
			get { return length; }
			set { length = value; }
		}
		private string food;

		public string Food
		{
			get { return food; }
			set { food = value; }
		}
		private string habitat;

		public string Habitat
		{
			get { return habitat; }
			set { habitat = value; }
		}
		public Shark(string kind, int length, string food, string habitat)
		{
			Kind = kind;
			Length = length;
			Food = food;
			Habitat = habitat;
		}
        public override string ToString()
        {
            return $"{kind} shark: {length}m long.\nCould be spotted in the {habitat}, typical menu: {food}";
        }
    }
}
