using LW8.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW8 {
  public class ConstructionService {

    private List<Construction> _constructions;
    public List<Construction> Constructions {
      get => this._constructions;
    }
    

    public void Add(Construction construction) {
      this._constructions.Add(construction);
    }

    public ConstructionService() {
      this._constructions = new List<Construction>(); 
    }


  }
}
