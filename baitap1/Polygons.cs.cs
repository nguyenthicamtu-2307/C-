public class Polygons
{
//C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
	public Polygons()
	{
		SetNumVertices(0);
		List<Coordinate> coor = new List<Coordinate>();
		coor.Resize(0);
		SetCoor(coor);
	}

//C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
	public Polygons(int num)
	{
		SetNumVertices(num);
		List<Coordinate> coor = new List<Coordinate>();
		coor.Resize(0);
		for (int i = 0;i < num;i++)
		{
			coor[i] = new Coordinate() {x = 0, y = 0};
		}
		SetCoor(coor);
	}

//C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
	public void Dispose()
	{
	}

//C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
	public void SetNumVertices(int num)
	{
		NumVertices = num;
	}

//C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
	public void SetCoor(List<Coordinate> coor)
	{
		/*
		for(int i=0;i<GetNumVertices();i++){
		    Coor[i]=coor[i];
		}
		*/
	   Coor = coor;
	}

//C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
	public void Set()
	{
		/*
		cout<<"Numbers of vertices: ";
		int num;
		cin>>num;
		SetNumVertices(num);
		*/
		List<Coordinate> coor = new List<Coordinate>();
		coor.Resize(GetNumVertices());
		do
		{
		for (int i = 0;i < GetNumVertices();i++)
		{
			Console.Write("Coordinate ");
			Console.Write(i + 1);
			Console.Write("(x,y): ");
			coor[i].x = int.Parse(ConsoleInput.ReadToWhiteSpace(true));
			coor[i].y = int.Parse(ConsoleInput.ReadToWhiteSpace(true));
		}
		SetCoor(coor);
		}while (Check() == 0);
	}

//C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
	public void Print()
	{
		List<Coordinate> coor = new List<Coordinate>();
		coor = GetCoor();
		for (int i = 0;i < GetNumVertices();i++)
		{
			Console.Write("( ");
			Console.Write(coor[i].x);
			Console.Write(" , ");
			Console.Write(coor[i].y);
			Console.Write(" )");
			if (i != GetNumVertices() - 1)
			{
				Console.Write("--");
			}
		}
	}

//C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
	public bool Check()
	{
		List<Coordinate> coor = new List<Coordinate>();
		coor = GetCoor();
		for (int i = 0;i < GetNumVertices() - 1;i++)
		{
			for (int j = i + 1;j < GetNumVertices();j++)
			{
				if (coor[i].x == coor[j].x && coor[i].y == coor[j].y)
				{
					Console.Write("Wrong Input! Again.\n");
					return false;
				}
			}
		}
		return true;
	}

//C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
	public void Move(int x, int y)
	{
		List<Coordinate> coor = new List<Coordinate>();
		coor = GetCoor();
		for (int i = 0;i < GetNumVertices();i++)
		{
			coor[i].x += x;
			coor[i].y += y;
		}
		SetCoor(coor);
	}
}