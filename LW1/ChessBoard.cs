using System.Drawing;

namespace LW1 {
  public class ChessBoard {

    private ChessPiece[][] _pieces;

    public ChessBoard() {
      this._pieces = new ChessPiece[8][];
      for(int i = 0; i < this._pieces.Length; i++) {
        this._pieces[i] = new ChessPiece[8];
      }
    }

    private static Point Translate07(int x, int y) {
      if(x < 1 || x > 8 || y < 1 || y > 8) {
        throw new Exception("invalid position");
      }
      return new Point(8 - y, x - 1);
    }

    public static Point Translate(int x, int y) {
      if(x < 0 || x > 7 || y < 0 || y > 7) {
        throw new Exception("invalid position");
      }
      return new Point(y + 1, 8 - x);
    }

    public ChessPiece Get(int x, int y) {
      return this._pieces[x][y];
    }

    public void Add(ChessPiece piece, int x, int y) {
      Point position = Translate07(x, y);
      if(this._pieces[position.X][position.Y] == null) {
        this._pieces[position.X][position.Y] = piece;
        piece.OnMove(position);
      } else {
        throw new Exception("occupied");
      }
    }

    public ChessPiece[] Intersect(ChessPiece piece) {
      return piece.Intersect(this);
    }

    public ChessPiece[] IntersectAttacks(ChessPiece piece) {
      return piece.Intersect(this).Where(x => x.Team != piece.Team).ToArray();
    }

    public ChessPiece[] IntersectDefends(ChessPiece piece) {
      return piece.Intersect(this).Where(x => x.Team == piece.Team).ToArray();
    }

  }
}
