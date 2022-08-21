using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridDemo
{
    public class DataGridModel : BindableObject
    {
		private string name;
		/// <summary>
		/// 名字
		/// </summary>
		public string Name
		{
			get => name;
			set
			{
				name = value;
				OnPropertyChanged();
			}
		}

		private int number;
		/// <summary>
		/// 数量
		/// </summary>
		public int Number
		{
			get => number;
			set
			{
				number = value;
				OnPropertyChanged();
			}
		}

		private double price;
		/// <summary>
		/// 价格
		/// </summary>
		public double Price
		{
			get => price;
			set
			{
				price = value;
				OnPropertyChanged();
			}
		}

	}
}
