using DG.Tweening;
using UnityEngine;

public class ScaleObject : ActingObject
{
    [SerializeField] private int _scaleMultipler;

    private void Start()
    {
        Vector3 newScale = Vector3.one * _scaleMultipler;

        transform.DOScale(newScale, _duration).SetLoops(_loopCount, _loopType);
    }
}
