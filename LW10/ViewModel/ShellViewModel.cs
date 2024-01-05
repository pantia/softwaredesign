using Core;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace LW10.ViewModel {
  public class ShellViewModel : NotifyPropertyChanged {

    private ICommand _checkCommand;
    public ICommand CheckCommand {
      get => this._checkCommand;
    }

    private string _input;
    public string Input {
      get => this._input;
      set {
        this._input = value;
        OnPropertyChanged(nameof(this.Input));
      }
    }

    private string _output;
    public string Output {

      get => this._output;
      set {
        this._output = value;
        OnPropertyChanged(nameof(this.Output)); 
      }
    }

    private ObservableCollection<int> _matrix;
    public ObservableCollection<int> Matrix {
      get => this._matrix;
    }

    private ObservableCollection<int> _matrix2;
    public ObservableCollection<int> Matrix2 {
      get => this._matrix2;
    }

    public ShellViewModel() {
      this._checkCommand = new RelayCommand((a) => {
        Stack<char> stack = new Stack<char>();
        foreach(char ch in this.Input) {
          if(ch.Equals('(')) {
            stack.Push(ch);
          }
          if(ch.Equals(')')) {
            if(stack.Count > 0) {
              if(stack.Peek().Equals('(')) {
                stack.Pop();
              } else {
                this.Output = "не збалансовано";
                break;
              }
            } else {
              this.Output = "не збалансовано";
              break;
            } 
          }
        }
        if(stack.Count == 0) {
          this.Output = "збалансовано";
        } else {
          this.Output = "не збалансовано";
        }

      }, p => true);

      this._matrix = new ObservableCollection<int>() {
        1, 1, 0, 0, 1,
        0, 0, 0, 0, 1,
        0, 0, 0, 0, 1,
        0, 0, 0, 1, 1,
        0, 0, 0, 0, 0,
      };

      this._matrix2 = new ObservableCollection<int>() {
        1, 1, 1, 0, 0, 0, 0,
        0, 1, 0, 1, 0, 0, 0,
        0, 0, 0, 0, 1, 0, 0,
        0, 0, 0, 0, 0, 1, 1,
        0, 0, 1, 1, 1, 1, 0,
      };
    }

  }
}
