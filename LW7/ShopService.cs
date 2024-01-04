using LW7.Model;
using Newtonsoft.Json;
using System.IO;
using System.Windows;

namespace LW7 {
  public class ShopService {

    private SKLAD[] _shop;
    public SKLAD[] Shop {
      get => this._shop;
    }

    public void Save() {
      string output = JsonConvert.SerializeObject(this);
      File.WriteAllText("output", output);
    }


    private int _index;
    public int Index {
      get => this._index;
    }

    public ShopService() {
      this._shop = new SKLAD[200];
      this._index = 0;
    }

    public void Sort() {
      bool swap;
      SKLAD temp;

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

    public void Add(SKLAD sklad) {
      this._shop[this._index] = sklad;
      this._index = this._index + 1; 
    }


  }
}
