using System.Drawing;

namespace LW1 {
  public class Bishop : ChessPiece {
    public Bishop(ChessTeam team) : base(team) {
    }

    public override ChessPiece[] Intersect(ChessBoard board) {

      List<ChessPiece> list = new List<ChessPiece>();
      ChessPiece? piece = null;
      int x = this._position.X;
      int y = this._position.Y;

      while(x < 7 && y < 7) {
        x = x + 1;
        y = y + 1;
        piece = board.Get(x, y);
        if(piece != null) {
          list.Add(piece);
        }
      }

      x = this._position.X;
      y = this._position.Y;

      while(x > 0 && y > 0) {
        x = x - 1;
        y = y - 1;
        piece = board.Get(x, y);
        if(piece != null) {
          list.Add(piece);
        }
      }

      x = this._position.X;
      y = this._position.Y;

      while(x < 7 && y > 0) {
        x = x + 1;
        y = y - 1;
        piece = board.Get(x, y);
        if(piece != null) {
          list.Add(piece);
        }
      }

      x = this._position.X;
      y = this._position.Y;

      while(x > 0 && y < 7) {
        x = x - 1;
        y = y + 1;
        piece = board.Get(x, y);
        if(piece != null) {
          list.Add(piece);
        }
      }

      return list.ToArray();
    }

    public override string ToString() {
      Point position = ChessBoard.Translate(this._position.X, this._position.Y);
      return string.Format("{0} bishop ({1}, {2})", this.Team, position.X, position.Y);
    }



  }
}
