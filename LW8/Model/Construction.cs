using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW8.Model {
  public class Construction {

    public string Name { get; set; }
    public string ObjectName { get; set; }  
    public int Area { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public ConstructionState State { get; set; }


  }
}
