
using UnityEngine;
using UnityEngine.Serialization;
using Zenject;

namespace LessonHelper
{
    public class LessonHelper: MonoBehaviour
    {
        [SerializeField] private long current;
        [SerializeField] private MoneyStorage moneyStorage;
        [SerializeField] private GemStorage gemStorage;

        [Inject]
        private void Construct(MoneyStorage _moneyStorage, GemStorage _gemStorage)
        {
            moneyStorage = _moneyStorage;
            gemStorage = _gemStorage;
        }
        
        public void AddMoney()
        {
            moneyStorage.AddMoney(current);
        }

        public void SpendMoney()
        {
           moneyStorage.SpendMoney(current);
        }
        
        public void AddGem()
        {
            gemStorage.AddGem(current);
        }

        public void SpendGem()
        {
           gemStorage.SpendGem(current);
        }
    }
}