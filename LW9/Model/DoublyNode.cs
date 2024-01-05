using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW9.Model {
  public class DoublyNode<T> {
    public T _data;
    public DoublyNode<T> _previous;
    public DoublyNode<T> _next;
    public DoublyNode(T data) {
      this._data = data;
      this._next = null;
      this._previous = null;
    }
  }
}
