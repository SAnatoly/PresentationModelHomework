using UnityEngine;


    public class HeroPopupShowerf: MonoBehaviour
    {
        public HeroPopup heroPopup;
        public IHeroPresenter heroPresenter;
     
        public void Show(Hero _hero)
        {
            heroPresenter = new HeroPresenter(_hero);
            //heroPopup.Show(heroPresenter);
        }

        public void Hide()
        {
            heroPopup.Hide();
        }
    }


