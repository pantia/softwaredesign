using Core;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Input;
using static System.Net.Mime.MediaTypeNames;

namespace LW4 {
  public class ShellViewModel : NotifyPropertyChanged {

    private ICommand _searchCommand41;
    public ICommand SearchCommand41 {
      get => this._searchCommand41;
    }

    private string _output41;
    public string Output41 {
      get => this._output41;
      private set {
        this._output41 = value;
        OnPropertyChanged(nameof(Output41));
      }
    }

    private string _text41;
    public string Text41 {
      get => this._text41;
      set {
        this._text41 = value;
        OnPropertyChanged(nameof(Text41));
      }
    }

    private ICommand _searchCommand42;
    public ICommand SearchCommand42 {
      get => this._searchCommand42;
    }

    private string _output42;
    public string Output42 {
      get => this._output42;
      private set {
        this._output42 = value;
        OnPropertyChanged(nameof(Output42));
      }
    }

    private string _text42;
    public string Text42 {
      get => this._text42;
      set {
        this._text42 = value;
        OnPropertyChanged(nameof(Text42));
      }
    }


    private ICommand _deleteCommand43;
    public ICommand DeleteCommand43 {
      get => this._deleteCommand43;
    }

 

    private string _text43;
    public string Text43 {
      get => this._text43;
      set {
        this._text43 = value;
        OnPropertyChanged(nameof(Text43));
      }
    }

    private string _text44;
    public string Text44 {
      get => this._text44;
      set {
        this._text44 = value;
        OnPropertyChanged(nameof(Text44));
      }
    }

    private string _word44;
    public string Word44 {
      get => this._word44;
      set {
        this._word44 = value;
        OnPropertyChanged(nameof(Word44));
      }
    }

    private string _replace44;
    public string Replace44 {
      get => this._replace44;
      set {
        this._replace44 = value;
        OnPropertyChanged(nameof(Replace44));
      }
    }

    private ICommand _replaceCommand44;
    public ICommand ReplaceCommand44 {
      get => this._replaceCommand44;
    }

    public ShellViewModel() {

      this._searchCommand41 = new RelayCommand((a) => {


        Dictionary<char, int> counts = new Dictionary<char, int>();

        counts['?'] = 0;
        counts[';'] = 0;
        counts[':'] = 0;
        foreach(char c in this._text41) {
          
          
          if(c.Equals('?')) { 
            counts['?'] = counts['?'] + 1;
          }
           
          if(c.Equals(';')) {
            counts[';'] = counts[';'] + 1;
          }
          if(c.Equals(':')) {
            counts[':'] = counts[':'] + 1;
          }
        }

        string output = string.Empty;
        foreach(var kv in counts) {
          output = output + " " + kv.Key + " " + kv.Value;
        }
        this.Output41 = output;

      }, p => true);

      this._searchCommand42 = new RelayCommand((a) => {
        string output = string.Empty;
        foreach(var val in Regex.Matches(this._text42, "([a-z0-9-]*.com)")) {

          output = output + " " + val.ToString();
        }
        this.Output42 = output;
      }, p => true);

      this._deleteCommand43 = new RelayCommand((a) => {
        string output = this._text43;


        string[] words = output.Split();
        words.Where(x => x.Length == 1).ToList().ForEach(y => output = output.Replace(y, "")); 
        foreach(var val in Regex.Matches(output, "[a-e](\\w+)")) {
          output = output.Replace(val.ToString(), "");
        }
        this.Text43 = output;
         
      }, p => true);

      this._replaceCommand44 = new RelayCommand((a) => {
        string output = this._text44;
        output = output.Replace(Word44, Replace44);
        Text44 = output; 
      }, p => true);

    }

  }
}
