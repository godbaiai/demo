using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Control : ScrollRect
{
    protected float mRadius = 0f;//Ò¡¸Ë°ë¾¶·¶Î§

    protected override void Start()
    {
        base.Start();//Ô­Start·½·¨

        //¼ÆËãÒ¡¸Ë·¶Î§°ë¾¶
        mRadius=(transform as RectTransform).sizeDelta.x*0.45f;
    }

    public override void OnDrag(PointerEventData eventData)
    {
        base.OnDrag(eventData);//Ô­OnDrag·½·¨

        //Ò¡¸ËÎ»ÖÃ
        var contentPosition = this.content.anchoredPosition;

        //ÏÞÖÆ·¶Î§
        if(contentPosition.magnitude>mRadius ) 
        {
            contentPosition=contentPosition.normalized*mRadius;
            SetContentAnchoredPosition(contentPosition);
        }
    }
}