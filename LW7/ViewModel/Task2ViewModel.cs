using Core;
using LW7.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW7.ViewModel {
  public class Task2ViewModel : NotifyPropertyChanged {

    private string _output;
    public string Output {
      get => this._output;
      set {
        this._output = value;
        OnPropertyChanged(nameof(Output));
      }
    }


    private Car _selected;
    public Car Selected {
      get => this._selected;
      set {
        this._selected = value;
        switch(value) {
          case Car.BMW: {
            this.Output = "BMW - BMW Group (1916, BMW X1, BMW X2, BMW X3)";
            break;
          }
          case Car.Mazda: {
            this.Output = "Mazda – Mazda Motor Korporation (1920, CX-30, CX-60, CX-5, CX-90)";
            break;
          }
          case Car.MercedesBenz: {
            this.Output = "Mercedes-Benz – Daimler AG (1926, A140, A 170 CDI, A160CDI)";
            break;
          }
          case Car.Opel: {
            this.Output = "Opel – Adam Opel GmbH (1862, ASTRA, MOKKA, CROSSLAND)";
            break;
          }
          case Car.Skoda: {
            this.Output = "Skoda – Skoda Auto (1990, Rapid, Octavia, Superb)";
            break;
          }
          case Car.Toyota: {
            this.Output = "Toyota – Toyota Motor Corporation (1937, Yaris, Corolla, Camry)";
            break;
          }
          case Car.Volkswagen: {
            this.Output = "Volkswagen – Volkswagen AG (1937, «Caddy, Golf, Passat»).";
            break;
          }
        }
        OnPropertyChanged(nameof(Selected));
      }
    }

    public Task2ViewModel() {
      this.Selected = Car.BMW;
    }
  }
}
