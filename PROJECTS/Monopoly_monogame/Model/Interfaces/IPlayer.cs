namespace Monopoly.Model.Interfaces
{
    public interface IPlayer
    {
        int CurrentPosition { get; }
        int Index { get; }
        bool IsInJail { get; }
        int Money { get; }
        void SetPosition(int newPosition);
    }
}
