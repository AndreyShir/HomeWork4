using System;


namespace Vector3D
{
	public class Vector3D
	{

        public double X { get; }

        public double Y { get; }

		public double Z { get; }

		public Vector3D(double x, double y, double z)
		{
			X = x;
			Y = y;
			Z = z;
		}


		public double Length()
		{
			return Math.Sqrt(
				X * X +
				Y * Y +
				Z * Z);
		}

		public double ScalarMultiplication(Vector3D other)
		{
			return
				X * other.X +
				Y * other.Y +
				Z * other.Z;
		}

		public Vector3D VectorMultiplication(Vector3D other)
		{
			return new Vector3D(
				Y * other.Z - Z * other.Y,
				Z * other.X - X * other.Z,
				X * other.Y - Y * other.X);
		}

		public double Angle(Vector3D other)
		{
			double length = Length();
			double otherLength = other.Length();
			if (length == 0 || otherLength == 0)
			{
				Console.WriteLine("Ошибка\nНевозможно получить угол для нулевого вектора");
				return default;
			}

			return ScalarMultiplication(other) / (length * otherLength);
		}

		public Vector3D Sum(Vector3D other)
		{
			return new Vector3D(
				X + other.X,
				Y + other.Y,
				Z + other.Z);
		}

		public Vector3D Difference(Vector3D other)
		{
			return new Vector3D(
				X - other.X,
				Y - other.Y,
				Z - other.Z);
		}

		public override string ToString()
		{
			return $"(Vector {{{X}, {Y}, {Z}}})";
		}
	}
}