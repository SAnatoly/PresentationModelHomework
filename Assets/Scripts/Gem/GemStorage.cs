using System;
namespace LessonHelper
{
    public sealed class GemStorage
    {
        public event Action<long> OnGemChange;
        
        public long gem { get; private set; }

        public GemStorage(long _gem)
        {
            gem = _gem;
        }

        public void AddGem(long _gem)
        {
            gem += _gem;
            OnGemChange?.Invoke(gem);
        }

        public void SpendGem(long _gem)
        {
            gem -= _gem;
            OnGemChange?.Invoke(gem);
        }
    }
}