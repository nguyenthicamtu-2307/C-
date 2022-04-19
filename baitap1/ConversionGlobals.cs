using System;

public static class Globals
{
	//method for check
	public static double MultiCoor(Coordinate c1, Coordinate c2)
	{
		return c1.x * c2.x + c1.y * c2.y;
	}
	public static double Module(Coordinate c1, Coordinate c2)
	{
		return Math.Sqrt(Math.Pow(c1.x - c2.x,2) + Math.Pow(c1.y - c2.y,2));
	}
	public static Coordinate VectorCoor(Coordinate c1, Coordinate c2)
	{
		Coordinate c = new Coordinate();
		c.x = c1.x - c2.x;
		c.y = c1.y - c2.y;
//C++ TO C# CONVERTER TODO TASK: The following line was determined to contain a copy constructor call - this should be verified and a copy constructor should be created:
//ORIGINAL LINE: return c;
		return new Coordinate(c);
	}
}