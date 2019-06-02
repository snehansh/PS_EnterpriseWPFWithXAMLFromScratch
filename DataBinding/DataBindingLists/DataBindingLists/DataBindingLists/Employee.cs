using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingLists
{
	public class Employee : INotifyPropertyChanged
	{
		private string name;
		private string title;

		public string Name
		{
			get { return name; }
			set
			{
				name = value;
				OnPropertyChanged();
			}
		}

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

		private void OnPropertyChanged([CallerMemberName] string caller = "")
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(caller));
			}
		}

		public static ObservableCollection<Employee> GetEmployees()
		{
			var employees = new ObservableCollection<Employee>
			{
				new Employee() { Name = "Washigton", Title = "President 1" },
				new Employee() { Name = "Adams", Title = "President 2" },
				new Employee() { Name = "Jefferson", Title = "President 3" },
				new Employee() { Name = "Madison", Title = "President 4" },
				new Employee() { Name = "Monroe", Title = "President 5" }
			};
			return employees;
		}
	}
}
