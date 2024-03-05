using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;



public class Textbar : MonoBehaviour
{

    private SpriteRenderer spriteRenderer;
    [SerializeField] private SpriteRenderer spritenpc;
    [SerializeField] private SpriteRenderer spritebg;
    [SerializeField] private SpriteRenderer textbar_;
    [SerializeField] private TypeEffect txt;
    [SerializeField] private TMP_Text npcname;
    [SerializeField] private GameObject mapbutton;


    public npcManager npcmanager;
    public TalkManager talkmanager;
    public State state;
    public ChoiceManager choiceManager;
    public BGManager bgManager;

    int threetimes = 0;
    static bool isTalking = false;
    private int count = 0;
    private GameObject scanObject;
    private ObjData objData;
    private ChptHint chptData;


    void Awake(){
        talkmanager = FindObjectOfType<TalkManager>();
        // npcname = GetComponent<TMP_Text>(); ?? 이거 넣으면 에러>>????
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void Action(GameObject scanObj){
        if(isTalking){
            return;
        }
        else{
            isTalking = true;
            scanObject = scanObj;
            
            ONOFF(true);
            objData = scanObject.GetComponent<ObjData>();
            chptData = scanObject.GetComponent<ChptHint>();
            spriteRenderer = scanObject.GetComponent<SpriteRenderer>();


            if(chptData != null && chptData.chpt == state.index_())    
            {   
                objData = chptData; //챕터 우선
                npcmanager.calldata(objData.talkid, chptData.chpt);
                // chptData.chpt += 1; 
                if (!objData.isnpc) 
                {   chptData.chpt += 10;  // object -> 한 챕터의 힌트로만 
                    state.event_on();
                }
            }
            else{
                Debug.Log("chptData null");
            }
            Talk(objData);
        }
    }


    private void ONOFF(bool _flag){
        spritenpc.gameObject.SetActive(_flag);
        textbar_.gameObject.SetActive(_flag);
        txt.gameObject.SetActive(_flag);
        spritebg.gameObject.SetActive(_flag);

        
    }

    void Talk(ObjData objData){
        if(objData == null){
            Debug.Log("objData null");
        }
        //여기?
        string talkData = talkmanager.GetTalk(count, objData.talkid);
        
        //objdata 100 :chapter  10000 :daily
        //objdata 1000 : chapter  20000: daily 


        if(objData.objname != "0")  { //오브젝트인 경우
            string a = objData.objname;
            npcname.text = a;
        }
        else{
            npcname.text = "";
        }

        if(talkData == null){
            count  = 0;
            ONOFF(false);



            if(objData.talkid % 10 == 0) { // 선택지
                
                if(!objData.isnpc){ // 오브젝트 -> +10(x)
                    isTalking = false; //sprite rederer update : null
                    mapset();
                    return;

                 }
                else{ //npc

                    choiceManager.choice_select(objData.talkid);

                    StartCoroutine(DelayedFunction());
                    return;
                }
                }

            else if(objData.talkid % 10 != 0){ // 선택지 talkdata 후, object는 +10이 없음
                isTalking = false;  
                if(objData.talkid % 10 == 5){
                    if(objData.talkid >= 100 && objData.talkid < 1000){
                        chptData.chpt += 1; 
                        state.event_on();}
                }  
                while(objData.talkid % 10 != 0){
                    objData.talkid += 1;
                    
                }

                npcmanager.call(objData.talkid);
                mapset();
                timeline();
                return;
            }

            else{
                isTalking = false;
                mapset();
                return;
            }
        }
        
        
        string[] talkParts = talkData.Split(':'); // 0 : talkdata, 1: portrait, 2: bg
        //npc, chapter
        if(objData.talkid >= 100 && objData.talkid < 1000){
            txt.SetMsg(talkParts[0]);
            spritenpc.sprite = talkmanager.GetPortrait(objData.talkid,int.Parse(talkParts[1]));
            spritenpc.color = new Color(1,1,1,1);
            spritebg.sprite = bgManager.GetBG(objData.talkid, int.Parse(talkParts[2]));
            spritebg.color = new Color(1,1,1,1);
            
        }

        //npc, daily
        else if (objData.talkid >= 10000 && objData.talkid < 20000){
            txt.SetMsg(talkParts[0]);
            spritenpc.sprite = talkmanager.GetPortrait(objData.talkid,int.Parse(talkParts[1]));
            spritenpc.color = new Color(1,1,1,1);
            spritebg.sprite = bgManager.GetBG(objData.talkid, int.Parse(talkParts[2]));
            spritebg.color = new Color(1,1,1,1);

        }

        //object, chapter
        else if(objData.talkid >= 1000 && objData.talkid < 10000){

            txt.SetMsg(talkData);
            spritenpc.color = new Color(1,1,1,0);

        }

        //object, daily
        else if(objData.talkid >= 20000){

            txt.SetMsg(talkData);
            spritenpc.color = new Color(1,1,1,0);
        }
        count++;

    }
    void Update()
    {

        //spacebar 누를 때마다 대사가 진행되도록. 
        if (isTalking) //활성화가 되었을 때만 대사가 진행되도록
        {
            mapbutton.SetActive(false);     
            if (Input.GetKeyDown(KeyCode.Space)) {
                //대화의 끝을 알아야함.
                if(txt.effectend)
                    Talk(objData);
                    } //다음 대사가 진행됨

            if (Input.GetKeyDown(KeyCode.Z)) {
                //대화의 끝을 알아야함.
                if(txt.effectend)
                    skip();
                    } //다음 대사가 진행됨

            //대사가 끝남
            
            }
        
        else{

            if(scanObject != null && objData.isnpc)  spriteRenderer.color = new Color(1,1,1,1);
        }

    }


    void skip(){
        count  = 0;
        ONOFF(false);    
        if(objData.talkid % 10 != 0 && objData.isnpc == true){ // 선택지 talkdata 후, object는 +10이 없음
            isTalking = false;  
            if(objData.talkid % 10 == 5){
                if(objData.talkid >= 100 && objData.talkid < 1000){
                    chptData.chpt += 1; 
                    state.event_on();}
            }  
            while(objData.talkid % 10 != 0){
                objData.talkid += 1;
                
            }

            npcmanager.call(objData.talkid);
            mapset();
            timeline();
            return;
        }

    }
    

    IEnumerator DelayedFunction()
    {

        while(!choiceManager.clicked){
            yield return null;
        }

        objData.talkid += choiceManager.get_choices();
                    

        if(objData.talkid % 10 == 5){

            isTalking = true;
            ONOFF(true);
            Talk(objData);
        }
        else{
            objData.talkid -= 1;
            isTalking = false; //sprite rederer update : null
            mapset();
            
        }


    }
    //night button_onclick
    public void timeline(){
        threetimes += 1;
        state.threetime();


    }    
    private void mapset(){
        if(threetimes % 3 != 2){
            mapbutton.SetActive(true);
    }
    }
}
