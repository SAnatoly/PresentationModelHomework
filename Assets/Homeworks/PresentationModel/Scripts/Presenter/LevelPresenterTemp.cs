using System;
using UnityEngine;


public class LevelPresenterTemp : ILevelPresenterTemp
    {
        private readonly PlayerLevel level;
        public event Action dataChanged; 
        
        public string LevelText { get; private set; }
        public float Progress { get; private set; }
        public string ProgressText { get; private set; }

        public LevelPresenterTemp(PlayerLevel level)
        {
            this.level = level;
            Debug.Log(this.level.CurrentLevel);
            Refresh();
            this.level.OnLevelUp += OnLevelUp;
            this.level.OnExperienceChanged += OnExperienceChanged;
        }

        private void OnLevelUp()
        {
            Refresh();
        }

        private void OnExperienceChanged(int obj)
        {
            Refresh();
        }
        
        private void Refresh()
        {
            LevelText = $"LVL: {level.CurrentLevel}";
            ProgressText = $"XP: {level.CurrentExperience}/{level.RequiredExperience}";
            Progress = level.CurrentExperience / (float)level.RequiredExperience;
            Debug.Log("Refresh");
            dataChanged?.Invoke();
        }
    }
