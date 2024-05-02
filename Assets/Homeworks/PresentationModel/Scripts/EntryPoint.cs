using UnityEngine;
using UnityEngine.UI;

    public class EntryPoint : MonoBehaviour
    {
        [SerializeField]
        private Button _openHeroPrefab;

        [SerializeField]
        private Transform _buttonsParent;

        [SerializeField]
        private HeroPopup _heropoup;
        [SerializeField] private HeroData _heroData; 
        public void Start()
        {
                var level = new PlayerLevel(100, 1);
                var userInfo = new UserInfo(_heroData.name, _heroData.description, _heroData.icon);
                var levelPresenter = new LevelPresenterTemp(level);
                var userInfoPresenter = new UserInfoPresenter(userInfo);
                var playerPresenter = new PlayerPresenter(levelPresenter, userInfoPresenter);

                var button = Instantiate(_openHeroPrefab, _buttonsParent);
                
                button.onClick.AddListener(() => OpenPopup(playerPresenter));
        }

        private void OpenPopup(IPlayerPresenter playerPresenter)
        {
            _heropoup.Show(playerPresenter);
        }
    }
