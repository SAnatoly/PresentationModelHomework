namespace Lessons.Architecture.PM
{
    public class LevelPresenter : ILevelPresenter
    {
        public int level => playerLevel.CurrentLevel;
        public int xp => playerLevel.CurrentLevel;
        public PlayerLevel playerLevel;

        public LevelPresenter(PlayerLevel _playerLevel)
        {
            playerLevel = _playerLevel;
        }

        public void LevelUP()
        {
            playerLevel.LevelUp();
        }
    }
}