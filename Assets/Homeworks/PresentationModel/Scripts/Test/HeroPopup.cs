
using UnityEngine;


    public class HeroPopup: MonoBehaviour
    {
        [SerializeField] private LevelView levelViewPrefab;
        [SerializeField] private UserInfoView userInfoViewPrefab;


        public LevelView levelView;
        public UserInfoView userInfoView;
        
        public void Start()
        {
            gameObject.SetActive(false);
        }

        public void Show(IPlayerPresenter presenter)
        {
            //var levelView = Instantiate(levelViewPrefab, transform);
            //var userInfoView = Instantiate(userInfoViewPrefab, transform);
            
            levelView.Render(presenter.LevelPresenter);
            levelView.Refresh();
            userInfoView.Show(presenter.InfoPresenter);
            //gameObject.SetActive(true);
        }

        public void Hide()
        {
           // gameObject.SetActive(false);
        }
    }


