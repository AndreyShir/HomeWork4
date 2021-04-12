using System;

namespace Shapes
{
	public class Ball : Shape
	{
		private double _radius;


		public Ball(double r)
		{
			Radius = r;
		}

		public override string Name => "Шар";

        public double Radius { get; init; }

        public override double Volume()
		{
			return (4.0 / 3.0) * Math.PI * Math.Pow(Radius, 3); 
		}
	}
}