using System;
using TMPro;
using UnityEngine;
using DG.Tweening;
using Zenject;

public class CurrencyView : MonoBehaviour
{
    [SerializeField] private TMP_Text text;
    [SerializeField] private ScaleTweenParams startScale;
    [SerializeField] private ScaleTweenParams endScale;
    [SerializeField] private float rillRate;
    private Sequence sequence;
    private long currntMoney;
    
    

    public void UpdateCurrency(long _moneyCurrent)
    {
        AnimationText(currntMoney, _moneyCurrent);
        currntMoney = _moneyCurrent;
    }

    private void AnimationText(long moneyCurrent, long moneyNext)
    {
        sequence?.Kill();
        sequence = DOTween.Sequence();

        sequence.Append(text.transform.DOScale(startScale.scale, startScale.rillRate));
        var tweenerCore = DOTween.To(() => moneyCurrent, Setter, moneyNext, rillRate);
        sequence.Append(tweenerCore);
        sequence.Append(text.transform.DOScale(endScale.scale, endScale.rillRate));
    }

    public void Setter(long pnewValue)
    {
        text.text = pnewValue.ToString();
    }
    
    public void OnDestroy()
    {
        sequence?.Kill();
        sequence = null;
    }
}