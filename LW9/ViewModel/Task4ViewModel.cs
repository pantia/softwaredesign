using Core;
using LW7.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW9.ViewModel {
  public class Task4ViewModel : NotifyPropertyChanged {


    private ArrayList _shop;

    public Task4ViewModel() {
      this._shop = new ArrayList();
      this._shop.Add(new SKLAD() {
        Cost = 50,
        Name = "Test 1",
        Quantity = 1,
        Type =SKLADType.KG
      });
      this._shop.Add(new SKLAD() {
        Cost = 50,
        Name = "Test 2",
        Quantity = 1,
        Type = SKLADType.KG
      });
      Debug.WriteLine(this._shop.Count);
      this._shop.Clear();
      Debug.WriteLine(this._shop.Count);

    }

  }
}
