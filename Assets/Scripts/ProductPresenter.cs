using UnityEngine;

namespace DefaultNamespace
{
    public class ProductPresenter: IProductPresenter
    {
        public string Title { get; }
        public string Description { get; }
        public Sprite Icon { get; }
        public string MoneyPrice { get; }
        public bool CanBuy { get; }

        public ProductPresenter(ProductInfo productInfo, ProductBuyer productBuyer, MoneyStorage moneyStorage)
        {
            Title = productInfo.Title;
            Description = productInfo.Description;
            Icon = productInfo.Icon;
            MoneyPrice = productInfo.MoneyPrice.ToString();
            CanBuy = productBuyer.CanBuy(productInfo, moneyStorage);
        }
        
        public void Buy()
        {
            
        }
    }
}