using Core;
using LW8.Model;
using LW8.View;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace LW8.ViewModel {
  public class Task2ViewModel : NotifyPropertyChanged {


    private ICommand _addCommand;
    public ICommand AddCommand {
      get => this._addCommand;
    }

    private ICommand _fourCommand;
    public ICommand FourCommand {
      get => this._fourCommand;
    }

    private ICommand _resetCommand;
    public ICommand ResetCommand {
      get => this._resetCommand;
    }

    private ICommand _thisYearCommand;
    public ICommand ThisYearCommand {
      get => this._thisYearCommand;
    }

    private ICommand _minTimeCommand;
    public ICommand MinTimeCommand {
      get => this._minTimeCommand;
    }
    

    private ObservableCollection<Construction> _constructions;
    public ObservableCollection<Construction> Constructions {
      get => this._constructions;
      
    }


    private ConstructionService _service;

    public Task2ViewModel() {
      this._service = new ConstructionService();
      
      this._addCommand = new RelayCommand((a) => {
        AddConstructionView view = new AddConstructionView();
        view.DataContext = new AddConstructionViewModel(this._service);
        view.ShowDialog(); 
      }, p => true);

      this._resetCommand = new RelayCommand((a) => {

        this._constructions = new ObservableCollection<Construction>(_service.Constructions);
        OnPropertyChanged(nameof(Constructions));

      }, p => true);
      this._fourCommand = new RelayCommand((a) => {

        this._constructions = new ObservableCollection<Construction>(_service.Constructions.Where(x => x.State == ConstructionState.PROGRESS && x.EndDate.Month >= 9));
        OnPropertyChanged(nameof(Constructions));
      
      }, p => true);

      this._thisYearCommand = new RelayCommand((a) => {

        this._constructions = new ObservableCollection<Construction>(_service.Constructions.Where(x => x.EndDate.Year >= DateTime.Now.Year));
        OnPropertyChanged(nameof(Constructions));

      }, p => true);
      this._minTimeCommand = new RelayCommand((a) => {

        this._constructions = new ObservableCollection<Construction>(_service.Constructions.Where(x => x.State == ConstructionState.PROGRESS && x.EndDate.Year < DateTime.Now.Year));
        OnPropertyChanged(nameof(Constructions));

      }, p => true);

    }

  }
}
