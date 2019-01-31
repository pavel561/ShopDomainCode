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
		public DataBase shopDataBase;
		public List<User> shopUserList;
		public Shop()
		{
			shopName = "unnamed shop";
			shopDataBase = new DataBase();
			shopUserList = new List<User>();
		}
		public void NewConnection()
		{
			shopUserList.Add(new User());
		}
		public void CloseConnection(User user)
		{
			shopUserList.Remove(user);
		}
	}
}
