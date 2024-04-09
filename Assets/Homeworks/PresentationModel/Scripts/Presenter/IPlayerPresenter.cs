

    public interface  IPlayerPresenter
    {
        ILevelPresenterTemp LevelPresenter { get; }
        IUserInfoPresenter InfoPresenter { get; }
    }

    public class PlayerPresenter : IPlayerPresenter
    {
        public PlayerPresenter(ILevelPresenterTemp levelPresenter, IUserInfoPresenter userInfoPresenter)
        {
            LevelPresenter = levelPresenter;
            InfoPresenter = userInfoPresenter;
        }

        public ILevelPresenterTemp LevelPresenter { get; }
        public IUserInfoPresenter InfoPresenter { get; }
    }
