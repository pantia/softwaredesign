using System.Drawing;

namespace LW1 {
  public class Castle : ChessPiece {
    public Castle(ChessTeam team) : base(team) {
    }

    public override ChessPiece[] Intersect(ChessBoard board) {
      List<ChessPiece> list = new List<ChessPiece>();
      ChessPiece? piece = null;
      for(int i = 0; i < 8; i++) {
        piece = board.Get(i, this._position.Y);
        if(piece != null && piece != this) {
          list.Add(piece);
        }
        piece = board.Get(this._position.X, i);
        if(piece != null && piece != this) {
          list.Add(piece);
        }
      }
      return list.ToArray();
    }

    public override string ToString() {
      Point position = ChessBoard.Translate(this._position.X, this._position.Y);
      return string.Format("{0} castle ({1}, {2})", this.Team, position.X, position.Y);
    }
  }
}
