using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDomainCode
{
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
		public int Count { get; private set; }

		// Конструктор
		public Basket()
		{
			BasketList = new List<Product>();
		}
		
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
