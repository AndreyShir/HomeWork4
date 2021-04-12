namespace Shapes
{
	public class Pyramid : Shape
	{
		public Pyramid(double s, double h)
		{
			S = s;
			H = h;
		}

		public override string Name => "Пирамида";

        public double S { get;  }
        public double H { get; }

        public override double Volume()
		{
			return S * H / 3.0;
		}
	}
}