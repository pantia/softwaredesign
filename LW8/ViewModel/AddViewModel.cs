using Core;
using LW7.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace LW7.ViewModel {
  public class AddViewModel : NotifyPropertyChanged {

    private Offense _model;
    public string Name {
      get => this._model.Name;
      set {
        this._model.Name = value;
        OnPropertyChanged(nameof(this.Name));
      }
    }

    public DateTime Date {
      get => this._model.Date;
      set {
        this._model.Date = value;
        OnPropertyChanged(nameof(this.Date));
      }
    }



    private ICommand _saveCommand;
    public ICommand SaveCommand {
      get => this._saveCommand;
    }
     
    public AddViewModel(ShopService shopService) {

      this._model = new Offense(); 

      this._saveCommand = new RelayCommand((a) => {
        shopService.Add(this._model);
        ((Window)a).Close(); 
      }, p => true);
    }

  }
}
