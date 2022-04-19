public class Parallelogram
{
//C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
	public Parallelogram()
	{
	}

//C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
	public void Dispose()
	{
	}

//C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
	public void Set()
	{
		Quadrangle.Set();
	}

//C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
	public void Print()
	{
		Console.Write("Parallelogram: ");
		Polygons.Print();
	}

//C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
	public bool Check()
	{
		Coordinate YAxis = new Coordinate() {x = 0, y = 1};
		List<Coordinate> c = GetCoor();
		List<double> value = new List<double>();
		value.Resize(0);
		for (int i = 0;i < 3;i++)
		{
			for (int j = i + 1 ;j < 4;j++)
			{
	//C++ TO C# CONVERTER TODO TASK: The following line was determined to contain a copy constructor call - this should be verified and a copy constructor should be created:
	//ORIGINAL LINE: if(MultiCoor(VectorCoor(c[i],c[j]),YAxis)==0)
				if (MultiCoor(VectorCoor(new List<Coordinate>(c[i]), new List<Coordinate>(c[j])), new Coordinate(YAxis)) == 0)
				{
					value.Add(Module(new List<Coordinate>(c[i]), new List<Coordinate>(c[j])));
				}
    
			}
		}
		if (value.Count == 2 && value[0] == value[1])
		{
			return true;
		}
		else
		{
			Console.Write("Wrong input!Again.\n");
			return false;
		}
	}
}