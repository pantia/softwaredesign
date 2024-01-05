using Core;
using LW7.Model;
using LW7.View;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace LW7.ViewModel {
  public class ShellViewModel : NotifyPropertyChanged {

    private ShopService _service;


  

    private ICommand _task2Command;
    public ICommand Task2Command {
      get => this._task2Command;
    }

    private ICommand _addCommand;
    public ICommand AddCommand {
      get => this._addCommand;
    }

    private ICommand _sortCommand;
    public ICommand SortCommand {
      get => this._sortCommand;
    }
    private ICommand _saveCommand;
    public ICommand SaveCommand {
      get => this._saveCommand;
    }

    private ObservableCollection<SKLAD> _shop;
    public ObservableCollection<SKLAD> Shop {
      get => this._shop;
      private set {
        this._shop = value;
        OnPropertyChanged(nameof(Shop));
      }
    }

    private void Print() {
      var collection = new ObservableCollection<SKLAD>();
      for(int i = 0; i < _service.Index; i++) {
        collection.Add(_service.Shop[i]);
      }
      this.Shop = collection;
    }

    public ShellViewModel() {
      
      this._service = new ShopService();
      
      this._task2Command = new RelayCommand((a) => {
        Task2View view = new Task2View();
        view.DataContext = new Task2ViewModel();
        view.ShowDialog();
      }, p => true);
      this._addCommand = new RelayCommand((a) => {
        AddView view = new AddView();
        view.DataContext = new AddViewModel(this._service);
        view.ShowDialog();
        Print();
      }, p => true);
      this._sortCommand = new RelayCommand((a) => {
        _service.Sort(); 
        Print();
      }, p => true);
      this._saveCommand = new RelayCommand((a) => {
        _service.Save(); 
      }, p => true);
    }

  }
}
