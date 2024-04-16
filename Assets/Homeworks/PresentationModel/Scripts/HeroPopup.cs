
using UnityEngine;
using UnityEngine.UI;


public class HeroPopup: MonoBehaviour
    {
        [SerializeField] private LevelView levelViewPrefab;
        [SerializeField] private UserInfoView userInfoViewPrefab;


        public LevelView levelView;
        public UserInfoView userInfoView;

        [SerializeField] private Button closeButton;

        [SerializeField] private GameObject popup;
        public void Start()
        {
            popup.SetActive(false);
        }

        public void Show(IPlayerPresenter presenter)
        {
            levelView.Refresh(presenter.LevelPresenter);
            levelView.Render(presenter.LevelPresenter);
            userInfoView.Show(presenter.InfoPresenter);
            closeButton.onClick.AddListener(Hide);
            popup.SetActive(true);
        }

        public void Hide()
        {
           popup.SetActive(false);
           closeButton.onClick.RemoveListener(Hide);
        }
    }


