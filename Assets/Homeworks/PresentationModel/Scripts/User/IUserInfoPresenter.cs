using UnityEngine;

namespace Homeworks.PresentationModel.User
{
    public interface IUserInfoPresenter
    {
        public string name { get; }
        public string description { get; }
        public Sprite icon { get; }
    }
}