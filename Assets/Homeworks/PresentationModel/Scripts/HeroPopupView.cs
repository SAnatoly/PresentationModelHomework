using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Lessons.Architecture.PM
{

    public interface IHeroPresenter
    {
        UserInfo userInfo { get; }
        CharacterStat[] stats { get; }
        void LevelUP();
    }

    public interface ICharacterStatsPresenter
    {
        string name { get; }
        int valuse { get; }
        void ChangeStatValue();
    }

    public interface ILevelPresenter
    {
        int level { get; }
    }

    

    public class CharacterStatsView : MonoBehaviour
    {
        public CharacterStat[] stats;
        
        public void Initialisation(CharacterStat[] _stats)
        {
            stats = _stats;
        }

        public void ChangeStatValue(ICharacterStatsPresenter statsPresenter)
        {
            statsPresenter.ChangeStatValue();
        }
    }
    
    public class HeroPopupView: MonoBehaviour
    {
        public Sprite icon;
        public string descriprion;
        public CharacterStat[] stats;
        public Button levelUPButton;
        public Button closeButton;

        public void Initialized(CharacterInfo _info, CharacterStat[] _stats, PlayerLevel _level, UserInfo _uInfo)
        {
            icon = _uInfo.Icon;
            descriprion = _uInfo.Description;
            stats = _info.GetStats();
        }

        public void LevelUP(IHeroPresenter presenter, ICharacterStatsPresenter _characterStatsPresenter, CharacterStatsView _statsView)
        {
            presenter.LevelUP();
            RefreshStats(_statsView, _characterStatsPresenter);
        }

      

        public void RefreshStats(CharacterStatsView _statsView, ICharacterStatsPresenter _statsPresenter)
        {
            _statsView.ChangeStatValue(_statsPresenter);
        }
    }
}