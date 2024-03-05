using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class npcManager : MonoBehaviour
{
    [SerializeField]private int[] npcDate;//npc 일상대화 횟수 : character
    [SerializeField]private int[] npcData; // npc chapter : daily
    [SerializeField]private int[] chapterData;

    //npc id 0: 유 1: 진 2: 음 3: 단발 4: 선
    //chapter 100 - 1000
    //date 10000 - 20000

    public GameObject[] npc;
    public ChptHint[] cpdata;
    public sketchbook_text stext;

    int chapter = 0;

    int id;

    // public void SetSketchbook(sketchbook sketchbookInstance){
    //     sketch= sketchbookInstance; //인스턴스화
    // }

    void Start(){
        npcData = new int[] {0,0,0,0,0};
        npcDate = new int[] {0,0,0,0,0};
        chapterData = new int[]{0,0,0,0,0}; //엔딩 선택지, chapter관련 대화 수행정도
    
        for(int i = 0; i<5; i++){
            cpdata[i] = npc[i].GetComponent<ChptHint>();
        }

    }

    //talkid 분배
    public void call(int id){
        if(id >= 10000){
            this.id = (id/1000)-11; //캐릭터 구분
            date();
        }

    }
    
    public void calldata(int id, int dat){

        if(id >= 100){

            this.id = (id/100)-1; //캐릭터 구분
            data(dat);
            // Debug.Log("id");
            // Debug.Log(id);
            // Debug.Log(dat);
        }        
    }

    private void date(){
        //캐릭터 특성
        npcDate[id] += 1; // 캐릭터 진행도 +1
    }

    private void data(int chpt){
        //챕터 진행도
        Debug.Log("data");
        npcData[id] = chpt; // 캐릭터 진행도 +1
        chapterData[id] += 1;

    }

    public void sketch_diary(){ 
        //data
        for(int i =0; i<5; i++){
            stext.DiaryGetp(i,npcData[i]); // 캐릭터별 진행도 전달->gameobject활성화
                }


    }
    public void sketch_character(){ 

        for(int i =0; i<5; i++){
            stext.CharacterGetp(i,npcDate[i]);// 캐릭터별 진행도 전달->gameobject활성화
                }


    }

    public void chapters(int index)
    {
        chapter += 1;

        for (int i = 0; i < 5; i++)
        {
            while (npcData[i] < index)
            {
                npcData[i] += 1;
            }
        }

        for (int i = 0; i < 5; i++)
        {
            if((cpdata[i].talkid % ((i+1)*100))/10 != chapter){
                while((cpdata[i].talkid % ((i+1)*100))/10 != chapter){
                    cpdata[i].talkid += 1;
                    
                }
                cpdata[i].chpt += 1;
            }
        }
    }

}