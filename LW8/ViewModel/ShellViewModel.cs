using Core;
using LW7.Model;
using LW7.View;
using LW8.View;
using LW8.ViewModel;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace LW7.ViewModel {
  public class ShellViewModel : NotifyPropertyChanged {

    private ShopService _service;


    private ICommand _addCommand;
    public ICommand AddCommand {
      get => this._addCommand;
    }


    private ICommand _task2Command;
    public ICommand Task2Command {
      get => this._task2Command;
    }

    private ICommand _task3Command;
    public ICommand Task3Command {
      get => this._task3Command;
    }

    private ICommand _refreshCommand;
    public ICommand RefreshCommand {
      get => this._refreshCommand;
    }

    private ICommand _sortCommand;
    public ICommand SortCommand {
      get => this._sortCommand;
    }
    private ICommand _saveCommand;
    public ICommand SaveCommand {
      get => this._saveCommand;
    }

    private ObservableCollection<Offense> _shop;
    public ObservableCollection<Offense> Shop {
      get => this._shop;
      private set {
        this._shop = value;
        OnPropertyChanged(nameof(Shop));
      }
    }

    private void Print() {
      var collection = new ObservableCollection<Offense>();
      for(int i = 0; i < _service.Index; i++) {
        collection.Add(_service.Shop[i]);
      }
      this.Shop = collection;
    }

    public ShellViewModel() {
      
      this._service = new ShopService();
      this._addCommand = new RelayCommand((a) => { 
        AddView view = new AddView();
        view.DataContext = new AddViewModel(this._service);
        view.ShowDialog();
        Print();
      }, p => true);
      this._refreshCommand = new RelayCommand((a) => {
        _service.Refresh();
        Print();
      }, p => true);
      this._sortCommand = new RelayCommand((a) => {
        _service.Sort(); 
        Print();
      }, p => true);
      this._saveCommand = new RelayCommand((a) => {
        _service.Save(); 
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

  }
}
