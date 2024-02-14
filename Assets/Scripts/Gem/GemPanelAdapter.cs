using System;
using Zenject;

namespace LessonHelper
{
    public class GemPanelAdapter: IInitializable, IDisposable
    {
        private readonly CurrencyView _currencyView;
        private readonly GemStorage _gemStorage;

        public GemPanelAdapter(CurrencyView currencyView, GemStorage gemStorage)
        {
            _currencyView = currencyView;
            _gemStorage = gemStorage;
        }


        public void Initialize()
        {
            _gemStorage.OnGemChange += UpdateGem;
        }
        
        public void UpdateGem(long gem)
        {
            _currencyView.UpdateCurrency(gem); 
        }   
        
        
        public void Dispose()
        {
            _gemStorage.OnGemChange -= UpdateGem;
        }
    }
}