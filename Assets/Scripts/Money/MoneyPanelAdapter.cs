using System;
using Zenject;

namespace LessonHelper
{
    public sealed class MoneyPanelAdapter: IInitializable, IDisposable
    {
        private readonly CurrencyView _currencyView;
        private readonly MoneyStorage _moneyStorage;

        public MoneyPanelAdapter(CurrencyView currencyView, MoneyStorage moneyStorage)
        {
            _currencyView = currencyView;
            _moneyStorage = moneyStorage;
        }


        public void Initialize()
        {
            _moneyStorage.OnMoneyChange += UpdateMoney;
        }
        
        public void UpdateMoney(long money)
        {
            _currencyView.UpdateCurrency(money); 
        }   
        
        
        public void Dispose()
        {
            _moneyStorage.OnMoneyChange -= UpdateMoney;
        }

       

       
    }
    
}