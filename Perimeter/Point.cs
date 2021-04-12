namespace Perimeter
{
	public class Point
	{
		public int X { get; init; }

		public int Y { get; init; }

		public string Name { get; init; }

		public Point()
        {

        }

		public Point(int x, int y, string name)
		{
			X = x;
			Y = y;
			Name = name;
		}


	}
}