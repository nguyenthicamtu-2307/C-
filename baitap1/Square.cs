public class Square
{
//C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
	public Square()
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
		Console.Write("Square: ");
		Polygons.Print();
	}

//C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
	public bool Check()
	{
		Coordinate YAxis = new Coordinate() {x = 0, y = 1};
		Coordinate XAxis = new Coordinate() {x = 1, y = 0};
		List<Coordinate> c = GetCoor();
		List<double> Xvalue = new List<double>();
		List<double> Yvalue = new List<double>();
		Xvalue.Resize(0);
		Yvalue.Resize(0);
		for (int i = 0;i < 3;i++)
		{
			for (int j = i + 1 ;j < 4;j++)
			{
	//C++ TO C# CONVERTER TODO TASK: The following line was determined to contain a copy constructor call - this should be verified and a copy constructor should be created:
	//ORIGINAL LINE: if(MultiCoor(VectorCoor(c[i],c[j]),YAxis)==0)
				if (MultiCoor(VectorCoor(new List<Coordinate>(c[i]), new List<Coordinate>(c[j])), new Coordinate(YAxis)) == 0)
				{
					Xvalue.Add(Module(new List<Coordinate>(c[i]), new List<Coordinate>(c[j])));
				}
	//C++ TO C# CONVERTER TODO TASK: The following line was determined to contain a copy constructor call - this should be verified and a copy constructor should be created:
	//ORIGINAL LINE: else if(MultiCoor(VectorCoor(c[i],c[j]),XAxis)==0)
				else if (MultiCoor(VectorCoor(new List<Coordinate>(c[i]), new List<Coordinate>(c[j])), new Coordinate(XAxis)) == 0)
				{
					Yvalue.Add(Module(new List<Coordinate>(c[i]), new List<Coordinate>(c[j])));
				}
				else
				{
				}
			}
		}
		if (Xvalue.Count == Yvalue.Count && Xvalue[0] == Yvalue[0])
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