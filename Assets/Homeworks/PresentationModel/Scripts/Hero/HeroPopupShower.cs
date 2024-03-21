using UnityEngine;

namespace Lessons.Architecture.PM
{
    public class HeroPopupShower: MonoBehaviour
    {
        public HeroPopup heroPopup;
        public IHeroPresenter heroPresenter;
     
        public void Show(Hero _hero)
        {
            heroPresenter = new HeroPresenter(_hero);
            heroPopup.Show(heroPresenter);
        }

        public void Hide()
        {
            heroPopup.Hide();
        }
    }
}

