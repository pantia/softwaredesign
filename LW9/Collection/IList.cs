using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW9.Collection {
  public interface IList<T> : IEnumerable<T> {

    int Count { get; }
    void Add(T item);
    void Replace(T data, T replace);
    T Get(int index);
    int IndexOf(T item);
    void Sort();
    void Set(int index, T data);
    void AddFirst(T item);
    void RemoveAt(int index);
    void Clear();
    void Remove(T value);
    void AddLast(T data);
    void Insert(int index, T data);

  }
}
