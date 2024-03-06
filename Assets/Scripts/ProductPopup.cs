using System.Collections;
using System.Collections.Generic;
using System.IO;
using Code;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ProductPopup : MonoBehaviour
{

  [SerializeField]
  private TMP_Text _title;

  [SerializeField]
  private TextMeshProUGUI _description;

  [SerializeField]
  private Image _icon;

  [SerializeField] private BuyButton _buyButton;
  
  
  private IProductPresenter _productPresenter;
  

  public void Show(IPresenter presenter)
  {
    if (presenter is not IProductPresenter productPresenter)
    {
      throw new InvalidDataException($"Invalid data type: {nameof(productPresenter)} must be {nameof(IProductPresenter)}");
    }

    _productPresenter = productPresenter;
    _title.text = _productPresenter.Title;
    _description.text = _productPresenter.Description;
    _icon.sprite = _productPresenter.Icon;

    _buyButton.SetPrice(productPresenter.MoneyPrice);
    _buyButton.AddListener(BuyProduct);
    UpdateButton();
    gameObject.SetActive(true);
  }


  public void UpdateButton()
  {
    var buttonState = _productPresenter.CanBuy ? BuyButtonState.Available : BuyButtonState.Locked;
    _buyButton.SetState(buttonState);
  }

  public void BuyProduct()
  {
    _productPresenter.Buy();
    UpdateButton();
  }

  private void Hide()
  {
    gameObject.SetActive(false);
    _buyButton.RemoveListener(BuyProduct);
    
  }
}
