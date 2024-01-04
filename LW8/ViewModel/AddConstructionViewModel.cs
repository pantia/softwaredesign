using Core;
using LW8.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace LW8.ViewModel {
  public class AddConstructionViewModel : NotifyPropertyChanged {

    public string Name {
      get => this._model.Name;
      set {
        this._model.Name = value;
        OnPropertyChanged(nameof(this.Name));
      }
    }

    public string ObjectName {
      get => this._model.ObjectName;
      set {
        this._model.ObjectName = value;
        OnPropertyChanged(nameof(this.ObjectName));
      }
    }

    public int Area {
      get => this._model.Area;
      set {
        this._model.Area = value;
        OnPropertyChanged(nameof(this.Area));
      }
    }

    public DateTime StartDate {
      get => this._model.StartDate;
      set {
        this._model.StartDate = value;
        OnPropertyChanged(nameof(this.StartDate));
      }
    }


    public DateTime EndDate {
      get => this._model.EndDate;
      set {
        this._model.EndDate = value;
        OnPropertyChanged(nameof(this.EndDate));
      }
    }

    public ConstructionState State {
      get => this._model.State;
      set {
        this._model.State = value;
        OnPropertyChanged(nameof(this.State));
      }
    }

    private ICommand _saveCommand;
    public ICommand SaveCommand {
      get => this._saveCommand;
    }

    private Construction _model;

    private ConstructionService _service;
    public AddConstructionViewModel(ConstructionService service) {
      this._service = service;
      this._model = new Construction();
      this._saveCommand = new RelayCommand((a) => {
        service.Add(_model);
        ((Window)a).Close();
      
      }, p => true);

    }
  }
}
