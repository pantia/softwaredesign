using Core;
using LW9.Collection;
using LW9.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LW9.ViewModel {
  public class ShellViewModel : NotifyPropertyChanged {


    private bool _singleChecked;
    public bool SingleChecked {
      get => this._singleChecked;
      set {
        this._singleChecked = value;
        if(value) {
          this._list = new SingleLinkedList<string>();
        }
        OnPropertyChanged(nameof(SingleChecked));
      }
    }

    private bool _doublyChecked;
    public bool DoublyChecked {
      get => this._doublyChecked;
      set {
        this._doublyChecked = value;
        if(value) {
          this._list = new DoublyLinkedList<string>();
        }
        OnPropertyChanged(nameof(DoublyChecked));
      }
    }


    private LW9.Collection.IList<string> _list;

    private int _index;
    public int Index {
      get => this._index;
      set {
        this._index = value;
        OnPropertyChanged(nameof(Index));
      }
    }

    public int Count {
      get => this._list.Count;
     
    }

    private string _input;
    public string Input {
      get => this._input;
      set {
        this._input = value;
        OnPropertyChanged(nameof(Input));
      }
    }

    private string _replace;
    public string Replace {
      get => this._replace;
      set {
        this._replace = value;
        OnPropertyChanged(nameof(Replace));
      }
    }


    private string _searchOutput;
    public string SearchOutput {
      get => this._searchOutput;
      set {
        this._searchOutput = value;
        OnPropertyChanged(nameof(SearchOutput));
      }
    }

    private ICommand _addFirstCommand;
    public ICommand AddFirstCommand {
      get => this._addFirstCommand; 
    }

    private ICommand _addLastCommand;
    public ICommand AddLastCommand {
      get => this._addLastCommand;
    }

    private ICommand _task2Command;
    public ICommand Task2Command {
      get => this._task2Command;
    }


    private ICommand _insertCommand;
    public ICommand InsertCommand {
      get => this._insertCommand;
    }

    private ICommand _clearCommand;
    public ICommand ClearCommand {
      get => this._clearCommand;
    }

    private ICommand _deleteByIndexCommand;
    public ICommand DeleteByIndexCommand {
      get => this._deleteByIndexCommand;
    }

    private ICommand _deleteByValueCommand;
    public ICommand DeleteByValueCommand {
      get => this._deleteByValueCommand;
    }

    private ICommand _replaceCommand;
    public ICommand ReplaceCommand {
      get => this._replaceCommand;
    }

    private ICommand _changeByIndexCommand;
    public ICommand ChangeByIndexCommand {
      get => this._changeByIndexCommand;
    }


    private ICommand _searchCommand;
    public ICommand SearchCommand {
      get => this._searchCommand;
    }

    private ICommand _sortCommand;
    public ICommand SortCommand {
      get => this._sortCommand;
    }

    private ICommand _saveCommand;
    public ICommand SaveCommand {
      get => this._saveCommand;
    }


    private ICommand _loadCommand;
    public ICommand LoadCommand {
      get => this._loadCommand;
    }


    private ICommand _task3Command;
    public ICommand Task3Command {
      get => this._task3Command;
    }


    public ObservableCollection<string> Items {
      get => new ObservableCollection<string>(this._list);
    }

    public ShellViewModel() {
      this.SingleChecked = true; 
      this._addFirstCommand = new RelayCommand((a) => {
        this._list.AddFirst(Input);
        InvokePropertyChanged();
      }, p => true);
      this._addLastCommand = new RelayCommand((a) => {
        this._list.AddLast(Input);
        InvokePropertyChanged();
      }, p => true);
      this._insertCommand = new RelayCommand((a) => {
        this._list.Insert(Index, Input);
        InvokePropertyChanged();
      }, p => true);
      this._clearCommand = new RelayCommand((a) => {
        this._list.Clear();
        InvokePropertyChanged();
      }, p => true);
      this._deleteByIndexCommand = new RelayCommand((a) => {
        this._list.RemoveAt(this.Index);
        InvokePropertyChanged();
      }, p => true);
      this._deleteByValueCommand = new RelayCommand((a) => {
        this._list.Remove(this.Input);
        InvokePropertyChanged();
      }, p => true);
      this._replaceCommand = new RelayCommand((a) => {
        this._list.Replace(this.Input, Replace);
        InvokePropertyChanged();
      }, p => true);

      this._changeByIndexCommand = new RelayCommand((a) => {
        this._list.Set(this.Index, this.Input);
        InvokePropertyChanged();
      }, p => true);

      this._searchCommand = new RelayCommand((a) => {
        this.SearchOutput = this._list.IndexOf(this.Input).ToString();  
      }, p => true);

      this._sortCommand = new RelayCommand((a) => {
        this._list.Sort();
        InvokePropertyChanged();
      }, p => true);

      this._task2Command = new RelayCommand((a) => {
         
        Task2View view = new Task2View(); 
        view.DataContext = new Task2ViewModel();
        view.ShowDialog();
      }, p => true);


      this._task3Command = new RelayCommand((a) => {
        Task3View view = new Task3View();
        view.DataContext = new Task3ViewModel();
        view.ShowDialog();
      }, p => true);
    }

    private void InvokePropertyChanged() {
      OnPropertyChanged(nameof(Items));
      OnPropertyChanged(nameof(Count)); 
    }

  }
}
