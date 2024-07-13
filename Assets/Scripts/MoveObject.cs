using DG.Tweening;
using UnityEngine;

public class MoveObject : ActingObject
{
    [SerializeField] private Target _target;
    
    private void Start()
    {
        transform.DOMove(_target.transform.position, _duration).SetLoops(_loopCount, _loopType);
    }
}
