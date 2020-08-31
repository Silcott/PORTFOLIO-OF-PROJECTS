namespace Monopoly.View.Renderers
{
    public abstract class AbstractRenderer
    {
        public abstract void DrawBoard();
        public abstract void ShowTileOwner(int playerIndex, int currentPlayerPosition);
        public abstract void MovePlayer(int index, int currentPosition, int newPosition);
    }
}
