using LW9.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace LW9.Collection {


  public class BaseEnumerator<Node> : IEnumerator<Node> {


    private IList<Node> _list;
    int position = -1;

    public BaseEnumerator(IList<Node> list) {
      this._list = list; 
    }

    public Node Current {
      get {
        return this._list.Get(position);
      }
    }

    object IEnumerator.Current => Current;

    public void Dispose() {
      GC.Collect(); 
    }

    public bool MoveNext() {
      position++;
      return (position < _list.Count);
      
    }

    public void Reset() {
      position = -1; 
    }
  }

  public class SingleLinkedList<T> : IList<T> {

    private SingleNode<T> _head;
    public SingleNode<T> Head {
      get => this._head;
    }

    private int _count;
    public int Count {
      get => this._count;
    }

    public void Add(T data) {
      SingleNode<T> node = new SingleNode<T>(data);
      this._count = this._count + 1;
      if(this._head == null) {
        this._head = node;
        return;
      }
      SingleNode<T> lastNode = GetLastNode();
      lastNode._next = node;
    }


    public void Replace(T data, T replace) {
      SingleNode<T> temp = this._head;
      while(temp._next != null) {
        var next = temp._next;
        if(temp._data.Equals(data)) {
          temp._data = replace; 
        }
        temp = next;  
      }
      if(temp._data.Equals(data)) {
        temp._data = replace;
      }
    }

    public T Get(int index) {
      return GetNode(index)._data; 
    }

    public int IndexOf(T data) {
       
      int i = 0;
      SingleNode<T> temp = this._head; 
      while(temp._next != null) {
        temp = temp._next;
        i = i + 1;
        if(temp._data.Equals(data)) {
          return i;
        }
      }
      if(temp._data.Equals(data)) {
        return i;
      }
      return -1;
    }


    public void Sort() {
      bool swap;
      T temp;

      do {
        swap = false;

        for(int index = 0; index < (Count - 1); index++) {
          if(string.Compare(GetNode(index)._data as string, GetNode(index + 1)._data as string) < 0) {
            temp = GetNode(index)._data;
            GetNode(index)._data = GetNode(index + 1)._data;
            GetNode(index + 1)._data = temp; 
            swap = true;
          }
        }

      } while(swap == true);
    }

    public void Set(int index, T data) {
      GetNode(index)._data = data;
    }

    private SingleNode<T> GetNode(int index) {
      if(index < 0 || index + 1 > this._count) {
        throw new IndexOutOfRangeException();
      }
      int i = 0;
      SingleNode<T> temp = this._head;
      if(index == i) {
        return temp;
      }
      while(temp._next != null) {
        temp = temp._next;
        i = i + 1;
        if(i == index) {
          return temp;
        }
      }
      return null;
    }

    public void AddFirst(T data) {
      SingleNode<T> node = new SingleNode<T>(data);
      this._count = this._count + 1;
      var tmp = this._head; 
      if(tmp == null) {
        this._head = node;
        return;
      }
      this._head = node;
      this._head._next = tmp;
    }

    public void Clear() {
      this._head = null;
      this._count = 0;
    }

    public void RemoveAt(int index) {
      if(index < 0 || index + 1 > this._count) {
        throw new IndexOutOfRangeException();
      }
      SingleNode<T> node = GetNode(index);
      this._count = this._count - 1;
      if(index == 0) {
        this._head = node._next;
        return;
      } else {
        SingleNode<T> previous = GetNode(index - 1);
        previous._next = node._next;
      } 
    }

    public void Remove(T value) {
      int i = 0;
      SingleNode<T> temp = this._head; 
      while(temp._next != null) { 
        var next = temp._next;
        if(temp._data.Equals(value)) {
          RemoveAt(i);
        }
        temp = next; 
        i = i + 1; 
      }
      if(temp._data.Equals(value)) {
        RemoveAt(i);
      }
    }

    public void AddLast(T data) {

      SingleNode<T> node = new SingleNode<T>(data);
      this._count = this._count + 1; 
      if(this._head == null) {
        this._head = node;
        return;
      }
      var last = GetLastNode();
      last._next = node; 
    }

    public void Insert(int index, T data) {
      if(index < 0 || index + 1 > this._count) {
        throw new IndexOutOfRangeException();
      }
      int i = 0;
      SingleNode<T> temp = this._head;
      while(temp._next != null) { 
        if(i == index) {
          break;
        }
        temp = temp._next;
        i = i + 1;
      }

      SingleNode<T> node = new SingleNode<T>(data); 
      this._count = this._count + 1;
      if(temp == null) {
        this._head = node;
        return;
      } 
      node._next = temp._next;
      temp._next = node;
    }

    private SingleNode<T> GetLastNode() {
      SingleNode<T> temp = this._head;
      while(temp._next != null) {
        temp = temp._next;
      }
      return temp;
    }

    public IEnumerator<T> GetEnumerator() {
      return new BaseEnumerator<T>(this);
     
    }

    IEnumerator IEnumerable.GetEnumerator() {
      return this.GetEnumerator(); 
    }
  }
}
