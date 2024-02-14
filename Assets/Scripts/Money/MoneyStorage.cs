    using System;

    public sealed class MoneyStorage
    {
        public event Action<long> OnMoneyChange;
        
        public long money { get; private set; }

        public MoneyStorage(long _money)
        {
            money = _money;
        }

        public void AddMoney(long _money)
        {
            money += _money;
            OnMoneyChange?.Invoke(money);
        }

        public void SpendMoney(long _money)
        {
            money -= _money;
            OnMoneyChange?.Invoke(money);
        }
    }
