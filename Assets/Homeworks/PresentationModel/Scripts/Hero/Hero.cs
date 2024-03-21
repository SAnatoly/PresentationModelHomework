using UnityEngine;

namespace Lessons.Architecture.PM
{
    /* public class HeroPopupView: MonoBehaviour
     {
         public Sprite icon;
         public string descriprion;
         public CharacterStat[] stats;
         public Button levelUPButton;
         public Button closeButton;

         private ICharacterStatsPresenter statsPresenter;

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




     }*/

    [CreateAssetMenu(fileName = "Hero", menuName = "Create hero")]
    public class Hero: ScriptableObject
    {
        [SerializeField]
        public string Name;
        [SerializeField, TextArea]
        public string Descripton;
        [SerializeField]
        public Sprite icon;
        [SerializeField]
        public CharacterStat[] stats;

        public int level;
        public int xp;
        public int needXp;
    }
}

