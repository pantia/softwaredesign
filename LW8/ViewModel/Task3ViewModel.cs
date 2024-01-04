using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LW8.ViewModel {
  public class Task3ViewModel : NotifyPropertyChanged {

    private string _input1;
    public string Input1 {
      get => this._input1;
      set {
        this._input1 = value;
        OnPropertyChanged(nameof(Input1));
      }
    }

    private string _input2;
    public string Input2 {
      get => this._input2;
      set {
        this._input2 = value;
        OnPropertyChanged(nameof(Input2));
      }
    }

    private string _output;
    public string Output {
      get => this._output;
      set {
        this._output = value;
        OnPropertyChanged(nameof(Output));
      }
    }

    private ICommand _unionCommand;
    public ICommand UnionCommand {
      get => this._unionCommand;
    }

    private ICommand _intersectCommand;
    public ICommand IntersectCommand {
      get => this._intersectCommand;
    }

    private ICommand _exceptCommand;
    public ICommand ExceptCommand {
      get => this._exceptCommand;
    }

    private ICommand _symmetricExceptCommand;
    public ICommand SymmetricExceptCommand {
      get => this._symmetricExceptCommand;
    }

    public Task3ViewModel() {
      this._unionCommand = new RelayCommand((a) => { 
        HashSet<char> set = new HashSet<char>(this.Input1);
        set.UnionWith(this.Input2); 
        this.Output = string.Join(string.Empty, set);
      }, p => true);
      this._intersectCommand = new RelayCommand((a) => {
        HashSet<char> set = new HashSet<char>(this.Input1);
        set.IntersectWith(this.Input2);
        this.Output = string.Join(string.Empty, set);
      }, p => true);
      this._exceptCommand = new RelayCommand((a) => {
        HashSet<char> set = new HashSet<char>(this.Input1);
        set.ExceptWith(this.Input2);
        this.Output = string.Join(string.Empty, set);
      }, p => true);
      this._symmetricExceptCommand = new RelayCommand((a) => {
        HashSet<char> set = new HashSet<char>(this.Input1);
        set.SymmetricExceptWith(this.Input2);
        this.Output = string.Join(string.Empty, set);
      }, p => true);
    }


  }
}
