using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingTwoWay
{
	public class Employee : INotifyPropertyChanged
	{
		//public string Name;
		//public string Title;

		private string name;
		public string Name
		{
			get { return name; }
			set
			{
				name = value;
				OnPropertyChanged();
			}
		}

		private string title;
		public string Title
		{
			get { return title; }
			set
			{
				title = value;
				OnPropertyChanged();
			}
		}

		private void OnPropertyChanged([CallerMemberName] string caller = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(caller));
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public static Employee GetEmployee()
		{
			return new Employee
			{
				Name = "Ganesh",
				Title = "Tirpati"
			};
		}
	}
}
