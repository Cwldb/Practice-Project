using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;


public class TitleBtnAnim : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private TMP_Text _text;

    private void Awake()
    {
        _text = GetComponent<TMP_Text>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        _text.transform.DOLocalRotate(new Vector3(0, 0, 10), 0.2f);
        _text.transform.DOScale(new Vector3(1.1f, 1.1f, 1.1f),0.2f);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _text.transform.DOLocalRotate(Vector3.zero, 0.2f);
        _text.transform.DOScale(Vector3.one, 0.2f);
    }
}
