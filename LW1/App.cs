using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW1 {
  public class App {


    private int CalculateSquareAreaByDiagonal(int length) {
      return length * length / 2;
    }

    private double CalculateSquarePerimeterByDiagonal(int length) {
      return length * (4 / Math.Sqrt(2));
    }

    private double Calculate1dot3(int x, int r) {
      if(x >= -5 && x <= -4) {
        return 2;
      }
      if(x >= -4 && x <= 0) {
        return 0.5*x;
      } 
      if(x >= Math.PI) {
        return x - Math.PI;
      }
      if(x >= 0 && x <= Math.PI) {
        return Math.Sin(x);
      }
      if(x >= -9 && x <= -5) {
        return Math.Abs(Math.Sqrt(Math.Pow(r,2)-Math.Pow(x+7,2))-2);
      }
      return -1;
    }

    private string Calculate1dot4(int x, int y, int r) {
      if(x >= 0 && Math.Abs(x) <= r && y >= 0 && Math.Abs(y) <= r) {
        return "hit";
      }
      if(x <= 0 && Math.Abs(x) <= r && y <= 0 && Math.Abs(y) <= r) {
        return "hit";
      }
      if(x <= 0 && Math.Abs(x) <= r && y >= 0 && Math.Abs(y) <= r && y <= -1*Math.Sqrt(Math.Pow(r,2)-Math.Pow(x+r,2))+r) {
        return "hit";
      }
      if(x <= 0 && Math.Abs(x) <= r && y <= 0 && Math.Abs(y) <= r && y >= Math.Sqrt(Math.Pow(r, 2) - Math.Pow(x - r, 2)) - r) {
        return "hit";
      }
      return "miss"; 
    }

    private int Factorial(int f) {
      if(f == 0)
        return 1;
      else
        return f * Factorial(f - 1);
    }

    private string Calculate1dot5(int number) { 
      switch(number) {
        case 6:
          return "six";
        case 7: 
          return "seven";
        case 8: 
          return "eight";
        case 9:
          return "nine";
        case 10:
          return "ten";
        case 11:
          return "jack";
        case 12:
          return "queen";
        case 13:
          return "king";
        case 14:
          return "ace";
        default: {
          return "undefined";
        }
      }
    }

    private string Calculate1dot6(int number) {
      switch(number) {
        case 6:
        return "six";
        case 7:
        return "seven";
        case 8:
        return "eight";
        case 9:
        return "nine";
        case 10:
        return "ten";
        case 11:
        return "jack";
        case 12:
        return "queen";
        case 13:
        return "king";
        case 14:
        return "ace";
        default: {
          return "undefined";
        }
      }
    }

    private double Calculate1dot7(int x) {
      double sum = 0;
      for(int i = 1; i < 9; i++) {
        sum = sum + Math.Pow(x, i) / Factorial(i);
      }
      return sum;
    }

    private double Calculate1dot8(int k) {
      double sum = 0;
      for(int i = 1; i < 6; i++) {
        sum = sum + (Math.Pow(-1, k + 1) * Math.Pow(i, 2 * k - 1)) / (2 * k - 1) * Factorial(k);
      }
  
      return sum;
    }

    private double Calculate1dot9(int n) {
      double sum = 0;
      for(int i = 1; i < n; i++) {
        sum = sum + (Math.Pow(3 * 0.5, n) * Factorial(n)) / Factorial(3 * n);
      }

      return sum;
    }


    public void Run() {
      string? input = null;
      Console.WriteLine("Mykhailo Pantia Variant 3");
      Console.Write("1.1. Enter length: ");
      input = Console.ReadLine();
      if(input != null) {
        int length = int.Parse(input);
        Console.WriteLine("Square area: " + CalculateSquareAreaByDiagonal(length));
        Console.WriteLine("Square perimeter: " + CalculateSquarePerimeterByDiagonal(length));
      }

      Console.Write("1.2. Enter 4-digit number: "); 
      input = Console.ReadLine();
      if(input != null) {
        int first = int.Parse(input.Substring(0,1));
        int third = int.Parse(input.Substring(2,1));
        Console.WriteLine(string.Format("The difference between {0} and {1} is {2}", first, third, first - third));
      }

      Console.Write("1.3. Enter R: ");
      input = Console.ReadLine();
      if(input != null) {
        int r = int.Parse(input);
        Console.Write("1.3. Enter X: ");
        input = Console.ReadLine();
        if(input != null) { 
          int x = int.Parse(input);
          Console.WriteLine("y = " + Calculate1dot3(x, r));
        }
      }

      Console.Write("1.4. Enter R: ");
      input = Console.ReadLine();
      if(input != null) {
        int r = int.Parse(input);
        Console.Write("1.4. Enter X: ");
        input = Console.ReadLine();
        if(input != null) {
          int x = int.Parse(input);
          Console.Write("1.4. Enter Y: ");
          input = Console.ReadLine();
          if(input != null) {
            int y = int.Parse(input);
            Console.WriteLine(Calculate1dot4(x, y, r));
          } 
        }
      }

      Console.Write("1.5. Enter number: ");
      input = Console.ReadLine();
      if(input != null) {
        int number = int.Parse(input);
        Console.WriteLine(Calculate1dot5(number)); 
      }

      ChessBoard chessBoard = new ChessBoard();
      Castle firstCastle = new Castle(ChessTeam.WHITE);
      Castle secondCastle = new Castle(ChessTeam.WHITE);
      Bishop firstBishop = new Bishop(ChessTeam.BLACK);
      Bishop secondBishop = new Bishop(ChessTeam.BLACK);
      Console.Write("1.6. Enter first white castle coordinate (x, y): ");
      input = Console.ReadLine();
      if(input != null) {
        string[] xy = input.Split(','); 
        chessBoard.Add(firstCastle, int.Parse(xy[0]), int.Parse(xy[1])); 
      }
      Console.Write("1.6. Enter second white castle coordinate (x, y): ");
      input = Console.ReadLine();
      if(input != null) {
        string[] xy = input.Split(',');
        chessBoard.Add(secondCastle, int.Parse(xy[0]), int.Parse(xy[1]));
      }
      Console.Write("1.6. Enter first black bishop coordinate (x, y): ");
      input = Console.ReadLine();
      if(input != null) {
        string[] xy = input.Split(',');
        chessBoard.Add(firstBishop, int.Parse(xy[0]), int.Parse(xy[1]));
      }

      Console.Write("1.6. Enter second black bishop coordinate (x, y): ");
      input = Console.ReadLine();
      if(input != null) {
        string[] xy = input.Split(',');
        chessBoard.Add(secondBishop, int.Parse(xy[0]), int.Parse(xy[1]));
      }

      Console.WriteLine("1.6. First white castle attacks (x, y): ");
      foreach(var piece in chessBoard.IntersectAttacks(firstCastle)) {
        Console.WriteLine(piece.ToString());
      }

      Console.WriteLine("1.6. First white castle defends (x, y): ");
      foreach(var piece in chessBoard.IntersectDefends(firstCastle)) {
        Console.WriteLine(piece.ToString());
      }

      Console.WriteLine("1.6. Second white castle attacks (x, y): ");
      foreach(var piece in chessBoard.IntersectAttacks(secondCastle)) {
        Console.WriteLine(piece.ToString());
      }

      Console.WriteLine("1.6. Second white castle defends (x, y): ");
      foreach(var piece in chessBoard.IntersectDefends(secondCastle)) {
        Console.WriteLine(piece.ToString());
      }

      Console.WriteLine("1.6. First black bishop attacks (x, y): ");
      foreach(var piece in chessBoard.IntersectAttacks(firstBishop)) {
        Console.WriteLine(piece.ToString());
      }

      Console.WriteLine("1.6. First black bishop defends (x, y): ");
      foreach(var piece in chessBoard.IntersectDefends(firstBishop)) {
        Console.WriteLine(piece.ToString());
      }

      Console.WriteLine("1.6. Second black bishop attacks (x, y): ");
      foreach(var piece in chessBoard.IntersectAttacks(secondBishop)) {
        Console.WriteLine(piece.ToString());
      }

      Console.WriteLine("1.6. Second black bishop defends (x, y): ");
      foreach(var piece in chessBoard.IntersectDefends(secondBishop)) {
        Console.WriteLine(piece.ToString());
      }

  
      Console.Write("1.7. Enter x: ");
      input = Console.ReadLine();
      if(input != null) {
        int x = int.Parse(input);
        Console.WriteLine("1.7. " + Calculate1dot7(x).ToString());
      }

      Console.Write("1.8. Enter k: ");
      input = Console.ReadLine();
      if(input != null) {
        int x = int.Parse(input);
        Console.WriteLine("1.8. " + Calculate1dot8(x).ToString());
      }

      Console.Write("1.9. Enter n: ");
      input = Console.ReadLine();
      if(input != null) {
        int x = int.Parse(input);
        Console.WriteLine("1.9. " + Calculate1dot9(x).ToString());
      }

      Console.Write("1.10. Enter R: ");
      input = Console.ReadLine();
      if(input != null) {
        int r = int.Parse(input);
        int step = 0;
        List<string> results = new List<string>();
        while(step < 10) {
          Console.Write(string.Format("1.10.{0} Enter X: ", step + 1));
          input = Console.ReadLine();
          if(input != null) {
            int x = int.Parse(input);
            Console.Write(string.Format("1.10.{0} Enter Y: ", step + 1));
            input = Console.ReadLine();
            if(input != null) {
              int y = int.Parse(input);
              results.Add(Calculate1dot4(x, y, r)); 
            }
          }
          step = step + 1;
        }
        step = 0;
        foreach(string result in results) {
          step = step + 1;
          Console.WriteLine(string.Format("1.10.{0} - {1}", step, result));
        }
      } 
    }

  }
}
