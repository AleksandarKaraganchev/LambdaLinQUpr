using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    public class OrderItem
    {
		private string  productName;
		public string ProductName
		{
			get { return productName; }
			set { productName = value; }
		}
		private int quantity;
		public int Quantity
		{
			get { return quantity; }
			set { quantity = value; }
		}

	}
}
