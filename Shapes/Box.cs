using System;
using System.Collections.Generic;

namespace Shapes
{
	public class Box : Shape
	{
		private double _filledVolume;

		public Box(double height)
		{
			Height = height;
		}

		public override string Name => "Куб";

		public List<Shape> Shapes { get; } = new List<Shape>();
        public double Height { get; }

        public double RemainingVolume()
		{
			return Volume() - _filledVolume;
		}

		public bool Add(Shape shape)
		{
			double remainingVolume = RemainingVolume();
			double shapeVolume = shape.Volume();

			if (remainingVolume >= shapeVolume)
			{
				Shapes.Add(shape);
				_filledVolume += shapeVolume;

				return true;
			}
			else
			{
				return false;
			}
		}


		public override double Volume()
		{
			return Math.Pow(Height, 3);
		}
	}
}