﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core {
  public abstract class NotifyPropertyChanged : INotifyPropertyChanged {
    public event PropertyChangedEventHandler PropertyChanged;
    public void OnPropertyChanged(string property) {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
    }
  }
}
