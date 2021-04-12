using System;

namespace Shapes
{
	public class Cylinder : Shape
	{
		public Cylinder(double r, double h)
		{
			Radius = r;
			Height = h;
		}

		public override string Name => "Цилиндр";

        public double Radius { get; }
        public double Height { get; }

        public override double Volume()
		{
			return Math.PI * Math.Pow(Radius, 2)  * Height;
		}
	}
}