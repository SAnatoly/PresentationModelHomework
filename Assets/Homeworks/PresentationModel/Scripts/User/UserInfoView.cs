using Lessons.Architecture.PM;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace Homeworks.PresentationModel.User
{
    public class UserInfoView: MonoBehaviour
    {
        public TMP_Text name;
        public TMP_Text description;
        public Image icon;

        public void Show(UserInfoPresenter presenter)
        {
            name.text = presenter.name;
            description.text = presenter.description;
            icon.sprite = presenter.icon;
        }

        public void Hide()
        {
            
        }
    }
}