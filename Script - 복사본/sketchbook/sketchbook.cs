using System.Collections;
using System.Collections.Generic;
using UnityEngine;


 //2차원 게임 오브젝트 표현



public class sketchbook : MonoBehaviour
{
    //1. 캘린더 클릭 2. 캘린더 펼치는 애니메이션 3. 캘린더 페이지
    //4. 책갈피 클릭 5. 책 넘기는 애니메이션     6. 페이지 펼침
    // + 방향키 -> 다음챕터                  <- 이전챕터
    //  UI : text 이용


    private int chapternow; // 챕터 확인
    private bool issketch = false;

    public GameObject animation0;
    public GameObject animation1;
    public GameObject calendarpage;
    public GameObject diarypage;
    public GameObject characterpage;
    public GameObject nextanimation;
    public GameObject now;

    public npcManager npcmanager;


    public GameObject sketchbookbtn;

    void Update(){
        if(issketch){
            if(Input.GetKeyUp(KeyCode.Escape)){
                now.SetActive(false);
                animation1.SetActive(true);
                issketch = false;
                StartCoroutine(DelayedFunction());
            }        
            else if(now == diarypage){
                npcmanager.sketch_diary();
             }

            else if (now == characterpage){
                npcmanager.sketch_character();
            }


        }

    }

  
    //diary text : chapter 넘기는 button #chapter 관련내용
    //character image, text : 일상대화 횟수 확인 -> 횟수에 따라 text 활성화 비활성화
    //#일상 관련 내용     chapter 넘기는 버튼으로 활성화
    //calendar  일상-챕터관련

    bool next;
    bool open;
    string type1;

    public void Is_sketch(){
        issketch = true;
        opening();
    }

    private void opening(){
        open = true;
        animation0.SetActive(true);
        now = calendarpage;
        StartCoroutine(DelayedFunction());

    }
    public void next1(string type){
        type1 = type;
        nextpage();
    }

    private void nextpage(){
        next = true;
        now.SetActive(false);
        nextanimation.SetActive(true);
        StartCoroutine(DelayedFunction());
    }



    IEnumerator DelayedFunction()
    {
        yield return new WaitForSeconds(1);
        
        if(open)    {animation0.SetActive(false);    calendarpage.SetActive(true);}
        else if(next){
            
            nextanimation.SetActive(false);
            if(type1 == "diary"){
                diarypage.SetActive(true);
                now = diarypage;
            }
            else if(type1 == "character") {
                characterpage.SetActive(true);
                now = characterpage;
            }}
        else if(!issketch){            
            animation1.SetActive(false);
            sketchbookbtn.SetActive(true);

        }
        open = false;
        next = false;
    }




}
