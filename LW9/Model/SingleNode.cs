using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW9.Model {
  public class SingleNode<T> {
    public T _data;
    public SingleNode<T> _next;
    public SingleNode(T data) {
      this._data = data;
      this._next = null;
    }
  }
}
