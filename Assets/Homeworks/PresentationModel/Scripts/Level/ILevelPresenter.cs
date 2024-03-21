namespace Lessons.Architecture.PM
{
    public interface ILevelPresenter
    {
        int level { get; }
        int xp { get; }
        void LevelUP();
    }
}