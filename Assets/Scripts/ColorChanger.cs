using DG.Tweening;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private int _loopCount;
    [SerializeField] private LoopType _loopType;

    private SpriteRenderer _spriteRenderer;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();

        Color newColor = Color.black;

        _spriteRenderer.DOColor(newColor, _duration).SetLoops(_loopCount, _loopType);
    }
}
