using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDomainCode
{
	public class User
	{
		static Random rnd = new Random();
		public int userId;						//ИДентификатор пользователя
		public Basket userBasket;				//Корзина пользователя
		public List<Order> userOrderList;		//Список заказов пользователя
		public string Name { get; set; }
		public User()
		{
			userBasket = new Basket();
			userOrderList = new List<Order>();
			userId = rnd.Next(1000000);
		}
		public void Сheckout()
		{
			userOrderList.Add(new Order(Name, "none", "none", "none", userBasket));
		}
	}
}
