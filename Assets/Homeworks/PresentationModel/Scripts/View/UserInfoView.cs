
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


    public class UserInfoView: MonoBehaviour
    {
        public TMP_Text name;
        public TMP_Text description;
        public Image icon;

        public void Show(IUserInfoPresenter presenter)
        {
            name.text = presenter.name;
            description.text = presenter.description;
            icon.sprite = presenter.icon;
            Debug.Log("INFO");
        }

        public void Hide()
        {
            
        }
    }
