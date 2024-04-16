
    using System.Collections.Generic;

    public interface IStatsPresenter
    {
        string name { get; }
        int value { get; }
        
        HashSet<CharacterStat> stats { get; }
    }
