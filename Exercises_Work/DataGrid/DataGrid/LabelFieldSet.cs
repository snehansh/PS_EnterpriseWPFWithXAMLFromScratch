using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataGrid
{
	public class LabelFieldSet : INotifyPropertyChanged
	{
		private string _labelName;
		public string LabelName
		{
			get { return _labelName; }
			set
			{
				_labelName = value;
				OnPropertyChanged();
			}
		}

		private string _labelValue;
		public string LabelValue
		{
			get { return _labelValue; }
			set
			{
				_labelValue = value;
				OnPropertyChanged();
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		private void OnPropertyChanged([CallerMemberName] string callerName = "")
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(callerName));
			}
		}

		public static ObservableCollection<LabelFieldSet> GetLabelFieldSets()
		{
			return new ObservableCollection<LabelFieldSet>
			{
				new LabelFieldSet()
				{
					LabelName="Sato Printer 1",
					LabelValue=""
				},
				new LabelFieldSet()
				{
					LabelName="Sato Printer 2",
					LabelValue=""
				},
				new LabelFieldSet()
				{
					LabelName="Sato Printer 3",
					LabelValue=""
				}
			};
		}
	}
}
