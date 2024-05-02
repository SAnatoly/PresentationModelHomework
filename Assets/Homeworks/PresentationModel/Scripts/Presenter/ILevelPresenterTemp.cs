using System;



    public interface ILevelPresenterTemp
    {
        public event Action onDataChanged;
        
        public string LevelText { get; }
        public float Progress { get; }
        public string ProgressText { get; }
    }
