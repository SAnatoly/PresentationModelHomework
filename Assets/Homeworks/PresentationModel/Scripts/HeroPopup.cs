
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;


public class HeroPopup: MonoBehaviour
    {
        [SerializeField] private LevelView _levelViewPrefab;
        [SerializeField] private UserInfoView _userInfoViewPrefab;


        public LevelView _levelView;
        public UserInfoView _userInfoView;

        [SerializeField] private Button _closeButton;

        [SerializeField] private GameObject _popup;
        
        public void Start()
        {
            _popup.SetActive(false);
        }

        public void Show(IPlayerPresenter presenter)
        {
            _levelView.Refresh(presenter.LevelPresenter);
            _levelView.Render(presenter.LevelPresenter);
            _userInfoView.Show(presenter.InfoPresenter);
            _closeButton.onClick.AddListener(Hide);
            _popup.SetActive(true);
        }

        public void Hide()
        {
           _popup.SetActive(false);
           _closeButton.onClick.RemoveListener(Hide);
        }
    }


