using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChoiceManager : MonoBehaviour
{
    Dictionary<int, string[]> choices;

    public bool clicked = false;
    private int id;
    private int add_;

    //a번선택 :1, b번 선택:5 portraitData,bgData 꼬임 방지

    [SerializeField] private GameObject a_choice;
    [SerializeField] private GameObject b_choice;
    
    public TextMeshProUGUI a_choicesText;
    public TextMeshProUGUI b_choicesText;


    void Awake(){
        choices = new Dictionary<int, string[]>();
        GenerateData();
    }

    private void GenerateData(){
        //받은 objData.talkid 기준
        choices.Add(100, new string[]{"", "안녕?"});
        choices.Add(200, new string[]{"","안녕?"});
        choices.Add(300, new string[]{"","안녕. 혹시 사복 등교야?"});
        choices.Add(400, new string[]{"","안녕. 미적분 수행평가야?"});
        choices.Add(500, new string[]{"","선생님?"});
        choices.Add(10000, new string[]{"방해하지 말자.", "말을 건다."});
        choices.Add(10010, new string[]{"+1","+5"});


        choices.Add(110, new string[]{"아냐.","여기 봐바."});
        choices.Add(210, new string[]{"어차피 모를걸?","(말해준다)"});
        choices.Add(310, new string[]{"배드민턴은 잘 못한다.","같이 해준다."});
        choices.Add(410, new string[]{"","왜?"});
        choices.Add(510, new string[]{"싫은데요.","네."});

        choices.Add(120, new string[]{"","재밌어?"});
        choices.Add(220, new string[]{"지금 말고 나중에 물어봐 줘.","뭐?"});
        choices.Add(320, new string[]{"귀찮아.","귀찮은데 해줄게."});
        choices.Add(420, new string[]{"","핸드폰 안 낸거야?"});
        choices.Add(520, new string[]{"도망친다.","인사한다."});

        choices.Add(130, new string[]{"그런가?","왜?"});
        choices.Add(230, new string[]{"잘 풀어봐.","뭐가?"});
        choices.Add(330, new string[]{"왜?","그런 것 같기도 해."});
        choices.Add(430, new string[]{"","누가 문제인거야."});

        choices.Add(140, new string[]{"글쎄.","진솔이가 많이 도와줬지."});
        choices.Add(240, new string[]{"잘 된 거 맞아?","그러게."});
        choices.Add(340, new string[]{"그런가?","확실히 져준 느낌이 있긴 하지."});
        choices.Add(440, new string[]{"","왜?"});
        choices.Add(530, new string[]{"좀 애매해요.","네."});

        choices.Add(150, new string[]{"그러게.","지윤이는 그래도 공부 하던데."});
        choices.Add(250, new string[]{"열심히 해.","무슨 생각 하는데?"});
        choices.Add(350, new string[]{"음...","그렇다더라."});
        choices.Add(450, new string[]{"누구 말하는 거야?","갑자기 왜?"});
        choices.Add(540, new string[]{"그렇긴 한데 말처럼 안되는 거죠.","음..."});

        
        choices.Add(160, new string[]{"갑자기?","죽으면 끝이겠지. 그냥 무."});
        choices.Add(260, new string[]{"아니.","뭔데?"});
        choices.Add(360, new string[]{"어.","그래?"});
        choices.Add(460, new string[]{"그닥 궁금하지 않은데.","진짜 충격적이야?"});
        choices.Add(550, new string[]{"다음에 해요.","상관없어요."});

        choices.Add(170, new string[]{"아마?","없는데?"});
        choices.Add(270, new string[]{"아니.","아니. 재밌어?"});
        choices.Add(370, new string[]{"엥?","뭔 소리야."});
        choices.Add(470, new string[]{"잘 알긴 해?","약간?"});

        choices.Add(180, new string[]{"다음에..","데려간다."});
        choices.Add(280, new string[]{"다음에..","데려간다."});

        choices.Add(11000, new string[]{"","뭐해?"});
        choices.Add(11010, new string[]{"안풀고 잤어.","그냥 할 만큼 했어."});
        choices.Add(11020, new string[]{"귀찮은데.","왜?"});
        choices.Add(12000, new string[]{"안녕.","뭐해?"});
        choices.Add(11030,new string[]{"어떻게든 되겠지.","입시 미술을 하고 있었어?"});
        choices.Add(12010, new string[]{"","아니."});

        choices.Add(11040, new string[]{"","어떤 책 읽어?"});
        choices.Add(12020, new string[]{"다음에 가자.","어떤 영화 보는데?"});
        choices.Add(12030, new string[]{"","무슨 생각해?"});
        choices.Add(12040, new string[]{"","영화 어땠어?"});
        choices.Add(12050, new string[]{"나 집이 좀 멀어서.","그래."});
   
        choices.Add(13000, new string[]{"","뭐해?"});
        choices.Add(13010, new string[]{"","무슨 일 있어? 피곤해?"});
        choices.Add(13020, new string[]{"안녕.","네가 재능 있다고?"});
        choices.Add(13030, new string[]{"뭐해?","배드민턴 칠래?"});
        choices.Add(13040, new string[]{"","또 명상중이야?"});
        choices.Add(13050, new string[]{"좀 일찍 자.","피곤해?"});
    
        choices.Add(14000, new string[]{"","안녕?"});
        choices.Add(14010, new string[]{"좀 자둬.","잠 많이 못 잤어?"});
        choices.Add(14020, new string[]{"...","진솔아."});
        choices.Add(14030, new string[]{"딱히 없어.","왜?"});
        choices.Add(14040, new string[]{"...","왜?"});

        choices.Add(15000, new string[]{"넵.","어느정도는요?"});


    }

    public void choice_select(int talkid){

        clicked = false;
        Debug.Log(clicked);
        id = talkid;


        a_choicesText.text = choices[id][0];
        b_choicesText.text = choices[id][1];    
        

        a_choice.SetActive(true);
        b_choice.SetActive(true);
        // StartCoroutine(DelayedFunction());

    
    }

    //버튼 클릭전까지 대기 onclick() 함수처리
    public void A_isSelected(){
        
        a_choice.SetActive(false);
        b_choice.SetActive(false);
        id += 1;
        add_ = 1;
        Debug.Log("A 선택");
        Debug.Log(id);
        clicked = true;

    }

    public void B_isSelected(){
        
        a_choice.SetActive(false);
        b_choice.SetActive(false);
        id += 5;
        add_ = 5;
        Debug.Log("B 선택");
        Debug.Log(id);
        clicked = true;

    }

//        StartCoroutine(DelayedFunction());

    public int get_choices(){
        Debug.Log("get_choices");
        Debug.Log(clicked);
        return add_;
    }


    // IEnumerator DelayedFunction()
    // {
    //     Debug.Log("Before delay");
    //     Debug.Log(id);

    //     yield return new WaitForSeconds(1); // 2초 동안 대기
        
    //     a_choice.SetActive(true);
    //     b_choice.SetActive(true);

    // }



}
