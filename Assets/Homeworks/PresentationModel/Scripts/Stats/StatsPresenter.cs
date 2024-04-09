
    public class StatsPresenter: IStatsPresenter
    {
        public string name { get; }
        public int value { get; }
        public CharacterStat characterStat;

        public StatsPresenter(CharacterStat _characterStat)
        {
            characterStat = _characterStat;
        }

        public void ChangeValue()
        {
            characterStat.ChangeValue(value);
        }
    }
