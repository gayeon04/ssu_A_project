using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class State : MonoBehaviour
{
    [SerializeField] int hints = 0;
    public List<string> Chapter;
    public Oneday oneday = Oneday.Morning;// 현재 상태
    public string chapter;
    public List<int> cpt_hints;
    public List<int> cpt_chance;
    
    int day = 0;
    [SerializeField]int a = 0;

    public TalkManager talkmanager;
    public BGManager bgmanager;
    public npcManager npcmanager;

    public GameObject[] chapSprite;
    public GameObject nightroomSprite;

    public backgroundChange map;
    public GameObject morningi;
    public GameObject afternooni;
    public GameObject nighti;

    public TMP_Text chapter_0;
    public TMP_Text day_0;
    
 
    public enum Oneday
    {
        Morning, // 지도x, 스케치북x
        Afternoon, // 지도
        Night // 저녁 - 스케치북
    }

    void Start()
    {
        Chapter = new List<string>();
        Chapter.Add("Tutorial"); // 모두 소개
        Chapter.Add("HELLOWORLD_1"); // 친해짐
        Chapter.Add("SERIALMURDER_2"); // 연쇄살인
        Chapter.Add("DANGER_3"); // 몇 개월 뒤 축제, 정치질
        Chapter.Add("ABOUTFRIEND_4"); // 인간관계
        Chapter.Add("GAME_5");// 떠보는 것
        Chapter.Add("ABOUTDEATH_6"); // 과거 살인
        Chapter.Add("TOMANDJERRY_7"); // 라이벌
        Chapter.Add("BESTFRIEND_8"); //엔딩

        chapter = Chapter[0];


        cpt_hints = new List<int>();
        cpt_hints.Add(5);
        cpt_hints.Add(4);
        cpt_hints.Add(4);
        cpt_hints.Add(4);
        cpt_hints.Add(4);
        cpt_hints.Add(4);
        cpt_hints.Add(4);

        cpt_chance = new List<int>();
        cpt_chance.Add(7);
        cpt_chance.Add(9);
        cpt_chance.Add(7);
        cpt_chance.Add(7);
        cpt_chance.Add(7);
        cpt_chance.Add(7);
        cpt_chance.Add(7);        

    
    }

    public void event_on()
    {
        hints += 1;
    } //챕터 진행도

    public int index_(){
        int index = Chapter.IndexOf(chapter);
        Debug.Log(index);
        return index;
    }

    public void threetime()
    {
        a += 1;
        int days = day/3;


        switch(a%3){
        
        case 0: a += 1;
                goto case 1;
                
        case 1: map.study();
                afternooni.SetActive(true); 
                morningi.SetActive(false);
                nighti.SetActive(false);
                oneday = Oneday.Afternoon; 
                break;  //아침 대화 후(sun image 대기)
        case 2: map.Ghome(); 
                nighti.SetActive(true);
                morningi.SetActive(false);
                afternooni.SetActive(false); 
                oneday = Oneday.Night; 
                break; // 점심 대화 후(study 오브젝트 대기)

        }
        
    }

    private void chapters(){
        hints = 0;
        chapter = Chapter[(index_()+1)];
        chapter_0.text = index_().ToString();
        talkmanager.GenerateData(index_());
        bgmanager.GenerateData(index_());
        // map.Map(chapSprite[Chapter.IndexOf(chapter)]);
        npcmanager.chapters(index_());
        
    }



    public void days(){
        morningi.SetActive(true);
        nighti.SetActive(false);
        afternooni.SetActive(false);
        day += 1;
        day_0.text = day.ToString();
    }

    public void nightSprite(){
        nightroomSprite.SetActive(false);
        if(hints >= cpt_hints[index_()] || a >= cpt_chance[index_()]){
            chapSprite[Chapter.IndexOf(chapter)].SetActive(true);
            chapters();
            days();
            }
        else{
            days();
            chapSprite[12].SetActive(true);
        }
    }
}