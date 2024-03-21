namespace Lessons.Architecture.PM.Stats
{
    public interface IStatsPresenter
    {
        string name { get; }
        int value { get; }
        void ChangeValue();
    }
}