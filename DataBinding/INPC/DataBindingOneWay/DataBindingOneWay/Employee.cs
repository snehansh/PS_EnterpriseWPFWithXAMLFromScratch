﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingOneWay
{
	public class Employee : INotifyPropertyChanged
	{
		//public string Name { get; set; }
		//public string Title { get; set; }

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

		public event PropertyChangedEventHandler PropertyChanged;

		public static Employee GetEmployee()
		{
			var emp = new Employee
			{
				Name = "Tom",
				Title = "Developer"
			};
			return emp;
		}


		private void OnPropertyChanged(
			[CallerMemberName] string caller = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(caller));
		}

	}
}
