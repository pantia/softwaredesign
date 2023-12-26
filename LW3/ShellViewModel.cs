using Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LW3 {
  public class ShellViewModel : NotifyPropertyChanged {
    private ObservableCollection<int> _numbers;
    public ObservableCollection<int> Numbers {
      get => this._numbers;
    }

    private ObservableCollection<int> _numbers32;
    public ObservableCollection<int> Numbers32 {
      get => this._numbers32;
    }
 
    private ObservableCollection<int> _output;
    public ObservableCollection<int> Output {
      get => this._output;
    }

    public int Rows {
      get => this._matrix.GetLength(0);
    }

    public int Columns {
      get => this._matrix.GetLength(1);
    }

    private int[,] _matrix;

    private ICommand _bubbleSortCommand;
    public ICommand BubbleSortCommand {
      get => this._bubbleSortCommand;
    }

    private ICommand _shakerSortCommand;
    public ICommand ShakerSortCommand {
      get => this._shakerSortCommand;
    }

    private ICommand _insertionSortCommand;
    public ICommand InsertionSortCommand {
      get => this._insertionSortCommand;
    }

    private ICommand _stoogeSortCommand;
    public ICommand StoogeSortCommand {
      get => this._stoogeSortCommand;
    }

    private ICommand _shellSortCommand;
    public ICommand ShellSortCommand {
      get => this._shellSortCommand;
    }

    private ICommand _mergeSortCommand;
    public ICommand MergeSortCommand {
      get => this._mergeSortCommand;
    }

    private ICommand _selectionSortCommand;
    public ICommand SelectionSortCommand {
      get => this._selectionSortCommand;
    }


    private ICommand _quickSortCommand;
    public ICommand QuickSortCommand {
      get => this._quickSortCommand;
    }

    private int _searchText;
    public int SearchText {

      get => this._searchText;
      set {
        this._searchText = value;
        OnPropertyChanged(nameof(this.SearchText));
      }
    }

    private ICommand _binarySearchCommand;
    public ICommand BinarySearchCommand {
      get => this._binarySearchCommand;
    }

    private ICommand _linearSearchCommand;
    public ICommand LinearSearchCommand {
      get => this._linearSearchCommand;
    }

    private ICommand _longestCommonSubstringCommand;
    public ICommand LongestCommonSubstringCommand {
      get => this._longestCommonSubstringCommand;
    }

    private string _searchResult;
    public string SearchResult {

      get => this._searchResult;
      set {
        this._searchResult = value;
        OnPropertyChanged(nameof(this.SearchResult));
      }
    }

    private string _text1;
    public string Text1 {

      get => this._text1;
      set {
        this._text1 = value;
        OnPropertyChanged(nameof(this.Text1));
      }
    }

    private string _text2;
    public string Text2 {

      get => this._text2;
      set {
        this._text2 = value;
        OnPropertyChanged(nameof(this.Text2));
      }
    }

    private string _lcsText;
    public string LCSText {

      get => this._lcsText;
      set {
        this._lcsText = value;
        OnPropertyChanged(nameof(this.LCSText));
      }
    }

    public ShellViewModel() {
      this._numbers = new ObservableCollection<int>();
      this._output = new ObservableCollection<int>();
      this._numbers32 = new ObservableCollection<int>(); 
      this._matrix = Core.LW3.Generate31();
      foreach(int number in this._matrix) {
        this._numbers.Add(number);
      }
      int[] output = Core.LW3.Calculate(this._matrix);
      foreach(int number in output) {
        this._output.Add(number);
      }
      var array = Core.LW3.Generate32();
      foreach(int number in array) {
        this._numbers32.Add(number);
      }

 
      this._bubbleSortCommand = new RelayCommand((a) => {
        this._numbers32.Clear();
        foreach(int number in Core.LW3.BubbleSort(array)) {

          this._numbers32.Add(number);
        }

      }, p => true);

      this._shakerSortCommand = new RelayCommand((a) => {
        this._numbers32.Clear();
        foreach(int number in Core.LW3.ShakerSort(array)) {

          this._numbers32.Add(number);
        }

      }, p => true);

      this._insertionSortCommand = new RelayCommand((a) => {
        this._numbers32.Clear();
        foreach(int number in Core.LW3.InsertionSort(array)) {

          this._numbers32.Add(number);
        }

      }, p => true);

      this._stoogeSortCommand = new RelayCommand((a) => {
        this._numbers32.Clear();
        foreach(int number in Core.LW3.StoogeSort(array)) {

          this._numbers32.Add(number);
        }

      }, p => true);

      this._shellSortCommand = new RelayCommand((a) => {
        this._numbers32.Clear();
        foreach(int number in Core.LW3.ShellSort(array)) {

          this._numbers32.Add(number);
        }

      }, p => true);

      this._mergeSortCommand = new RelayCommand((a) => {
        this._numbers32.Clear();
        foreach(int number in Core.LW3.MergeSort(array)) {

          this._numbers32.Add(number);
        }

      }, p => true);

      this._selectionSortCommand = new RelayCommand((a) => {
        this._numbers32.Clear();
        foreach(int number in Core.LW3.SelectionSort(array)) {

          this._numbers32.Add(number);
        }

      }, p => true);

      this._quickSortCommand = new RelayCommand((a) => {
        this._numbers32.Clear();
        foreach(int number in Core.LW3.QuickSort(array)) {

          this._numbers32.Add(number);
        }

      }, p => true);

      this._binarySearchCommand = new RelayCommand((a) => {
        int[] ar = this._numbers32.ToArray();
        int index= Core.LW3.BinarySearch(ar, this.SearchText, 0, ar.Length - 1);
        this.SearchResult = index.ToString();
      }, p => true);

      this._linearSearchCommand = new RelayCommand((a) => {
        int[] ar = this._numbers32.ToArray();
        int index = Core.LW3.LinearSearch(ar, this.SearchText);
        this.SearchResult = index.ToString();
      }, p => true);

      this._longestCommonSubstringCommand = new RelayCommand((a) => {
        this.LCSText = Core.LW3.LongestCommonSubstring(this.Text1, this.Text2);
      }, p => true);
    }
  }
}
