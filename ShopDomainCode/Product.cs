using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDomainCode
{
	/* Класс, описывающий товар интернет магазина
	 * Любой товар, независимо от вида, имеет:
	 * Стоимость
	 * Вес(необходимо учитывать при доставке и хранении)
	 * Размеры (также необходимо учитывать при доставке и хранении)
	 */
	abstract public class Product
	{
		public int Cost { get; } = 0;
		public int Weight { get; } = 0;

		public string Name { get; }

		//public struct Size
		//{
		public int Height { get; } = 0;
		public int Width { get; } = 0;
		public int Length { get; } = 0;
		//public Size(int heigth, int width, int length )
		//{
		//public int Height; = heigth;
		//public int Width; = width;
		//public int Length = length;
		//}
		//}

		public Product() : this("", 0)
		{

		}
		public Product(string name, int cost) : this(name, cost, 0, 0, 0, 0)
		{
			//this.Name = name;
			//this.Cost = cost;
		}
		public Product(string name, int cost, int width, int heigth, int length, int weight)
		{
			this.Name = name;
			this.Cost = cost;
			this.Width = width;
			this.Height = heigth;
			this.Length = length;
			this.Weight = weight;
		}
	}
}
