namespace SharkTaxonomy
{
    public class Classifier
    {
		private int capacity;

		public int Capacity
		{
			get { return capacity; }
			set { capacity = value; }
		}
		private List<Shark> species;

		public List<Shark> Species
		{
			get { return species; }
			set { species = value; }
		}

		public int GetCount
		{
            get { return Species.Count(); }
        }

		public Classifier(int capacity)
		{
			Species = new List<Shark>();
			Capacity = capacity;
		}
		public void AddShark(Shark shark)
		{
			if (Species.Count + 1 <= capacity)
			{
                if (!Species.Contains(shark))
                {
                    Species.Add(shark);
                }
            }
		}
		public bool RemoveShark(string kind)
		{
			int index = Species.FindIndex(shark => shark.Kind == kind);
			if (index != -1)
			{ 
				Species.RemoveAt(index);
				return true;
			}

			return false;
		}

		public string GetLargestShark()
		{
            Shark longestShark = Species.OrderByDescending(shark => shark.Length).FirstOrDefault();
			return longestShark.ToString();
		}
		public int GetAverageLength()
		{
			int averageLength = Species.Sum(shark => shark.Length) / Species.Count();
			return averageLength;
		}
		public string Report()
		{
			return $"{species.Count} sharks classified:\n{string.Join("\n", Species)}";
		}
	}
}
