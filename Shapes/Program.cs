using System;
using System.Collections.Generic;



namespace Shapes
{
	class Program
	{
		static void Main(string[] args)
		{
			try
            {
				Box container = new Box(30);

				var shapes = new List<Shape>();

				Box box = new Box(20);
				shapes.Add(box);

				Cylinder cylinder = new Cylinder(30, 10);
				shapes.Add(cylinder);

				Ball ball = new Ball(15);
				shapes.Add(ball);

				Pyramid pyramid = new Pyramid(3200, 10);
				shapes.Add(pyramid);

				Console.WriteLine($"Объём контейнера: {container.Volume()}");

				foreach (var shape in shapes)
				{
					if (!container.Add(shape))
					{
						Console.WriteLine("Контейнер заполнен!\nВ контейнере находятся фигуры:\n");
						foreach (var shp in container.Shapes)
                        {
							Console.WriteLine($"{shp.Name} объёмом {shp.Volume()}");
						}

						break;
					}

					Console.WriteLine($"В контейнер добавлена фигура {shape.Name}" +
						$"\nОставшийся объём {container.RemainingVolume()}");
				}
			}
			catch (Exception ex)
            {
				Console.WriteLine($"Произошла трагическая ошибка: {ex.Message}");
			}
			
		}
	}
}
