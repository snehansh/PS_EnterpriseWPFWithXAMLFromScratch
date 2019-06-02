using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SimpleForm
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void SaveButton_Click(object sender, RoutedEventArgs e)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("Full Name: ");
			stringBuilder.Append(FullName.Text);
			stringBuilder.Append("Sex?");
			stringBuilder.Append((bool)Male.IsChecked ? "Male" : "Female");
			stringBuilder.Append("Computer:");
			stringBuilder.Append((bool)Desktop.IsChecked ? "Desktop" : "");
			stringBuilder.Append((bool)Laptop.IsChecked ? "Laptop" : "");
			stringBuilder.Append((bool)Tablet.IsChecked ? "Tablet" : "");
			stringBuilder.Append("Your job:");
			stringBuilder.Append(Job.SelectedItem.ToString());
			stringBuilder.Append("Delivery Date:");
			stringBuilder.Append(DeliveryDate.SelectedDate.ToString());
			MessageBox.Show(stringBuilder.ToString());
		}

		private void Job_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			var newlySelectedItem = e.AddedItems[0];
			MessageBox.Show(newlySelectedItem.ToString());
		}
	}
}
