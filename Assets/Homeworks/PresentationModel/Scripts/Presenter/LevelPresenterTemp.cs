using System;
using UnityEngine;


public class LevelPresenterTemp : ILevelPresenterTemp
    {
        private readonly PlayerLevel _playerLevel;
        public event Action onDataChanged; 
        
        public string LevelText { get; private set; }
        public float Progress { get; private set; }
        public string ProgressText { get; private set; }

        public LevelPresenterTemp(PlayerLevel playerLevel)
        {
            _playerLevel = playerLevel;
            Refresh();
            _playerLevel.OnLevelUp += PlayerLevelUp;
            _playerLevel.OnExperienceChanged += OnExperienceChanged;
        }

        private void PlayerLevelUp()
        {
            Refresh();
        }

        private void OnExperienceChanged(int obj)
        {
            Refresh();
        }
        
        private void Refresh()
        {
            LevelText = $"LVL: {_playerLevel.CurrentLevel}";
            ProgressText = $"XP: {_playerLevel.CurrentExperience}/{_playerLevel.RequiredExperience}";
            Progress = _playerLevel.CurrentExperience / (float)_playerLevel.RequiredExperience;
            Debug.Log("Refresh");
            onDataChanged?.Invoke();
        }
    }
