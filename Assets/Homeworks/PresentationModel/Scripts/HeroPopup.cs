using System;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

namespace Lessons.Architecture.PM
{
    public class HeroPopup: MonoBehaviour
    {
        [SerializeField] private TMP_Text name;
        [SerializeField] private TMP_Text discription;
        [SerializeField] private Image icon;
        [SerializeField] private CharacterStat[] stats;

        private IHeroPresenter heroPresenter;

        public void Show(object args)
        {
            if(args is not IHeroPresenter presenter)
            {
                throw new Exception("Expected Hero Presenter");
            }

            gameObject.SetActive(true);
            heroPresenter = presenter;

            name.text = heroPresenter.Name;
            discription.text = heroPresenter.description;
            icon.sprite = heroPresenter.icon;
            stats = heroPresenter.characterStats;
        }
    }
}

