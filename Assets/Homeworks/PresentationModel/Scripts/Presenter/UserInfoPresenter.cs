
using UnityEngine;


    public class UserInfoPresenter: IUserInfoPresenter
    {
        public string name { get; }
        public string description { get; }
        public Sprite icon { get; }

        public UserInfoPresenter(UserInfo _userInfo)
        {
            name = _userInfo.Name;
            description = _userInfo.Description;
            icon = _userInfo.Icon;
        }
    }
