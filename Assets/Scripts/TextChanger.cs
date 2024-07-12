using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]

public class TextChanger : MonoBehaviour
{
    [SerializeField] private float _duration;

    private Text _text;

    void Start()
    {
        _text = GetComponent<Text>();

        Color newColor = Color.green;

        string newText = "SimpleText";
        string newAddText = " VerySimpleText";

        DOTween.Sequence()
            .Append(_text.DOColor(newColor, _duration))
            .AppendInterval(0.5f)
            .Append(_text.DOText(newText, _duration))
            .AppendInterval(0.5f)
            .Append(_text.DOText(newAddText, _duration));
    }
}
