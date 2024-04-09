using System;
using UnityEngine;
using TMPro;
using UnityEngine.UI;



    public class HeroPopupf: MonoBehaviour
    {
        [SerializeField] private TMP_Text name;
        [SerializeField] private TMP_Text discription;
        [SerializeField] private TMP_Text xp;
        [SerializeField] private TMP_Text level;
        [SerializeField] private Image icon;
        [SerializeField] private CharacterStat[] stats;

        private IHeroPresenter heroPresenter;

        public void Start()
        {
            gameObject.SetActive(false);
        }

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
            level.text = $"Level: {heroPresenter.level}";
            xp.text = $"{heroPresenter.xp} / {heroPresenter.RequiredExperience}";
        }

        public void Hide()
        {
            gameObject.SetActive(false);
        }
    }


