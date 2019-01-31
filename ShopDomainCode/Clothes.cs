using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDomainCode
{
	//Класс описывающий одежду
	public class Clothes : Product
	{
		public enum SexEnum { None = 0, Men, Wumen, Unisex }
		public enum SizeEnum { L = 1, XL, S, XS, M, XXL }
		public SexEnum Sex;
		public SizeEnum Size;
		public Clothes(string sex, string name, int cost) : base(name, cost)
		{
			Sex = (SexEnum)Enum.Parse(typeof(SexEnum), sex);
		}

	}
}
