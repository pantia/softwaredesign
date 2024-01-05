using LW9.Model;
using System;
using System.Collections;
using System.Collections.Generic;

namespace LW9.Collection {
  public class DoublyLinkedList<T> : IEnumerable<T>, IList<T> {
    private DoublyNode<T> _head;
    public DoublyNode<T> Head {
      get => this._head;
    }

    private DoublyNode<T> _tail;
    public DoublyNode<T> Tail {
      get => this._tail;
    }

    private int _count;
    public int Count {
      get => this._count;
    }

    public void Add(T data) {
      DoublyNode<T> node = new DoublyNode<T>(data);
      this._count = this._count + 1;
      if(this._head == null) {
        this._head = node;
        this._tail = node;
        return;
      }
      DoublyNode<T> lastNode = GetLastNode();
      lastNode._next = node;
      lastNode._previous = Tail;
      this._tail = lastNode;
    }


    public void Replace(T data, T replace) {
      DoublyNode<T> temp = this._head;
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
      DoublyNode<T> temp = this._head;
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

    private DoublyNode<T> GetNode(int index) {
      if(index < 0 || index + 1 > this._count) {
        throw new IndexOutOfRangeException();
      }
      int i = 0;
      DoublyNode<T> temp = this._head;
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
      DoublyNode<T> node = new DoublyNode<T>(data);
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
      DoublyNode<T> node = GetNode(index);
      this._count = this._count - 1;
      if(index == 0) {
        this._head = node._next;
        return;
      } else {
        DoublyNode<T> previous = GetNode(index - 1);
        previous._next = node._next;
      }
    }

    public void Remove(T value) {
      int i = 0;
      DoublyNode<T> temp = this._head;
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

      DoublyNode<T> node = new DoublyNode<T>(data);
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
      DoublyNode<T> temp = this._head;
      while(temp._next != null) {
        if(i == index) {
          break;
        }
        temp = temp._next;
        i = i + 1;
      }

      DoublyNode<T> node = new DoublyNode<T>(data);
      this._count = this._count + 1;
      if(temp == null) {
        this._head = node;
        return;
      }
      node._next = temp._next;
      temp._next = node;
    }

    private DoublyNode<T> GetLastNode() {
      DoublyNode<T> temp = this._head;
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
