namespace LW2 {
  public class App {

    private Random _random;

    public App() {
      this._random = new Random();
    }

    public void Run() {
      Console.WriteLine("Variant 33");
      //Task21();
      //Task22();
      //Task23();
      // Task24();
      // Task25();
      //Task26();
      Task27();
    }



    public void Task21() {
      Console.WriteLine("Task 2.1 (Variant 3)");
      Console.Write("Enter n: ");
      if(int.TryParse(Console.ReadLine(), out int n)) {
        int[] array = new int[n];
        int sum = 0;
        for(int i = 0; i < n; i++) {
          array[i] = this._random.Next(-100, 100);
          sum = sum + array[i];
          Console.Write(array[i] + " ");
        }
        int arithmeticMean = sum / n;
        int count = 0;
        for(int i = 0; i < array.Length; i++) {
          if(Math.Abs(array[i]) > arithmeticMean) {
            count = count + 1;
          }
        }
        Console.Write("\r\nArithmetic mean: {0}", arithmeticMean);
        Console.Write("\r\nAbs > Arithmetic mean count: {0}", count);
      }
    }

    public void Task22() {
      Console.WriteLine("Task 2.2 (Variant 3)");
      Console.Write("Enter array: ");
      string input = Console.ReadLine();
      string[] array = input.Split(' ');
      var most = array.Select(x => int.Parse(x)).GroupBy(i => i).OrderByDescending(grp => grp.Count())
        .Select(grp => grp.Key);
      Console.Write("Most common: ");
      foreach(int val in most) {
        Console.Write(val + " ");
      }
    }



    public void Task23() {
      Console.WriteLine("Task 2.3 (Variant 3)");
      Console.Write("Enter array: ");
      string input = Console.ReadLine();
      int[] array = input.Split(' ').Select(x => int.Parse(x)).ToArray();
      Console.Write("Enter binary number: ");
      input = Console.ReadLine();
      int number = Convert.ToInt32(input, 2);
      int maxDistance = 0;
      int index = 0;

      for(int i = 0; i < array.Length; i++) {
        int abs = Math.Abs(array[i] - number);
        if(abs > maxDistance) {
          maxDistance = abs;
          index = i;
        }
      }
      Console.Write("Max distance: index {0}, value {1}", index, array[index]);
    }

    private void Print(int[,] matrix, int n) {
      for(int i = 0; i < n; i++) {
        for(int j = 0; j < n; j++) {
          Console.Write(matrix[i, j] + " ");
        }
        Console.Write("\r\n");
      }
    }

    private bool Compare(int[,] a, int[,] b, int index, int n) {

      for(int i = 0; i < n; i++) {
        if(a[index, i] != b[i, index]) {
          return false;
        }
      }

      return true;
    }

    public void Task24() {
      Console.WriteLine("Task 2.4 (Variant 3)");
      Console.Write("Enter n: ");
      if(int.TryParse(Console.ReadLine(), out int n)) {
        int[,] a = new int[n, n];
        int[,] b = new int[n, n];
        for(int i = 0; i < n; i++) {
          for(int j = 0; j < n; j++) {
            a[i, j] = this._random.Next(-50, 49);
            b[i, j] = this._random.Next(-50, 49);
          }
        }
        Console.Write("A:\r\n");
        Print(a, n);
        Console.Write("B:\r\n");
        Print(b, n);

        byte[] vector = new byte[n];

        for(int i = 0; i < n; i++) {
          if(Compare(a, b, i, n)) {
            vector[i] = 1;
          } else {
            vector[i] = 0;
          }
        }
      }
    }

    public void Task25() {
      Console.WriteLine("Task 2.4 (Variant 3)");
      Console.Write("Enter n: ");
      if(int.TryParse(Console.ReadLine(), out int n)) {
        int[,] a = new int[n, n];
        for(int i = 0; i < n; i++) {
          for(int j = 0; j < n; j++) {
            a[i, j] = this._random.Next(-50, 49);
          }
        }
        Console.Write("A:\r\n");
        Print(a, n);

        bool br = false;
        for(int i = n - 1; i > 0; i--) {
          for(int j = n - 1; j > 0; j--) {
            if(a[i, j] < 0) {
              br = true;
              Console.Write("Last < 0: [{0},{1}] {2}", i, j, a[i, j]);
              break;
            }
          }
          if(br) {
            break;

          }
        }
      }
    }

    public void Task26() {
      Console.WriteLine("Task 2.6 (Variant 3)");
      Console.Write("Enter n: ");
      if(int.TryParse(Console.ReadLine(), out int n)) {
        Console.Write("Enter grades: ");
        string input = Console.ReadLine();
        int[] array = input.Split(' ').Select(x => int.Parse(x)).ToArray();
        int[,] matrix = new int[n, n];
        for(int i = 0; i < n; i++) {
          for(int j = 0; j < n; j++) {
            matrix[i, j] = array[i * n + j];
          }
        }
        Console.Write("Grades:\r\n");
        Print(matrix, n);
        for(int i = 0; i < n; i++) {
          int sum = 0;
          for(int j = 0; j < n; j++) {
            sum = sum + matrix[j, i];

          }
          matrix[n - 1, i] = sum / n;
          sum = 0;
        }

        Console.Write("\r\n");
        int gpa = 0;
        for(int i = 0; i < n; i++) {
          gpa = gpa + matrix[n - 1, i];
          Console.Write(matrix[n - 1, i] + " ");

        }
        Console.Write("\r\nGPA: {0}", gpa / n);

        // Print(matrix, n);

      }
    }

    public void Task27() {
      Console.WriteLine("Task 2.7 (Variant 3)");
      Console.Write("Enter n: ");
      if(int.TryParse(Console.ReadLine(), out int n)) {
        Console.Write("Enter numbers: ");
        string input = Console.ReadLine();
        int[] array = input.Split(' ').Select(x => int.Parse(x)).ToArray();
        int[,] matrix = new int[n, n];
        for(int i = 0; i < n; i++) {
          for(int j = 0; j < n; j++) {
            matrix[i, j] = array[i * n + j];
          }
        }
        Console.Write("Numbers:\r\n");
        Print(matrix, n);
        for(int i = 0; i < n; i++) {
          int sum = 0;
          for(int j = 0; j < n; j++) {
            if(matrix[j, i] < 0) {
              sum = sum + matrix[j, i];
            }

          }
          matrix[n - 1, i] = sum;
          sum = 0;
        }

        Console.Write("\r\n");
        for(int i = 0; i < n; i++) {
          Console.Write(matrix[n - 1, i] + " ");

        }

        // Print(matrix, n);

      }
    }

  }
}
