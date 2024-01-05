using Core;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Documents;
using System.Windows.Input;

namespace LW9.ViewModel {
  public class Task2ViewModel : NotifyPropertyChanged {

    private int _selectedIndex;
    public int SelectedIndex {
      get { 
        return _selectedIndex;
      }
      set {
        this._selectedIndex = value;
        OnPropertyChanged(nameof(SelectedIndex));
      }
    }

    private string _input;
    public string Input {
      get => this._input;
      set {
        this._input = value;
        OnPropertyChanged(nameof(Input));
      }
    }


    private ObservableCollection<string> _list1;
    public ObservableCollection<string> List1 {
      get => this._list1;
    }

    private ObservableCollection<string> _list2;
    public ObservableCollection<string> List2 {
      get => this._list2;
    }


    private ObservableCollection<string> _list3;
    public ObservableCollection<string> List3 {
      get => this._list3;
    }

    private ICommand _addCommand;
    public ICommand AddCommand {
      get => this._addCommand;
      set {
        this._addCommand = value;
        OnPropertyChanged(nameof(this.AddCommand));
      }
    }

    private ICommand _calculateCommand;
    public ICommand CalculateCommand {
      get => this._calculateCommand;
      set {
        this._calculateCommand = value;
        OnPropertyChanged(nameof(this.CalculateCommand));
      }
    }

    private ICommand _saveCommand;
    public ICommand SaveCommand {
      get => this._saveCommand;
      set {
        this._saveCommand = value;
        OnPropertyChanged(nameof(this.SaveCommand));
      }
    }

    public static int SublistIndex<T>(IList<T> list, int start, IList<T> sublist) {
      for(int listIndex = start; listIndex < list.Count - sublist.Count + 1; listIndex++) {
        int count = 0;
        while(count < sublist.Count && sublist[count].Equals(list[listIndex + count]))
          count++;
        if(count == sublist.Count)
          return listIndex;
      }
      return -1;
    }

    public Task2ViewModel() {
      this._list1 = new ObservableCollection<string>();
      this._list2 = new ObservableCollection<string>();
      this._list3 = new ObservableCollection<string>();
      this.AddCommand = new RelayCommand((a) => { 
      
        switch(this.SelectedIndex) {
          case 0: {
            this.List1.Add(this.Input);
            break;
          }
          case 1: {
            this.List2.Add(this.Input);
            break;
          }
          case 2: {
            this.List3.Add(this.Input);
            break;
          }
        } 
      }, p => true);
      this.CalculateCommand = new RelayCommand((a) => {

        int index = SublistIndex<string>(this._list1, 0, this._list2);
        if(index != -1) {
          for(int i = index + this._list2.Count - 1; i >= index; i--) {
            this._list1.RemoveAt(i);
          }
          index = index - 1;
          for(int i = 0; i < this._list3.Count; i++) {
            this._list1.Insert(index + 1, this._list3[i]);
          }
        }
      }, p => true);
      this._saveCommand = new RelayCommand((a) => {
        StringBuilder sb = new StringBuilder();
        for(int i = 0; i < this._list1.Count;i++) {
          sb.Append(this._list1[i] + " ");
          if(i % 7 == 0) {
            sb.Append("\r\n");
          }
        }
        File.WriteAllText("output", sb.ToString()); 
      }, p => true);
    }


  }
}
