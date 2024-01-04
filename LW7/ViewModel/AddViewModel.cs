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

    private SKLAD _model;
    public string Name {
      get => this._model.Name;
      set {
        this._model.Name = value;
        OnPropertyChanged(nameof(this.Name));
      }
    }

    public int Quantity {
      get => this._model.Quantity;
      set {
        this._model.Quantity = value;
        OnPropertyChanged(nameof(this.Quantity));
      }
    }


    public SKLADType Type {
      get => this._model.Type;
      set {
        this._model.Type = value;
      }
    }

    public int Cost {
      get => this._model.Cost;
      set {
        this._model.Cost = value;
        OnPropertyChanged(nameof(this.Cost));
      }
    }

    private ICommand _saveCommand;
    public ICommand SaveCommand {
      get => this._saveCommand;
    }
     
    public AddViewModel(ShopService shopService) {

      this._model = new SKLAD(); 

      this._saveCommand = new RelayCommand((a) => {
        shopService.Add(this._model);
        ((Window)a).Close(); 
      }, p => true);
    }

  }
}
