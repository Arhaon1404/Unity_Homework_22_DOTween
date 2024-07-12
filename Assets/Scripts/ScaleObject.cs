using DG.Tweening;
using UnityEngine;

public class ScaleObject : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private int _loopCount;
    [SerializeField] private LoopType _loopType;

    private void Start()
    {
        Vector3 newScale = new Vector3(2f,2f,2f);

        transform.DOScale(newScale, _duration).SetLoops(_loopCount, _loopType);
    }
}
