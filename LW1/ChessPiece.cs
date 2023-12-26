using System.Drawing;

namespace LW1 {

  public enum ChessTeam {
    WHITE,
    BLACK,
  }

  public abstract class ChessPiece {

    protected Point _position;

    private ChessTeam _team;
    public ChessTeam Team {
      get => this._team;
    }

    public virtual void OnMove(Point point) {
      this._position = point;
    }

    public abstract ChessPiece[] Intersect(ChessBoard board);

    public ChessPiece(ChessTeam team) {
      this._team = team;
    }



  }
}
