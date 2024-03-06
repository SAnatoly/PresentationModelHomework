using UnityEngine;

public interface IPresenter
{
    
}

public interface IProductPresenter : IPresenter
{
    string Title { get;}
    string Description { get;}
    Sprite Icon { get; }
    string MoneyPrice { get;}
    bool CanBuy { get;}
    void Buy();
}