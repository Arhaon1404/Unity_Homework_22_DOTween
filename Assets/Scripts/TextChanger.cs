using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]

public class TextChanger : ActingObject
{
    private Text _text;

    private void Start()
    {
        _text = GetComponent<Text>();

        Color newColor = Color.green;

        string newText = "SimpleText";
        string newAddText = "VerySimpleText ";

        DOTween.Sequence()
            .Append(_text.DOColor(newColor, _duration))
            .AppendInterval(0.5f)
            .Append(_text.DOText(newText, _duration))
            .AppendInterval(0.5f)
            .Append(_text.DOText(newAddText, _duration))
            .SetLoops(_loopCount, _loopType);
    }
}
