using System;



    public interface ILevelPresenterTemp
    {
        public event Action dataChanged;
        
        public string LevelText { get; }
        public float Progress { get; }
        public string ProgressText { get; }
    }
