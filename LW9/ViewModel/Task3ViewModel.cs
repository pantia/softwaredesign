using Core;
using LW9.Collection;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LW9.ViewModel {
  public class Task3ViewModel : NotifyPropertyChanged {
     
    public ObservableCollection<string> List1 {
      get => new ObservableCollection<string>(this._players);
    }

    private ObservableCollection<string> _list2;
    public ObservableCollection<string> List2 {
      get => this._list2; 
    }


    private ObservableCollection<string> _list3;
    public ObservableCollection<string> List3 {
      get => this._list3;
    }




    private static Random random = new Random();

    public static string RandomString(int length) {
      const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
      return new string(Enumerable.Repeat(chars, length)
          .Select(s => s[random.Next(s.Length)]).ToArray());
    }


    private CircularList<string> _players;

    private ICommand _calculateCommand;
    public ICommand CalculateCommand {
      get => this._calculateCommand;
    }

    public Task3ViewModel() { 
      this._players = new CircularList<string>(20);
      this._list2 = new ObservableCollection<string>();
      this._list3 = new ObservableCollection<string>(); 
      
      for(int i = 0; i <  20; i++) {
        this._players.Value = RandomString(5);
        this._players.Next(); 
      }

      this._calculateCommand = new RelayCommand((a) => {

        int i = 0;
        while(this._list3.Count < 10) {
          this._players.Next();
          i = i + 1;
          if(i % 12 == 0) {

            this._list3.Add(this._players.Value);
          }
        }
        this._list2 = new ObservableCollection<string>(_players.Except(this._list3));
        OnPropertyChanged(nameof(this.List2));
      
      }, p => true);
       
    }
  }
}
