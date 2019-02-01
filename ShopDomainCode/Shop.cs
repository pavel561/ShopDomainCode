using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDomainCode
{
	public class Shop
	{
		string shopName;
		public List<Product> shopDataBase;	//База данных магазина
		public List<User> shopUserList;		//Список находящихся в интернет магазине пользователей
		public Shop()
		{
			shopName = "unnamed shop";
			shopDataBase =new List<Product>();
			//имитируем базу данных
			shopDataBase.Add(new Electronics("Mobile Phone Nokia", 300));
			shopDataBase.Add(new Electronics("Mobile Phone Samsung", 500));
			shopDataBase.Add(new Electronics("Mobile Phone Samsung", 500));
			shopDataBase.Add(new Electronics("LED TV Samsung", 1000));
			shopDataBase.Add(new Electronics("LED TV Samsung", 1200));
			shopDataBase.Add(new Electronics("LED TV Horizont", 300));
			shopDataBase.Add(new Electronics("LED TV Horizont", 200));

			shopUserList = new List<User>();
		}
		public void NewConnection()
		{
			shopUserList.Add(new User());		//Создаем нового пользователя
		}
		public void CloseConnection(User user)
		{
			shopUserList.Remove(user);          //Удаляем, если пользователь покинул магазина
		}
	}
}
