using LW7.Model;
using System;
using System.IO;
using System.Windows;

namespace LW7 {
  public class ShopService {

    private Offense[] _shop;
    public Offense[] Shop {
      get => this._shop;
    }

    public void Save() {
    //  string output = JsonConvert.SerializeObject(this);
    //  File.WriteAllText("output", output);
    }


    private int _index;
    public int Index {
      get => this._index;
    }

    public ShopService() {
      this._shop = new Offense[200];
      this._index = 0;
    }

    public void Refresh() {
      for(int i = 0; i < this._index; i++) {
        this._shop[i].TimePassed = DateTime.Now - this._shop[i].Date;
      }
    }

    public void Sort() {
      bool swap;
      Offense temp;

      do {
        swap = false;

        for(int index = 0; index < (_index - 1); index++) {
          if(string.Compare(Shop[index].Name, Shop[index + 1].Name) < 0) {
            temp = Shop[index];
            Shop[index] = Shop[index + 1];
            Shop[index + 1] = temp;
            swap = true;
          }
        }

      } while(swap == true);
    }

    public void Add(Offense sklad) {
      this._shop[this._index] = sklad; 
      sklad.TimePassed = DateTime.Now - sklad.Date;
      this._index = this._index + 1; 
    }


  }
}
