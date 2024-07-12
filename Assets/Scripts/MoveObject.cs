using DG.Tweening;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    [SerializeField] private Target _target;
    [SerializeField] private float _duration;
    [SerializeField] private int _loopCount;
    [SerializeField] private LoopType _loopType;

    private void Start()
    {
        transform.DOMove(_target.transform.position, _duration).SetLoops(_loopCount, _loopType);
    }
}
