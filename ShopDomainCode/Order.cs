using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDomainCode
{
	public class Order
	{
		public enum DeliveryType { PickUp = 0, Courier, RegularMail, FastMail, TransportСompany }
		public string ClientPhone { get; set; }
		public string ClientAdress { get; set; }
		public string ClientName { get; set; }
		public DeliveryType? Delivery { get; set; }
		public bool? OrderComlete;
		public List<Product> ProductList;

		public Order()
		{

		}
		public Order(string name, string phone, string adress, string delivery, Basket basket)
		{
			ClientName = name;
			ClientPhone = phone;
			ClientAdress = adress;
			Delivery = (DeliveryType)Enum.Parse(typeof(DeliveryType), delivery);
			ProductList = basket.BasketList;
		}
	}
}
