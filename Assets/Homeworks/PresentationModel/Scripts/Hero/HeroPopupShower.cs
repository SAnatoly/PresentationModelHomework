using UnityEngine;
using UnityEngine.Serialization;


public class HeroPopupShowerf: MonoBehaviour
    {
        public HeroPopup _heroPopup;
        public IHeroPresenter _heroPresenter;
     
        public void Show(Hero _hero)
        {
            _heroPresenter = new HeroPresenter(_hero);
        }

        public void Hide()
        {
            _heroPopup.Hide();
        }
    }


