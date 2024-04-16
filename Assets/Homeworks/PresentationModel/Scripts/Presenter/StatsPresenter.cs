
    using System.Collections.Generic;

    public class StatsPresenter: IStatsPresenter
    {
        public string name { get; }
        public int value { get; }
        public HashSet<CharacterStat> stats { get; }


        public StatsPresenter(StatsHero[] statsHeroe)
        {
            

            for (int i = 0; i < statsHeroe.Length; i++)
            {
               
            }
        }

    }
