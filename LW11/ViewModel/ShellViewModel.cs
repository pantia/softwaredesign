using Core;
using LW11.Model;
using LW11.View;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Documents;
using System.Windows.Input;

namespace LW11.ViewModel {
  public class ShellViewModel : NotifyPropertyChanged {

    public int Calculate(Function func1, Function func2, int x, int y) {
      return func1.Invoke(x, y) + func2.Invoke(x, y);
    }
    public delegate int Function(int x, int y);
    public delegate void ListFunction(ObservableCollection<SKLAD> list, int min, int max);

    private string _output;
    public string Output {
      get => this._output;
      set {
        this._output = value; 
        OnPropertyChanged(nameof(Output));
      }
    }

    private string _output2;
    public string Output2 {
      get => this._output2;
      set {
        this._output2 = value;
        OnPropertyChanged(nameof(Output2));
      }
    }

    private int _x;
    public int X {
      get => this._x;
      set {
        this._x = value;
        OnPropertyChanged(nameof(X));
      }
    }

    private int _y;
    public int Y {
      get => this._y;
      set {
        this._y = value;
        OnPropertyChanged(nameof(Y));
      }
    }

    private ICommand _calculateCommand;
    public ICommand CalculateCommand {
      get => this._calculateCommand;
    
    }


    private ShopService _service;

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

    private ICommand _calculateMidPriceCommand;
    public ICommand CalculateMidPriceCommand {
      get => this._calculateMidPriceCommand;
    }

    private ICommand _calculateTotalPriceCommand;
    public ICommand CalculateTotalPriceCommand {
      get => this._calculateTotalPriceCommand;
    }

    public void Calculate(ListFunction listFunction, int min, int max) {
      listFunction.Invoke(this.Shop, min, max);
    }

    public ShellViewModel() {
      this._service = new ShopService();
      this._calculateCommand = new RelayCommand((a) => {


        this.Output = Calculate((a1, a2) => { return a1 + a2; }, (a1, a2) => { return a1 * a2; }, X, Y).ToString();
      
      }, p => true);
      this._addCommand = new RelayCommand((a) => {
        AddView view = new AddView();
        view.DataContext = new AddViewModel(this._service);
        view.ShowDialog();
        Print();
      }, p => true);

      this._calculateMidPriceCommand = new RelayCommand((a) => {
        Calculate((list, min, max) => {

          int total = 0;
          foreach(var item in list) {
            total = total + item.Cost;
          }
          this.Output2 = "Середня ціна " + (total / this.Shop.Count).ToString();
        
        }, 50, 100);

        
      }, p => true);
      this._calculateTotalPriceCommand = new RelayCommand((a) => {
        Calculate((list, min, max) => {

          int total = 0;
          foreach(var item in list) {
            total = total + item.Cost;
          }
          this.Output2 = "Загальна ціна " + total.ToString();

        }, 50, 100);
      }, p => true);

    }


  }
}
