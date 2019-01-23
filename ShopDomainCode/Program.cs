using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDomainCode
{
	class Program
	{
		static void Main(string[] args)
		{
		}
	}
	class Shop
	{

	}
	//Класс, описывающий товар интернет магазина
	//Любой товар, независимо от вида, имеет:
	/* Стоимость
	 * Вес(необходимо учитывать при доставке)
	 * Размеры (также необходимо учитывать при доставке)
	 */
	public abstract class Product
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

		public Product():this("",0)
		{

		}
		public Product(string name, int cost ):this(name,cost,0,0,0,0)
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
	// Класс описывающий электронику
	public class Electronics:Product
	{
		public enum TypeEnum { None = 0, Portable, Stationary, ForCar, Weatherproof};
		public TypeEnum Type;
		public Electronics(string type, string Name, int Cost):base(Name,Cost)
		{
			Type =(TypeEnum) Enum.Parse(typeof(TypeEnum), type);

		}
	}
	//Класс описывающий одежду
	public class Clothes:Product
	{
		public enum SexEnum { None = 0, Men, Wumen, Unisex }
		public SexEnum Sex;
		public Clothes(string sex, string name, int cost):base(name,cost)
		{
			Sex = (SexEnum)Enum.Parse(typeof(SexEnum), sex);
		}

	}

	public class Basket
	{
		/* По хорошему, в корзине нужно организовать хранение не просто листа товаров,
		 * а листа с массивами товаров одного типа (наименования),
		 * чтобы можно было добавлять несколько одинаковых товаров
		 * и они не отображались каждый отдельно,
		 * а хранились в виде конкретного товара и его количества(если пытаться добавить в корзину уже находящийся в ней товар)
		 * 
		 * Но я пока что не сообразил как это реализовать =(
		 */
		public List<Product> BasketList;
		// Конструктор
		Basket()
		{
			BasketList = new List<Product>();
		}
		public int Count{ get; private set; }
		//Метод возвращает общую стоимость товаров в корзине
		public int GetTotalPrice()
		{
			return CalculationTotalPrice();
		}
		//Метод реализует вычисление общей стоимости товаров в корзине
		int CalculationTotalPrice()
		{
			int totalPrice = 0; //Здесь будет вычисляться цена товаров в корзине
			return totalPrice;
		}
		//Метод добавления товара в коорзину
		public void Add(Product product)
		{
			BasketList.Add(product);
			this.Count = BasketList.Count;
		}
		//Метод удаления товара из корзины
		public void Remove(Product product)
		{
			BasketList.Remove(product);
			this.Count = BasketList.Count;
		}
	}


}
