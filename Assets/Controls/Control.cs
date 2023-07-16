using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Control : ScrollRect
{
    protected float mRadius = 0f;//ҡ�˰뾶��Χ

    protected override void Start()
    {
        base.Start();//ԭStart����

        //����ҡ�˷�Χ�뾶
        mRadius=(transform as RectTransform).sizeDelta.x*0.45f;
    }

    public override void OnDrag(PointerEventData eventData)
    {
        base.OnDrag(eventData);//ԭOnDrag����

        //ҡ��λ��
        var contentPosition = this.content.anchoredPosition;

        //���Ʒ�Χ
        if(contentPosition.magnitude>mRadius ) 
        {
            contentPosition=contentPosition.normalized*mRadius;
            SetContentAnchoredPosition(contentPosition);
        }
    }
}