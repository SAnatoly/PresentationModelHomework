using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Lessons.Architecture.PM
{

    /*public interface IHeroPresenter
    {
        UserInfo userInfo { get; }
        CharacterStat[] stats { get; }
        void LevelUP();
    }*/

    public interface ICharacterStatsPresenter
    {
        string name { get; }
        int statValue { get; }
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
}

