using UnityEngine;

namespace DefaultNamespace
{
    public class CurrencyPresenter: MonoBehaviour
    {
        [SerializeField] private CurrencyView _moneyView;
        [SerializeField] private CurrencyView _gemView;

        public CurrencyView GemView => _gemView;
        public CurrencyView MoneyView => _moneyView;
    }
}