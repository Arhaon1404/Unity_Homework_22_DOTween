using DG.Tweening;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private int _loopCount;
    [SerializeField] private LoopType _loopType;

    private void Start()
    {
        Vector3 target = new Vector3(0,360,0);

        transform.DOLocalRotate(target, _duration,RotateMode.FastBeyond360).SetLoops(_loopCount, _loopType);
    }
}
