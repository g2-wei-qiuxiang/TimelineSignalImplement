using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Animations : MonoBehaviour
{
    [SerializeField] 
    private RectTransform startText = null;
    
    [SerializeField] 
    private RectTransform endText = null;

    public void PlayStartAnimation()
    {
        var sequence = DOTween.Sequence();
        sequence.Append(startText.DOScale(1.2f, 0.5f));
        sequence.Append(startText.DOScale(0, 0.5f).SetDelay(0.5f));
        sequence.Play();
    }

    public void PlayEndAnimation()
    {
        var sequence = DOTween.Sequence();
        sequence.Append(endText.DOScale(1.2f, 0.5f));
        sequence.Append(endText.DOScale(0, 0.5f).SetDelay(0.5f));
        sequence.Play();
    }
}
