using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

    public class EntryPoint : MonoBehaviour
    {
        [SerializeField]
        private Button openHeroPrefab;

        [SerializeField]
        private Transform buttonsParent;

        [SerializeField]
        private HeroPopup heropoup;
        [SerializeField] private HeroData heroData; 
        public void Start()
        {
            
               // var[] stat = new CharacterStat();
                var level = new PlayerLevel(100, 1);
                var userInfo = new UserInfo(heroData.name, heroData.description, heroData.icon);
                
                Debug.Log(userInfo.Name);

               
               
               // var infoPresenter = new StatsPresenter(stat);
                var levelPresenter = new LevelPresenterTemp(level);
                var userInfoPresenter = new UserInfoPresenter(userInfo);
                var playerPresenter = new PlayerPresenter(levelPresenter, userInfoPresenter);

                var button = Instantiate(openHeroPrefab, buttonsParent);
            
                button.onClick.AddListener(() => OpenPopup(playerPresenter));
                
            
            
        }

        private void OpenPopup(IPlayerPresenter playerPresenter)
        {
            Debug.Log(playerPresenter.InfoPresenter.name);
            heropoup.Show(playerPresenter);
        }
    }
