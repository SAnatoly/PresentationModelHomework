using UnityEngine;

namespace Lessons.Architecture.PM
{
    public class HeroPopupShower: MonoBehaviour
    {
        public HeroPopup heroPopup;
        public IHeroPresenter heroPresenter;
        public Hero hero;
        public void Start()
        {
            Show(hero);
        }

        public void Show(Hero _hero)
        {
            heroPresenter = new HeroPresenter(_hero);
            heroPopup.Show(heroPresenter);
        }
    }
}

