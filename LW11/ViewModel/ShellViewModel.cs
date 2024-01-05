using Core;
using System;
using System.Diagnostics;
using System.Windows.Input;

namespace LW11.ViewModel {
  public class ShellViewModel : NotifyPropertyChanged {

    public int Calculate(Function func1, Function func2, int x, int y) {
      return func1.Invoke(x, y) + func2.Invoke(x, y);
    }
    public delegate int Function(int x, int y);

    private string _output;
    public string Output {
      get => this._output;
      set {
        this._output = value; 
        OnPropertyChanged(nameof(Output));
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

    public ShellViewModel() {
      this._calculateCommand = new RelayCommand((a) => {


        this.Output = Calculate((a1, a2) => { return a1 + a2; }, (a1, a2) => { return a1 * a2; }, X, Y).ToString();
      
      }, p => true);  
    }


  }
}
