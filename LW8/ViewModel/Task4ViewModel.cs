using Core;
using System.Collections.Generic;
using System.Windows.Input;

namespace LW8.ViewModel {
  public class Task4ViewModel : NotifyPropertyChanged {


    private Dictionary<string, string> _dictionary;

    private string _inputKey;
    public string InputKey {
      get => this._inputKey;
      set {
        this._inputKey = value;
        OnPropertyChanged(nameof(InputKey));  
      }
    }

    private string _deleteKey;
    public string DeleteKey {
      get => this._deleteKey;
      set {
        this._deleteKey = value;
        OnPropertyChanged(nameof(DeleteKey));
      }
    }

    private string _inputValue;
    public string InputValue {
      get => this._inputValue;
      set {
        this._inputValue = value;
        OnPropertyChanged(nameof(InputValue));
      }
    }

    public int Count {
      get => this._dictionary.Count;
    }


    private ICommand _addCommand;
    public ICommand AddCommand {
      get => this._addCommand;
    }

    private ICommand _deleteCommand;
    public ICommand DeleteCommand {
      get => this._deleteCommand;
    }

    private ICommand _clearCommand;
    public ICommand ClearCommand {
      get => this._clearCommand;
    }

    private ICommand _checkKeyCommand;
    public ICommand CheckKeyCommand {
      get => this._checkKeyCommand;
    }


    private string _checkKey;
    public string CheckKey {
      get => this._checkKey;
      set {
        this._checkKey = value;
        OnPropertyChanged(nameof(CheckKey));
      }
    }


  


    private string _checkKeyOutput;
    public string CheckKeyOutput {
      get => this._checkKeyOutput;
      set {
        this._checkKeyOutput = value;
        OnPropertyChanged(nameof(CheckKeyOutput));
      }
    }

    private string _checkValueOutput;
    public string CheckValueOutput {
      get => this._checkValueOutput;
      set {
        this._checkValueOutput = value;
        OnPropertyChanged(nameof(CheckValueOutput));
      }
    }

    private ICommand _checkValueCommand;
    public ICommand CheckValueCommand {
      get => this._checkValueCommand;
    }


    private string _checkValue;
    public string CheckValue {
      get => this._checkValue;
      set {
        this._checkValue = value;
        OnPropertyChanged(nameof(CheckValue));
      }
    }

    public Task4ViewModel() {

      this._dictionary = new Dictionary<string, string>();
      this._addCommand = new RelayCommand((a) => {
        try {
          this._dictionary.Add(this.InputKey, this.InputValue);
          OnPropertyChanged(nameof(this.Count));
        } catch { }
      }, p => true);
      this._deleteCommand = new RelayCommand((a) => {
        try {
          this._dictionary.Remove(this.DeleteKey);
          OnPropertyChanged(nameof(this.Count));
        } catch { }
      }, p => true);
      this._clearCommand = new RelayCommand((a) => {
        try {
          this._dictionary.Clear();
          OnPropertyChanged(nameof(this.Count));
        } catch { }
      }, p => true);
      this._checkKeyCommand = new RelayCommand((a) => {
        try {
          this.CheckKeyOutput = this._dictionary.ContainsKey(this.CheckKey).ToString(); 
        } catch { }
      }, p => true);
      this._checkValueCommand = new RelayCommand((a) => {
        try {
          this.CheckValueOutput = this._dictionary.ContainsValue(this.CheckValue).ToString();
        } catch { }
      }, p => true);
    }


  }
}
