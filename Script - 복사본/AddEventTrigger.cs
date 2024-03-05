using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class AddEventTrigger : MonoBehaviour
{   
    private int clickcnt;
    private int entercnt;
    private int exitcnt;
    private Color color;

    public GameObject obj;

    private void is_click(BaseEventData eventData){
        clickcnt++;
        Debug.Log($"isPointerclick {clickcnt} times");
    }
    
    private void is_enter(BaseEventData eventData){
        entercnt++;
        Debug.Log($"isPointerenter {entercnt} times");
        color.a = 0.5f;
        obj.GetComponent<Image>().color = color;
    }


    private void is_exit(BaseEventData eventData){
        exitcnt++;
        Debug.Log($"isPointerexit {exitcnt} times");
        color.a = 1.0f;
        obj.GetComponent<Image>().color = color;
    }



    // Start is called before the first frame update
    void Start()
    {
        
        color = obj.GetComponent<Image>().color;

        clickcnt = 0;
        entercnt = 0;
        exitcnt = 0;

        EventTrigger evTrig = gameObject.AddComponent<EventTrigger>();
      
        
        EventTrigger.Entry clickEvent = new EventTrigger.Entry()
        {
            eventID = EventTriggerType.PointerClick
        };
        
        EventTrigger.Entry EnterEvent = new EventTrigger.Entry(){
            eventID = EventTriggerType.PointerEnter
        };

        EventTrigger.Entry ExitEvent = new EventTrigger.Entry(){
            eventID = EventTriggerType.PointerExit      };

        

        clickEvent.callback.AddListener(is_click);//is_click 호출
        evTrig.triggers.Add(clickEvent); //eventtrigger 컴포넌트에 항목추가

        EnterEvent.callback.AddListener(is_enter);
        evTrig.triggers.Add(EnterEvent); 

        ExitEvent.callback.AddListener(is_exit);
        evTrig.triggers.Add(ExitEvent); 
    
    }


}
