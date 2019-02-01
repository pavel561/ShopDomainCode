using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDomainCode
{
	// Класс описывающий электронику
	public class Electronics : Product
	{

		public enum TypeEnum { None = 0, Portable, Stationary, ForCar, Weatherproof };
		public TypeEnum Type;
		public Electronics(string type, string Name, int Cost) : base(Name, Cost)
		{
			Type = (TypeEnum)Enum.Parse(typeof(TypeEnum), type);

		}
		public Electronics(string Name, int Cost) : base(Name, Cost)
		{
			//Type = (TypeEnum)Enum.Parse(typeof(TypeEnum), type);
			this.Name = Name;
			this.Cost = Cost;
		}
		public Electronics()
		{

		}
	}
}
