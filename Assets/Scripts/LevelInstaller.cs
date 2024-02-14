using DefaultNamespace;
using Zenject;

namespace LessonHelper
{
    public class LevelInstaller: MonoInstaller
    {
        public override void InstallBindings()
        {
            var view = FindObjectOfType<CurrencyPresenter>();
            MoneyBind(view.MoneyView);
            GemBind(view.GemView);
        }

        private void MoneyBind(CurrencyView moneyView)
        {
            Container.Bind<MoneyStorage>().AsSingle().WithArguments(10L).NonLazy();
            Container.BindInterfacesTo<MoneyPanelAdapter>().AsSingle().WithArguments(moneyView).NonLazy();
        }
        
        private void GemBind(CurrencyView gemView)
        {
            Container.Bind<GemStorage>().AsSingle().WithArguments(100L).NonLazy();
            Container.BindInterfacesTo<GemPanelAdapter>().AsSingle().WithArguments(gemView).NonLazy();
        }
    }
}