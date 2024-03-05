using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TalkManager : MonoBehaviour
{
    Dictionary<int, string[]> talkData;
    Dictionary<int, Sprite> portraitData;
    
    public Sprite[] portraitArr;


    //선택지 = 아이디 + 1 -> 아이디 + 1

    void Awake()
    {
        talkData = new Dictionary<int, string[]>();
        portraitData = new Dictionary<int, Sprite>();

        GenerateData(0);
    }



    public void GenerateData(int chapter) //portraitData 겹침 주의
    {

        //튜토리얼 : 소개 - mbti, 생일, 전공 및 현재 직무, 액세서리에 대한 칭찬, 키, 상대방 칭찬
        //음식 : 좋아하는 음식, 못먹는 음식, 싫어하는 음식, 잘하는 메뉴, 나만의 요리법, 매운음식 잘 먹는지
        //영화 : 좋아하는 영화, 인생영화, 기억에 남는 장면, 좋아하는 장르, 액션 vs 로맨스
        //음악 : 좋아하는 노래, 좋아하는 장르, 요즘 꽂힌 노래
        //관심사 : 최근 취미, 배우고 싶은 것, 앞으로 하고 싶은 일, 어떤 걸 할 때 가장 즐거운지, 쉬는 날엔 무엇을 하는지
        // https://ahaslides.com/ko/blog/conversation-topics/ -> 깊은 대화 주제에 관해


        // 0챕 : 4C 1챕: 6C 2챕: 8C 3챕: 4C 4챕: 3C 5챕: 3C 6챕: 6C 7챕: 0c

        //npc id 1: 유 2: 지 3: 지유 4: 솔 5: 선생님
        //0. 튜토리얼
        
        if(chapter == 0){

            //튜토리얼

            talkData.Add(100, new string[]{"같은 반이었던 것 같은데 친해져볼까?:0:0", "나무 밑을 보고 있다.:0:0"});
            talkData.Add(105, new string[]{"...:1:0","안녕.:1:0", "아, 그냥 모래 보고 있었어.:1:0","누가 뭘 써놔서.:1:0","며칠 동안 계속 쓰고있어...:1:0","이번엔 그려놨네.:1:0","(그렇게 잘 그리지는 못한 것 같다.):0:8","그런데...:1:8","특이한 타이밍에 전학 오게 된거네. 곧 시험인데.:1:0","음...그리고 조금 도움이 될 만한 건:1:0","우리 담임쌤은\n 반 애들을 방치하는 편이니까...:1:0","체육시간 전 쉬는시간에\n 체육복으로 갈아입을 필요는 없어.:1:0","단순하게 체육복 입고 등교해도돼.\n 아침 등교 선도에는 걸리겠지만,:1:0","음... 그리고... 전 학교가 어땠는지는 모르겠지만\n 그냥 다니다 보면 알아.:1:0","또 무슨 일 있어?:1:0","귀찮아하지만 앞으로 도움을 많이 받을 수 있을 것 같다.:0:0","겉보기와는 다르게 친절하다.:0:0"});
        
            talkData.Add(200, new string[]{"같은 반인데 친해져볼까?:2:0"});
            talkData.Add(205, new string[]{"안녕?:2:0","은우야?:2:0","머리 스타일 어울린다.:2:0","책 좋아해?:2:0","...:2:0","그렇구나. 그래도 여기는 볼만한 책이 꽤 많은 편이야.:2:0","웹툰 단행본이나 웹소설 단행본도 많거든.\n 앉을 자리도 소파고 해서 그래서 점심시간에 사람이 생각보다\n 많아.:2:0","최근에 읽은 책이 뭐야?:2:9","난 고전소설을 좋아하는 편이긴한데 판타지 소설도 많이 읽어.:2:9","기본적으로 책은 많이 안 읽는 편이다.:0:0","이 부근에는 추리 소설이나 미스테리, 공포 소설이 많고...:2:9","아마 별로 관심이 없겠지만...하하:2:9"});

            talkData.Add(300, new string[]{"학교에서 사복을 입고있다.:3:0","아침에 정문에서 선도하던데...:3:0","아마 잡혔으면 교복을 빌려주거나 했을텐데.:3:0","어떻게 들어온건지 물어볼까?:3:0"});
            talkData.Add(305, new string[]{"나?:3:0","뭐?:3:0","아...:8:0","당연히 교실 와서 갈아입은거야.:3:0","기분이 상해보인다.:0:0","실수했다... 너무 대놓고 물어본 것 같다...:0:0","왜?:3:0","...:0:0","...:0:0","그럴 수 있지.:3:0","근데 전학 온 날에 체육복 입고 등교한거야?:3:0"});

            talkData.Add(400, new string[]{"수행평가 공지 용지를 보고 있다.:4:0"});
            talkData.Add(405, new string[]{"...:4:0","어:9:0","낯가림이 좀 있다.?:0:0","도망쳤다...:0:0"});
        
            talkData.Add(500, new string[]{"담임쌤이다.:0:0"});
            talkData.Add(505, new string[]{"다른 친구들이랑 얘기 많이 나눠봤어?:5:0","지금 성적에 많이 불리한 것도 있는데:5:0","혹시 정시... 수능 생각 중이니?:5:0","별 생각 없는 거면 오히려 편하긴 해.:5:0","수능 공부중이야?:5:0","...:5:0","음... 상담 전엔 그래도 네 생각을 정리해와.:5:0","진로 고민은 진작에 끝낼때고.:5:0","아, 조심해서 다니고:5:0","요즘 문제 많잖아. 이 근처도 위험하다는 얘기가 많으니까.:5:0","야자 하기도 부담스러워 하는 경우도 있는데.:5:0","난 야자 정도는 하는 걸 추천하지만\n 하지 않는다고 안 막아.:5:0","위험하기도 하고 야자는 그닥.:0:0","안 바쁘신가.:0:0","다음에 상담 시간을 잡아야겠다.:0:0"});
            
            portraitData.Add(100+0, portraitArr[0]);
            portraitData.Add(105+1, portraitArr[1]);
            portraitData.Add(105+0, portraitArr[0]);
            portraitData.Add(200+2, portraitArr[2]);
            portraitData.Add(205+2, portraitArr[2]);
            portraitData.Add(205+0, portraitArr[0]);
            portraitData.Add(300+3, portraitArr[3]);
            portraitData.Add(305+3, portraitArr[3]);  
            portraitData.Add(305+8, portraitArr[8]);
            portraitData.Add(305+0, portraitArr[0]);  
            portraitData.Add(400+4, portraitArr[4]);
            portraitData.Add(405+0, portraitArr[0]);
            portraitData.Add(405+9, portraitArr[9]);
            portraitData.Add(405+4, portraitArr[4]);     
                  
            portraitData.Add(500+0, portraitArr[0]);
            portraitData.Add(505+0, portraitArr[0]);
            portraitData.Add(505+5, portraitArr[5]);  
            
            portraitData.Add(10000+0, portraitArr[0]);
            portraitData.Add(10000+1, portraitArr[1]);
            portraitData.Add(10005+1, portraitArr[1]);
            portraitData.Add(10005+0, portraitArr[0]);



            talkData.Add(20000, new string[]{"정리해야 되는데.","아직 정리해야할 짐이 많다."});
            talkData.Add(20010, new string[]{"언니에게 선물한 그림.","꽤 잘 그렸다."});
            talkData.Add(20020, new string[]{"오늘이 전학 첫 날이다.","약간 설렌다.","휴.."});
            talkData.Add(20030, new string[] {"반 전체가 조용한 분위기다.","3학년이니까.. 이상할 것도 없다."});
            talkData.Add(20040, new string[]{"앞머리 좀 잘라야 겠는데."});


            talkData.Add(20050, new string[]{"'프로파일링 이론.'","'시체의 부패는 대기 중에서 가장 느리며\n 물 속, 흙 속에서 빠르다.'","아마 아닐텐데?"});
            talkData.Add(20060, new string[]{"유독 더러운 책상."});
            talkData.Add(20070, new string[]{"'햄릿','7년의 밤','종의 기원'"});
            talkData.Add(20080, new string[]{"날씨 좋네."});
            talkData.Add(20090, new string[]{"깔끔하게 닦여있다."});
            talkData.Add(20100, new string[]{"[생명과학2 수행평가 안내], [물리2 수행평가 안내],\n [언어와 매체 수행평가 안내]"});  
            talkData.Add(20110, new string[]{"바닥에 낙서가 많다."});
        
            talkData.Add(11000, new string[]{"그냥 멍하니 있는 것 같다.:1:0", "친해져볼까?:0:0"});
            talkData.Add(11005, new string[]{"그냥 휴식중이야.:1:0","귀찮아 보이는데.:0:0","너 되게 낯 안 가리네.:1:0","네가 더 그래.:0:0","사람이 조용한 곳에서 명상을 좀 해야돼.:1:0","머리는 염색해놓고 그러네.:0:0","정신이 산만할수록 본인의 시간이 필요한거야.:1:0"});

            talkData.Add(11010, new string[]{"미적분 수행평가 잘 봤어?:1:0"});
            talkData.Add(11015, new string[]{"그래?:1:0", "잤을 것 같았는데.:1:0","그런데 확실히 이번에는 문제가 다 풀만했어.:1:0","딱히 어렵지도 않고.:1:0","잠깐만.:1:0","지유와 문제풀이를 공유중이다...:0:0","음...:1:0","나쁘지 않은데?:1:0","...:0:0","지유도 잘 못본 모양이다.:0:0"});
            
            talkData.Add(11020, new string[]{"내 고민 좀 들어줄 수 있어?:1:0"});
            talkData.Add(11025, new string[]{"내가 좀 오래 알던 친구가 있는데.:1:0","몇 년 됐지? 한 5년정도?:1:0","걔가 원래는 괜찮은데 자꾸 피곤한 대화를 해.:1:0","너무 부정적이게.:1:0","솔직히...:1:0","손절하고 싶은데.:1:0","사는 동네도 달라서 손절이 어려운 건 아냐.:1:0","하...:1:0","...:1:0","너무 반응 안해주는 거 아냐?:1:0"});
            
            talkData.Add(11030, new string[]{"너는 진로 있어?:1:0", "난 솔직히 없어. 그냥 살다보면 어떻게든 되지 않을까...:1:0","입시 미술을 하고 있긴한데.:1:0","하고 싶은데로 다 할 수 있는 것도 아니고.:1:0"});
            talkData.Add(11035, new string[]{"왜?:1:0", "좀 안어울릴 수도 있어.:1:0","나도 나름 열심히 살고있는 사람이라는 거지.:1:0"});
            talkData.Add(11040, new string[]{"책을 읽고 있다.:0:0","말 걸어볼까?:0:0"});
            talkData.Add(11045, new string[]{"알아?:1:0","드라큘라.:1:0","읽어보라고 추천받아서.:1:0","파우스트, 드라큘라.:1:0","고전소설을 좋아하는 편인가?:0:0","둘 다 이미지와는 다르게 지금까진 평범하게 재미없었어.:1:0","...:1:0","너는 만약에 드라큘라가 될 수 있다하면 될거야?:1:0","인간을 먹어야하긴 하지만 신체능력이 좋아져.:1:0","...:1:0","좋을건 별로 없다는 생각이 드네.\n 드라큘라도 딱히 인간이 되고 싶진 않겠지.:1:0","한번쯤은 이런 존재가 되고 싶은데.:1:0"});            
            talkData.Add(11050, new string[]{"", ""});
            talkData.Add(11055, new string[]{"", ""});

            portraitData.Add(11000+1, portraitArr[1]);
            portraitData.Add(11000+0, portraitArr[0]);
            portraitData.Add(11005+1, portraitArr[1]);
            portraitData.Add(11005+0, portraitArr[0]);
            portraitData.Add(11010+0, portraitArr[0]);
            portraitData.Add(11010+1, portraitArr[1]);
            portraitData.Add(11015+1, portraitArr[1]);
            portraitData.Add(11015+0, portraitArr[0]);
            portraitData.Add(11020+1, portraitArr[1]);
            portraitData.Add(11020+0, portraitArr[0]);
            portraitData.Add(11025+1, portraitArr[1]);
            portraitData.Add(11025+0, portraitArr[0]);
            portraitData.Add(11030+1, portraitArr[1]);
            portraitData.Add(11035+1, portraitArr[1]);
            portraitData.Add(11040+0, portraitArr[0]);
            portraitData.Add(11045+1, portraitArr[1]);
            portraitData.Add(11045+0, portraitArr[0]);
            portraitData.Add(11050+0, portraitArr[0]);
            portraitData.Add(11050+1, portraitArr[1]);
            portraitData.Add(11055+1, portraitArr[1]);
            portraitData.Add(11055+0, portraitArr[0]);            

            talkData.Add(12000, new string[]{"안녕?:2:0","...:3:0"});
            talkData.Add(12005, new string[]{"뭐 안해.:3:0","뭐 할까 생각중이었어.:3:0","배드민턴이나 할까.:3:0","나였으면 공부도 안할때\n 책이라도 읽으면서 자기개발할텐데.:2:0","너무 아무 생각 없는 거 아냐?:2:0","...:3:0","그런데 네가 은우를 어떻게 알아?:7:0","쟤가 처음에 먼저 말 걸었었는데:3:0","왜 사복 입고 등교하냐고 시비 걸렸어.:3:0","뭐?:2:0","당황스럽긴 하겠네.:2:0","...:3:0","사실 이제와서 보면 원래 자주 당황 시키는 편이잖아.:2:0","...:3:0","본인도 체육복 바지 입고 등교하면서 그러네.:2:0","하긴 사복보다 낫긴 하지.:2:0","애초에 왜 체육복 입고 등교하는건데.:3:0"});
            
            talkData.Add(12010, new string[]{"심심하지.:2:0"});
            talkData.Add(12015, new string[]{"에이.:2:0","내가 책 추천해줄까?:2:0","이 책.:2:0","흥미로운 게 많아.:2:0","예를 들어 동기가 뭐였던간에..:7:0","네가 사람을 죽인다고 해 봐.:7:0","네가 사는 동네 근처에서 죽이면 위험하잖아.:2:0","그리고 너무 멀리서 죽이면 네가 상황을 통제할 수가 없게 돼.:2:0","그래서 패턴이 생기게 되는거지.:2:0","너무 멀지도 않고 너무 가깝지도 않은.:2:0","역추적이 되려나? 그건 모르겠지만.:2:0"});




            portraitData.Add(12000+2, portraitArr[0]);
            portraitData.Add(12000+3, portraitArr[3]);
            portraitData.Add(12005+3, portraitArr[3]);
            portraitData.Add(12005+2, portraitArr[2]);
            portraitData.Add(12010+2, portraitArr[2]);
            portraitData.Add(12015+2, portraitArr[2]);
            portraitData.Add(12015+7, portraitArr[7]);

//"완벅한 고요,외딴섬,낮과밤,편히쉬게할 공간도"
            talkData.Add(13000, new string[]{"배드민턴...:3:0","아니다.:3:0"});
            talkData.Add(13005, new string[]{"그냥 얘기중이었어:1:0","은우야 너는 꿈이랄게 있어?:1:0","음...:0:0","딱히 가고 싶은 학과도 없고 해서.:1:0","꿈은 있는데.:3:0","돈 걱정 없이 펑펑 돈 쓰면서 노는...:3:0","그건... 너무 애매하지 않아?:1:0","구체적이야.:3:0","아무도 없는 호텔같은 방에서 룸서비스를 시키며.:3:0","영화도 보고 핸드폰도 하고\n 밤도 새고.:3:0","백수처럼?:1:0","그렇네. 돈 많은 백수.:3:0","그렇게 사는 게 질리면?:1:0","일단 질릴리가 없긴한데.:3:0","질리면 밖에 나가서 놀고 하는거지.:3:0","게으른 편인 것 같다.:0:0"});
            talkData.Add(13010, new string[]{"멍해보인다.:0:0","말을 걸어야할까?:0:0"});
            talkData.Add(13015, new string[]{"아.:8:0","그냥 밤을 거의 샜어.:8:0","2시간 정도 잔 것 같은데.:8:0","잠을 못잔건가?:0:0","게임 좀 하다가... 어차피 수업 듣는 것도 없고.:8:0","그런데 커피를 마셨더니 잠이 안오네.:8:0","하...:8:0","밤 새는 거 안 힘든가...:0:0","...:8:0","몰라.:8:0"});
            talkData.Add(13020, new string[]{"지윤이와 지유가 대화중이다.:0:0","음...:2:0"});
            talkData.Add(13025, new string[]{"어.:3:0","안녕.:2:0","얘 공부 하나도 안하는 것 같지.:2:0","...:2:0","근데 내가 봤을 땐 꼭꼭 숨어서 하는 것 같아.:2:0","아니면 이런 성적이 나올 수가 없어.:2:0","서로 성적 공유하나?:0:0","...:2:0","우리끼리는 공유해.:3:0","공유 안하는 사람도 있긴한데\n 솔직히 나는 욕심도 없고 하니.:3:0","사실 그렇게 궁금하진 않아.:2:0","우리 둘 차이가 생각보다 커서.:2:0","사실 물어보고 하는 건 그냥 궁금해서도 있지만.:2:0","등수따라서 성적 나오니까...:2:0","그런데...:2:0","사실 궁금하지도 않았는데.:2:0","이번 수행평가를 지유가 너무 잘 봐버렸어.:2:0","얘는 망했어.:3:0","그래서 나한테만 어려웠던건지... 지유가 공부를 한건지...:2:0","난 원래 평균 이상은 가.:3:0","음...:2:0","확실히... 그렇긴 해.:7:0"});            
            talkData.Add(13030, new string[]{"혼자 있다.:0:0","말을 걸어볼까?:0:0"});
            talkData.Add(13035, new string[]{"아니... 나 지금 명상중.:3:0","아니 망상중..?:3:0","...:3:0","망상중이다.:0:0","방해하지 않아야겠다.:0:0"});
            talkData.Add(13040, new string[]{"혼자 있다.:0:0","명상중은 아닌 것 같다.:0:0"});
            talkData.Add(13045, new string[]{"아니..?:3:0","무슨 명상이야.:3:0","...:3:0","아... 저번엔 그냥 귀찮아서 그랬어.:3:0","사람이 망상 좀 할 수 있지.:3:0","할 것도 배드민턴밖에 없는데.:3:0","네가 배드민턴을 너무 못해.:3:0","하다보면 늘긴 하는데...:3:0","할래?:3:0","...:0:0","됐다.:0:0"});
            talkData.Add(13050, new string[]{"또 밤을 샌 것 같다.:0:0"});
            talkData.Add(13055, new string[]{"집에서 할 일이 그렇게 많나?:0:0","...:3:0","집 가면 진짜 내 세상이지.:3:0","부모님이 맞벌이라 늦게 들어오셔.:3:0","집 가면 게임도 좀 해주고:3:0","침대에서 노래나 들으면서 멍때리는 거지.:3:0","그게 진짜 힐링이야.:3:0"});            

            portraitData.Add(13000+3, portraitArr[3]);
            portraitData.Add(13005+0, portraitArr[0]);
            portraitData.Add(13005+1, portraitArr[1]);
            portraitData.Add(13005+3, portraitArr[3]);
            portraitData.Add(13010+3, portraitArr[3]);
            portraitData.Add(13010+0, portraitArr[0]);
            portraitData.Add(13015+8, portraitArr[8]);
            portraitData.Add(13015+0, portraitArr[0]);
            portraitData.Add(13020+2, portraitArr[2]);
            portraitData.Add(13020+0, portraitArr[0]);
            portraitData.Add(13025+0, portraitArr[0]);
            portraitData.Add(13025+2, portraitArr[2]);
            portraitData.Add(13025+3, portraitArr[3]);
            portraitData.Add(13025+7, portraitArr[7]);
            portraitData.Add(13030+0, portraitArr[0]);
            portraitData.Add(13035+0, portraitArr[0]);
            portraitData.Add(13035+3, portraitArr[3]);
            portraitData.Add(13040+0, portraitArr[0]);
            portraitData.Add(13045+3, portraitArr[3]);            
            portraitData.Add(13050+0, portraitArr[0]);
            portraitData.Add(13055+0, portraitArr[0]);
            portraitData.Add(13055+3, portraitArr[3]);      

            talkData.Add(14000, new string[]{"아직 그렇게 친하진 않은데.:0:0","말을 걸어볼까?:0:0"});
            talkData.Add(14005, new string[]{"남자애라 어떻게 말을 걸어야할 지 모르겠다.:0:0","...:4:0","지유랑 친하지?:4:0","...:4:0","나도 지유랑 오래...:4:0","한 초등학교 4학년 때 알아서 오래 알고 지냈어.:4:0","같은 반...:4:0","그런데 지유는 생각보다... ... .. ...:4:0","...:0:0","조금 친해진 것 같다.:0:0"});

            talkData.Add(14010, new string[]{"피곤해보인다.:0:0"});
            talkData.Add(14015, new string[]{"어제 게임 하느라.:4:0","저녁 먹고 바로 들어갔으니까 거의 10시간 했나?:4:0","아... 졸려.:4:0","아. 지유랑 같이 했는데.:4:0","10시간을 같이 했다는 건가?:0:0","...:9:0","그건 아니고 중간에 불러서 같이 했는데 둘만 끝까지\n 살아남았어.:4:0","근데 걔 진짜 못해...:4:0","그냥 같이 해줬어.:4:0"});
            
            talkData.Add(14020, new string[]{"졸고 있다.:0:0"});
            talkData.Add(14025, new string[]{"대답이 없다.:0:0","...:0:0","피곤한 듯 하다.:0:0","곧 수업인데 깨울까?:0:0","...:0:0","뭐해?:1:0","야.:1:0","진솔을 툭툭 치지만 계속 자고 있다.:0:0","...:1:0","에휴.:1:0"});
            
            talkData.Add(14030, new string[]{"넌 미래계획 있어?:4:0"});
            talkData.Add(14035, new string[]{"그냥.:4:0","지윤이가 설교하고 갔거든.:4:0","미래 계획이 뭐든간에 사실 실제로 될 확률은...:4:0","너무 낮아. 상황도 다르고.:4:0","괜히 힘빼는 거야.:4:0"});

            talkData.Add(14040, new string[]{"영화 보러 갈래?:4:0"});
            talkData.Add(14045, new string[]{"아...:4:0","그냥.:4:0","보고 싶은 거 있어?:4:0","둘이서 보러 가자는 건가?:0:0","...지윤이랑.:4:0","지윤이랑 영화 볼래?:4:0","사실 같이 봐주기로 했는데... 예전에.:4:0","최근에 돈을 너무 많이 써서 없어.:4:0","현질로 질러버려서.:4:0","그냥... 영화는 넘기려고.:4:0","진짜 장난이 아니라 돈이 마이너스인 수준이야.:4:0"});  

            portraitData.Add(14000+0, portraitArr[0]);
            portraitData.Add(14005+0, portraitArr[0]);
            portraitData.Add(14005+1, portraitArr[1]);
            portraitData.Add(14005+4, portraitArr[4]);   
            portraitData.Add(14010+0, portraitArr[0]);
            portraitData.Add(14015+0, portraitArr[0]);
            portraitData.Add(14015+4, portraitArr[4]);
            portraitData.Add(14015+9, portraitArr[9]);
            portraitData.Add(14020+0, portraitArr[0]);
            portraitData.Add(14025+0, portraitArr[0]);
            portraitData.Add(14025+1, portraitArr[1]);
            portraitData.Add(14030+4, portraitArr[4]);
            portraitData.Add(14035+4, portraitArr[4]);
            portraitData.Add(14040+4, portraitArr[4]);
            portraitData.Add(14045+4, portraitArr[4]);
            portraitData.Add(14045+0, portraitArr[0]);

            talkData.Add(15000, new string[]{"공부는 좀 하고 있어?:5:0"});
            talkData.Add(15005, new string[]{"집이 여기서 좀 멀지?:5:0","왕복 2시간이면...:5:0","많이 힘들긴 하네.:5:0","현실적으로.:5:0"});
            talkData.Add(15010, new string[]{});
            talkData.Add(15015, new string[]{});            
            talkData.Add(15020, new string[]{});
            talkData.Add(15025, new string[]{});
            talkData.Add(15030, new string[]{});
            talkData.Add(15035, new string[]{});
            talkData.Add(15040, new string[]{});
            talkData.Add(15045, new string[]{});

            portraitData.Add(15000+5, portraitArr[5]);
            portraitData.Add(15005+5, portraitArr[5]);
        }

        else if(chapter ==1){

            // 친구들 소개

            //315, 배드민턴 - bg
            //415, 수행평가 공지
            //515, 1 대 1상담
            talkData.Add(110, new string[]{"뭐해?:1:0","잠깐 얘기할까?:0:0"});
            talkData.Add(115, new string[]{"..?:1:0","왜? 뭐 묻었어?:1:0","아 앞머리 자르게?:1:0","내가 그쪽으론 전문가긴 한데. 머리 잘라줄까?:1:0","아님 됐어.:1:0","머리스타일이란건 애초에 조화가 중요해.:1:0","그 길이가 그래서 그냥 더 나은 것 같기도 해.:1:0","...:2:0","어? 둘이 친해?:2:0","그러고 보니 둘이 은근히 성격이 잘 맞을 것\n 같기도 하고.:2:0","이거 앞머리 어때?:1:0","계속 만지작거린다.:0:0"});
            talkData.Add(210, new string[]{"은우야. 넌 그럼 어디서 이사 온 거야?:2:0","내가 아는 학교인가?:2:0"});
            talkData.Add(215, new string[]{"뭐? 정말?:2:0","그래서 이사 온건가?:2:0","...:2:0","그럴리가 없지...하하:2:0","생각보다 그렇게 위험하지 않지?:2:0","위험하긴 한데...:0:0","사실 난 위험하단 생각보단 좀 궁금해.:2:0","귀찮아질 것 같다.:0:0","싸이코패스라는 게 흥미로운 존재기도 하잖아?:2:0","그냥 정신병이지만.:7:0",});
            talkData.Add(310, new string[]{"하...:3:0","할 것도 없는데 배드민턴이나 할래?:3:0"});
            talkData.Add(315, new string[]{"우리 반이랑 너희 반이랑 체육쌤이 같았나?:3:0","아니겠다.:3:0","체육시간 솔직히 너무 지긋지긋해.\n 하는 것도 없고 말이지.:3:0","도파민이 부족해.:3:0","근데 배드민턴 너무 못하는 거 아니야?:3:0","...그만 하자.:3:0","아. 유정아.:3:0","같이 배드민턴 할래?:3:0","셋이서?:3:0","버림받았다...:0:0"});
            talkData.Add(410, new string[]{"...아닐걸?:3:0","내일... ... 맞아.:4:0"});
            talkData.Add(415, new string[]{"수행평가 일정 말이야.:3:0","얘가 원래 칠판에 다 써두거든.:3:0","누가 시키는 건 아닌데. 그냥.:3:0","그런데 저번에 내가 실수해서 \n 다들 공지를 놓쳤어.:4:0","의도가 있지 않았나 한거지.:3:0","확실히 의도가 보이긴 하는데...:0:0","...:3:0","네 말대로 확실히 놓치는 게 잘못한거긴 하지.:3:0","잘못이라기보단 바보인거지.:4:0"});
            talkData.Add(510, new string[]{"오늘 상담하려던 애가 일이 있어서 못하게 됐는데.:5:0","지금 할래?:5:0"});
            talkData.Add(515, new string[]{"...:5:0","일단 딱히 지망하는 학과도 없고.:5:0","딱히 가고싶은 대학도 없는거네.:5:0","사실 상담 전에 네가 가고 싶은 대학 6개를 적어왔어야 하는데.:5:0","시간이 없으니 못했지.:5:0","뭐든간에 우선순위가 중요한데. 가고 싶은 학과가 있어?:5:0"});

            //대화 끼어들기, 빠지기

            portraitData.Add(110+1, portraitArr[1]);
            portraitData.Add(110+0, portraitArr[0]);
            portraitData.Add(115+1, portraitArr[1]);
            portraitData.Add(115+0, portraitArr[0]);
            portraitData.Add(115+2, portraitArr[2]);
            portraitData.Add(210+2, portraitArr[2]);
            portraitData.Add(215+2, portraitArr[2]);
            portraitData.Add(215+0, portraitArr[0]);
            portraitData.Add(215+7, portraitArr[7]);
            portraitData[313] = portraitArr[3];
            portraitData.Add(310+0, portraitArr[0]);
            portraitData.Add(315+3, portraitArr[3]);
            portraitData.Add(315+0, portraitArr[0]);
            portraitData[414] = portraitArr[4];
            portraitData.Add(410+3, portraitArr[3]);
            portraitData.Add(415+3, portraitArr[3]);
            portraitData.Add(415+4, portraitArr[4]);
            portraitData.Add(510+5, portraitArr[5]);
            portraitData.Add(515+5, portraitArr[5]);

            talkData.Add(12020, new string[]{"학교 끝나고 이따 영화 보러갈래?:2:0","진솔이랑 지유도 간다했는데.:2:0"});
            talkData.Add(12025, new string[]{"공포 영화야.:2:0","누군가에게 감시당하는 내용의.:2:0","공포 영화는 별로야?:2:0","좀 귀찮다.:0:0","...:2:0","별로 안 무서워할 것 같긴해.:2:0","보통은 지유가 무서워할 것 같이 생겼어.:2:0","의외의 인물이.:2:0","귀찮으면 다음에 가자.:2:0"});

            talkData.Add(12030, new string[]{"책을 읽고있다.:0:0","페이지를 계속 넘기지 않는다.:0:0","무언가를 골똘히 생각중인듯 하다.:0:0"});
            talkData.Add(12035, new string[]{"아 안녕.:2:0","그냥 연쇄살인에 대해서... 궁금한 점이 있어서.:7:0","찾아보고 있었는데.:7:0","들어볼래?:2:0","연쇄살인범은 살인으로 자신의 자존감을 채워.:2:0","정확히는 과시하는 걸로 자존감을 채우게 되나봐.:2:0","그래서 연쇄살인이라는 건 어떤 동기가 있다고\n 보기 어렵다고 생각하게 됐어.:2:0","살인을 통해 채워진 자존감이:2:0","또 살인을 부르는 거지.:2:0","결국은 테이프 연쇄살인건도 그럴 거라고 생각했는데...:7:0","테이프 살인 건은 다르다는 얘기일까?:0:0","왜 표적이 남자일까?:7:0","표적이 가출청소년.. 뭐..:7:0","그런건 이해돼.:2:0","하지만 남자를 표적으로 삼는 건 너무...:7:0","위험하다는 거지.:7:0","반대로 제압당할 수 있는 거잖아?:2:0","...왜일까? 일반적인 태도는 아니야.:2:0"});
            //영화내용, 교통사고-2명
            talkData.Add(12040, new string[]{"...였어.:3:0","일단 너무 안 무서웠지.:3:0","공포영화인데 안 무서운 게 말이 돼?:3:0"});
            talkData.Add(12045, new string[]{"아 맞아. 저번에 봤던 영화 얘기중이었는데.:2:0","음...:2:0","재미없었어.:3:0","귀신이 포스없었어.:2:0","일단 귀신이 적인 줄 알았는데 사실 지켜주고 있었다는...:2:0","내용이었어.:2:0","웬만한 공포영화는 영화관에서 보면 반 이상은 가는데.:8:0","공포영화가 무섭지 않은 것도 죄지만:2:0","개연성도 없었어.:2:0","언니가 동생대신 죽었는데 시간이 흘렀다고 해도\n 귀신인 상태에서 살아있는 사람을 좋아하게 되는건지.:2:0","살아있는 사람이 죽은 사람을 미화하는 건 봤어도.:2:0","흠...:3:0","...:8:0","확실히 죽기 전에도 사이가 안 좋은 수준이 아니었는데.:3:0","애초에 동생을 혼자 좋아했던 거 아냐?:3:0","그렇게 물러서 결국은 동생이 이긴 엔딩이 된거지.:3:0","아 은우한텐 스포일까?:2:0","결국은 동생의 계획이었다는 엔딩이야.:2:0","귀신도 없애고 스토커도 죽이고.\n 일타이피라는.:2:0","솔직히 말하면 동생이 나쁘다기보단.:2:0","냉정하다고 해야할지.:3:0","정확히는 똑똑한거지.:2:0"});
            
            talkData.Add(12050, new string[]{"저번에 영화 같이 안봤잖아.:2:0","주말에 같이 놀자.:2:0"});
            talkData.Add(12055, new string[]{"그래.:2:0","너 어디 살아?:2:0","좀 멀긴한데.:0:0","...:2:0","아... 그럼 평일에 놀자.:2:0","근처에서는 못 놀겠네.:2:0","진솔이 pc방에서 완전 사는 거 알아?:2:0","주말에 그냥 게임이나 하면서 보내려고 했거든.:2:0","시험기간이라 가면 안되는데...:2:0","...:2:0","너 진솔이한테 관심있지?:2:0","...:7:0"});

            portraitData.Add(12020+2, portraitArr[2]);
            portraitData.Add(12025+0, portraitArr[0]);
            portraitData.Add(12025+2, portraitArr[2]);
            portraitData.Add(12030+0, portraitArr[0]);
            portraitData.Add(12035+0, portraitArr[0]);
            portraitData.Add(12035+2, portraitArr[2]);
            portraitData.Add(12035+7, portraitArr[7]);
            portraitData.Add(12040+3, portraitArr[3]);
            portraitData.Add(12045+0, portraitArr[0]);
            portraitData.Add(12045+2, portraitArr[2]);
            portraitData.Add(12045+3, portraitArr[3]);
            portraitData.Add(12050+2, portraitArr[2]);
            portraitData.Add(12050+3, portraitArr[3]);
            portraitData.Add(12055+3, portraitArr[3]);
            portraitData.Add(12055+0, portraitArr[0]);
            portraitData.Add(12055+8, portraitArr[8]);
            portraitData.Add(12055+2, portraitArr[2]);
            portraitData.Add(12055+7, portraitArr[7]);
            
        }
        
        else if(chapter == 2){

            //연쇄, 시체씬
            //220, 죄와 벌
            //125, 잡지
            talkData.Add(120, new string[]{"잡지를 보고 있는 것 같다.:0:0"});
            talkData.Add(125, new string[]{"그냥 그래.:1:0","...:1:0","아니 별로 관심이 있는 건 아닌데.:1:0","원래 첫인상에 얼굴도 중요하지만 패션이 중요하거든.:1:0","생각보다 얼굴이 다가 아니라는거지.:1:0","물론 얼굴이 괜찮으면 스타일같은 건 의미없긴 하지만.:1:0","패션에 관심이 많은건가..?:0:0","그리고 머리카락으로 얼굴을 가려도 되는거잖아?:0:0","얼굴이 안된다고해서 안 꾸미면 진짜 루저가 되는거라고.:0:0","그래도 이 머리색은 너무 고집하는 거 아냐?:2:0","퍼스널 컬러라고 알아?:2:0","너 머리색은 검은색이 더 나을 것 같은데.:2:0","나도 그렇게 생각하긴 하는데...:1:0","그런데 뭘 하든 잘 어울릴 것 같기도 해.:2:0","전혀 안 그래.:1:0"});
            talkData.Add(220, new string[]{"은우야 궁금한 거 있는데 물어도 돼?:2:0"});
            talkData.Add(225, new string[]{"계속 뉴스에 나오고 있는 사건에 대해 아는 거 있어?:2:0","근처 동네니까.:2:0","...그냥 궁금하잖아.:2:0","어차피 할 수 있는 것도 없는데... 불편하다.:0:0","어디까지 도망칠 수 있을 지 궁금하네.:7:0","최근엔 연쇄살인같은 일은 없었잖아.\n 요즘 세상은 그런걸 할 수 없는 세상이니.:2:0","게다가 자신의 흔적을 남기니까. 관종처럼.:7:0","너 죄와 벌이라는 소설 알아?:2:0","나온지 얼마 안된 책인데 최근에 어쩌다 읽었었어.:2:0","그 소설의 주인공은 살인자인데. 특별한 타겟을 죽이는 거야.:2:0","음... 사회악들을? 자신이 처형을 한다고 생각하면서.:2:0","합리화 비슷한건지.:2:0","혹시 그 살인자도 그렇게 생각하고 있으려나.:2:0"});
            talkData.Add(320, new string[]{"배드민턴 같이 할래?:3:0","이렇게라도 몸을 움직여줘야 오히려 에너지가 생기는 거야.:3:0"});
            talkData.Add(325, new string[]{"그런데.:3:0","너는 만약에 '연쇄살인이 최근 많이 일어난다'라고 하면:3:0","1번 '조심해서 다녀야겠다.',\n 2번 '사건에 대해 궁금하다.':3:0","어때?:3:0","아. 그냥... 간이 심리테스트래.:3:0","1번 현실적이고 감각적인 것에 끌림.:3:0","2번 추상적인 것에 끌리고 상상을 많이함.:3:0","이라고 하네.:3:0","그런데 2번이 있긴 한지 모르겠네.:3:0","알아서 무슨 의미가 있다고.:3:0","나 2번인데.:0:0","...:3:0","그래?:3:0","너 지윤이랑 잘 맞겠다.:3:0"});
            talkData.Add(420, new string[]{"...:0:10",":0:11","핸드폰을 하고 있는 듯하다.:0:12"});
            talkData.Add(425, new string[]{"공기계 냈어.:4:0","별 생각 없어 보인다.:0:12","쌤이 원래 안 확인하셔.:4:12","핸드폰 가방도 따로 관리하니까.:4:12","...:4:12","...:0:12","...:9:0","누가 핸드폰 하래?:2:0","빼았겼다...:0:0"});
            talkData.Add(520, new string[]{"항상 바쁘게 다니는 것 같다.:0:0","실제로 바쁜지는 모르겠다.:0:0"});
            talkData.Add(525, new string[]{"은우야.:5:0","지윤이 보면 좀 불러줄래?:5:0","또 무슨 상담인 것 같다...:0:0"});
            
            //어떻게 챕터 talkData 추가하는 지 까묵
            talkData.Add(200, new string[]{"바닥에 a4용지 한 장이 떨어져있다.","최근 화제가 된 연쇄살인에 관해 메모해 둔 모양이다.","'표적의 얼굴이 비슷함.'","'사체의 발견이 늦음','표적 - 가출청소년(?)'","연쇄살인범 - 성인 남성 추정","'단계 : 1. 스토킹 2. 유괴'","'3. 살해, 4. 사체유기'","(누가 이 걸 썼을까.)"});
            
            
            portraitData.Add(120+0, portraitArr[0]);
            portraitData.Add(125+0, portraitArr[0]);
            portraitData.Add(125+1, portraitArr[1]);
            portraitData.Add(125+2, portraitArr[2]);
            portraitData.Add(220+2, portraitArr[2]);
            portraitData.Add(225+2, portraitArr[2]);
            portraitData.Add(225+0, portraitArr[0]);
            portraitData.Add(320+3, portraitArr[3]);
            portraitData.Add(325+3, portraitArr[3]);
            portraitData.Add(420+0, portraitArr[0]);
            portraitData.Add(425+0, portraitArr[0]);
            portraitData.Add(425+2, portraitArr[2]);
            portraitData.Add(425+4, portraitArr[4]);
            portraitData[520+0] = portraitArr[0];
            portraitData.Add(525+5, portraitArr[5]);
            portraitData.Add(525+0, portraitArr[0]);            

        }

        else if(chapter ==3){
            //축제 : 동아리 부스_페이스페인팅 : 손에
            talkData.Add(130, new string[]{"...:1:0","솔직히 지윤이가 잘못하긴 했어.:1:0","여러모로.:1:0"});
            talkData.Add(230, new string[]{"사실 이해가 안되는 건 아냐.:2:0"});
            talkData.Add(330, new string[]{"사실 잘못한 사람은 정해진 분위기긴하지.:3:0","지윤이가 어떻게 말하든 이미 은진이가 이겼어.:3:0"});
            talkData.Add(430, new string[]{"음...:4:0"});
            
            talkData.Add(135, new string[]{"음...:1:0","역사적인 이야기인데...:1:0","이런 식으로 자주 싸웠었어.:1:0","애초에 그런 식으로 독단적으로 정하면 어떻게 해.:1:0","쿨하게 넘어가는 것도 정도껏이지.:1:0","태도에 화가난 듯 하다.:0:0","작년에도 이런 식이었거든.:1:0"});
            talkData.Add(235, new string[]{"이번엔 내가 빨리 하려다 보니 이랬는데.:2:0","같이 얘기했어야 했는데 얘기를 안 한거지.:2:0","그런데 그게 그렇게 문제가 되나?:7:0","내가 내 편할대로 하는 것도 아니고 다 편의를 봐주는데.:7:0","전에는 나도 잘못했어.:2:0","그런데 지난일은 지난 일 아냐?:2:0","그 때 바로 해결하지 않으면 어떻게\n 같이 회장, 부회장을 할 수 있어.:7:0","결국은 지윤이는 은진이를 이해 못한다는 뜻이다.:0:0"});
            talkData.Add(335, new string[]{"서운한 점을 말하지 않으면 모른다는 건 도피성이야.:3:0","단순히 책임감이 부족하다... 그런거지.:3:0","처음 둘이 싸웠을 땐 당황스럽기도 하고 그랬는데.:3:0","이제는 될대로 되라 싶어.:3:0","내가 진작에 나가든가 해야했어.:8:0","빨리 탈출하고 싶다.:8:0","아무나 이겨라. 어차피 나는 탈출할꺼니까.:3:0"});
            talkData.Add(435, new string[]{"둘 다 문제 있는 거겠지.:4:0","둘이 이렇게 해버리면 우린 어떡하라고.:4:0","에효.:4:0"}); //나중에 도와주는 걸로 특성

            portraitData.Add(130+0, portraitArr[0]);
            portraitData.Add(135+0, portraitArr[0]);
            portraitData.Add(135+1, portraitArr[1]);
            portraitData.Add(230+2, portraitArr[2]);
            portraitData.Add(235+2, portraitArr[2]);
            portraitData.Add(235+0, portraitArr[0]);
            portraitData.Add(235+7, portraitArr[7]);
            portraitData.Add(330+3, portraitArr[3]);
            portraitData.Add(335+3, portraitArr[3]);
            portraitData.Add(335+8, portraitArr[8]);
            portraitData.Add(430+4, portraitArr[4]);
            portraitData.Add(435+4, portraitArr[4]);


        }

        else if (chapter == 4){

            //상황종료, 인물 관계도
            talkData.Add(140, new string[]{"이게 잘 해결된건지 모르겠네.:1:0","은진이도 그렇게 생각할걸.:1:0"});
            talkData.Add(145, new string[]{"엥?:1:0","외부에 적이 생긴 걸 생각해보면 잘 도와줬다고\n 볼 수도 있겠네.:1:0","...:1:0","확실히 이번에 도움이 되긴 했어.:1:0","걘 진짜 너무 마이웨이라 착했다가 나빴다가 해.:1:0","이해가 잘 안 돼.:1:0","남의 물건도 잘.:1:0","훔쳐가고.:1:0","적어도 지윤이는 솔직한 게 있어.:1:0","대놓고 악당이란건가?:1:0"});
            talkData.Add(240, new string[]{"일단 잘 돼서 다행이야.:7:0"});
            talkData.Add(245, new string[]{"음... 일단 다들 은진이 잘 달래줘서 이렇게 끝난거지.:2:0","진솔이도 그렇고.:2:0","지유는 그냥 모른 척 하긴 했지만:2:0","지유야 원래 그러니까.:2:0","그래도 지유는 자기 할 일은 다 하지.:7:0","진솔이는 평소에는 이런 일 무시하는데.:2:0","가끔 이렇게 크게 도와줘.:2:0"});

            talkData.Add(340, new string[]{"이럴 줄 알았어.:3:0","지윤이는 꼭 누가 져줘야 한다니까.:3:0"});
            talkData.Add(345, new string[]{"전에는 유정이가 자주 져줬지.\n 유정이가 생각보다 여린 게 있어.:3:0","의외로.:8:0","애초에 배려심이 많은 건가?:3:0","...:3:0","...:8:0","지윤이가 나쁘다는 건 아냐.:3:0","둘이 안 맞는 걸 어쩌겠어?:3:0","둘이 안 맞는데 매일 매일 봐야하는 게 문제지.:3:0","예전에 한 번 크게 싸웠었어.:3:0","하여튼.:8:0","둘은 이제는 잘 해결봤어. 친구의 친구 관계?:8:0","나한테 물어보지마. 나도 왜 싸웠는 지 잘 몰라.:3:0"});
            talkData.Add(440, new string[]{"진짜 누가 더 잘못했냐를 말해보자면.:4:0","은진이가 잘못했지.:4:0"});
            talkData.Add(445, new string[]{"어쩔 수 없어.:4:0","단순하게 말하자면 힘들게 한 사람의 수가 다르잖아.:4:0","뭐 기분 나쁘다고 그냥 관두면 안되는 거지.:4:0","그렇게 생각하지 않아?:4:0","그리고 상황 자체만 보면 별로 문제 없는 상황이었는데...:4:0","별로 기분 나쁠만한 상황이 아니었는데.:4:0"});
            talkData.Add(530, new string[]{"너희끼리 잘 해결본거야?:5:0"});
            talkData.Add(535, new string[]{"그래도 은진이가 성격이 좋다 그러던데.:5:0","지윤이나 은진이나 수능 때문에 예민해졌거나 그렇겠지.:5:0","너무 예민해 하지마.:5:0","진짜 쓸 데 없는 데에 힘빼는거야.:5:0"});           

            

            portraitData.Add(140+1, portraitArr[1]);
            portraitData.Add(145+1, portraitArr[1]);
            portraitData.Add(145+0, portraitArr[0]);
            portraitData.Add(240+7, portraitArr[7]);
            portraitData.Add(245+2, portraitArr[2]);
            portraitData.Add(245+7, portraitArr[7]);
            portraitData.Add(340+3, portraitArr[3]);
            portraitData.Add(345+3, portraitArr[3]);
            portraitData.Add(345+8, portraitArr[8]);
            portraitData.Add(440+4, portraitArr[4]);
            portraitData.Add(445+4, portraitArr[4]);
            portraitData.Add(530+5, portraitArr[5]);
            portraitData.Add(535+5, portraitArr[5]);
        }
        
        else if (chapter == 5){

            //떠보기 - 관계에 대해서, 

            talkData.Add(150, new string[]{"수능까지 이제 한 달도 안 남았다는 게 \n 실감이 안 돼.:1:0","계속 자습인 수업도 있는데 아무 것도 안하니까 시간이 안 가.:1:0"});
            talkData.Add(155, new string[]{"걔는 정시는 아닌데 수능 최저 있어서 공부 해야돼.:1:0","...:1:0","수능 최저 몰라? 너무 대충 사는 거 아냐?:1:0","그냥 수능에서 어느 정도 잘 해야지 대학에서 접수를 받아주는 거야.:1:0","...:2:0","모를 수도 있지.:2:0","전학 왔을 때 한참 바빴으니까.:2:0","예전에 둘이 크게 싸웠었다는 데...:0:0","사이가 의외로 좋아보인다.:0:0","물어볼까?:0:0","...:2:0","...:1:0","그런데 솔직히 싸운 게 한 두 번은 아니야.:2:0","그게 계속 쌓이다보니 좀 어색했던 때가 있었어.:2:0","그런데 우리 싸운 거 누가 말해줬어?:1:0"});
            talkData.Add(250, new string[]{"하...:7:0","테이프...:7:0","아.:2:0","안녕.:2:0","공부 하기가 싫으니까 별의 별 게 신경쓰여.:2:0"});
            talkData.Add(255, new string[]{"사람 팔이나 다리를 절단하려면 얼마나 시간이 걸릴까?:2:0","피부까진 빨리 할 수 있다쳐도 뼈까지는 힘들잖아.:2:0","팔이나 다리 절단하는 것만 시간이 그렇게 오래 걸리는데.:2:0","토막 살인은 도대체 어떻게 하는거지.:7:0","시간이 얼마나 걸릴까. 여럿이 할 수 있는 것도 아니고.:7:0","아...:2:0","몇 달전까지 연쇄살인 얘기가 많았잖아.:2:0","여러모로 신경쓰이는 점이 있어서.:2:0","이상하게 우리 지역이고.:2:0","소식도 끊기고.:2:0","그리고 테이프는 왜 붙이는 거야.:7:0","과시?:7:0"});

            talkData.Add(350, new string[]{"뉴스 봤어?:3:0","고등학생 자살, 추락사.:3:0"});
            talkData.Add(355, new string[]{"몇 년에 한 번씩은 있는 것 같어.:3:0","몇 달전에 있었던 연쇄살인 사건이 영향을 줬을까.:3:0","글쎄.:0:0","좀 애매하긴 한데...:3:0","어떻게 이런 사건들이 이렇게 주변에서\n 많이 일어날 수가 있는건지.:3:0","연쇄살인도 사실 뉴스에서만 볼 수 있는 건데.:3:0","...:3:0","아 맞아. 자살은 다른 지역이긴한데.:3:0","난 근처에서 일어난 적 있거든.:3:0","아주 근처에서?:3:0","나랑 별로 관련된 사람은 아니었는데.:3:0"});
            talkData.Add(450, new string[]{"원래 친해보이는 것과 진짜 친한 건 다른거니까.:4:0"});
            talkData.Add(455, new string[]{"진짜 이해가 안되는 건 친한 척 하는건데.:4:0","친해보이고 싶은건지.:4:0","싸우면 싸울 수도 있는거지.:4:0","별 것도 아니게 싸워가지고.:4:0","은진이 얘기를 하는 것 같다.:0:0","여자애들은 꼭 보여주기식으로 행동해.:4:0"});
            talkData.Add(540, new string[]{"말싸움이나 하면서 시간 보내는 것보다:5:0","차라리 게임이라도 하면서 휴식하는 게 나아.:5:0"});
            talkData.Add(545, new string[]{"너희끼리 싸우거나 할 수 있지만.:5:0","중요한 건 그럴때도 시간은 계속 흐른다.:5:0","쓸 데 없는 데에 시간 쏟지 말고.:5:0","수능 끝나면 할 일도 없어지고 다시 친해져.:5:0"});

            portraitData.Add(150+1, portraitArr[1]);
            portraitData.Add(155+1, portraitArr[1]);
            portraitData.Add(155+0, portraitArr[0]);
            portraitData.Add(250+7, portraitArr[7]);
            portraitData.Add(250+2, portraitArr[2]);
            portraitData.Add(255+2, portraitArr[2]);
            portraitData.Add(255+7, portraitArr[7]);
            portraitData.Add(350+3, portraitArr[3]);
            portraitData.Add(355+3, portraitArr[3]);
            portraitData.Add(355+8, portraitArr[8]);
            portraitData.Add(450+4, portraitArr[4]);
            portraitData.Add(455+4, portraitArr[4]);
            portraitData.Add(455+0, portraitArr[0]);
            portraitData.Add(540+5, portraitArr[5]);
            portraitData.Add(545+5, portraitArr[5]);
        }

        else if (chapter == 6){

            //죽음에 대해서 - 과거 살인
            //장면 : 궁리-지윤, 유정
            talkData.Add(160, new string[]{"넌 죽으면 어떻게 될 지 고민해 본 적 없어?:1:0","갑자기?:0:0"});
            talkData.Add(165, new string[]{"넌 어떻게 생각해?:1:0","나도 똑같아.:3:0","재미없네.:1:0","그런데 둘이 진짜 잘 맞아.:1:0","아무 편도 안드는게.:1:0","전생에도 친했을 수도 있어.:1:0","전생을 믿는건가?:0:0","그럼 전생에 같은 동물이었을 수도.:3:0","인간이었을 수도 있지.:1:0","전생에도 친했을 걸.:2:0","다음 생에 인간으로 태어나려고 착하게 살고 있는거야?:2:0","나?:1:0","나는 그냥 양심 가지고 사는거지. 그리고 망했잖아.:1:0","...:7:0","글쎼.:2:0","난 죽으면 지옥 갈걸.:1:0","하루살이로 태어나는 거겠지.:2:0"});
            talkData.Add(260, new string[]{"지윤아.:2:0","시간 있으면 고민상담 해줄 수 있어?:7:0"});
            talkData.Add(265, new string[]{"사실 고민 정도는 아니야.:2:0","그냥 수능 끝나고... 뭘 해야 할까.:2:0","앞으로를 공부 하면서 버티려면 동기부여가 필요한 것 같아서.:7:0","최근에 공부하기가 싫어졌거든.:2:0","뭐라도 해보는 게 좋지 않나.:2:0","그래서.:2:0","수능 끝나고 뭘 해야 할까...:2:0","난 대학 생활 낭만 같은 건 없는데.:7:0","그래도 대학교에 들어가면 좋은 점은 자유겠지.:2:0","대학 가면 넌 연락 끊을 거지?:2:0","...:2:0","장난이야.:2:0","그래도 대학가면 만나고 싶은 사람만 만나면 된다는 장점이 있네.:2:0","새 시작.:2:0","하...:7:0","그래서 수능 끝나서 뭘 해야하는건지.:7:0"});
            //수능 끝난 후에는

            talkData.Add(360, new string[]{"그런데 사실.:3:0","지윤이랑 유정이가 어떻게 싸웠는 지 나는 잘 몰라.:3:0"});
            talkData.Add(365, new string[]{"그런데 그게 뭐가 그렇게 문제인건지.:3:0","오히려 숨기려고 하니까:3:0","오히려 궁금해져.:3:0"});
            talkData.Add(460, new string[]{"내가 충격적인 거 하나 알려줄까?:9:0"});
            talkData.Add(465, new string[]{"저주 받을 것 같아서 조금 고민되긴 하는데.:4:0","...:4:0","지윤이네 언니가 우리 학교에서 추락사했었어.:4:0","그 이후로 지윤이랑 유정이가 서먹해진거야.:4:0","둘이 애초에 안맞기도 했지만 유정이가 추락사할 때...:4:0","음... 막지 못했다 하는 게 있어서.:4:0","사실 그렇게 끝날 게 아니고 엄청 복잡한데.:4:0","애초에 당연히 둘이 안맞기도 하지만.:4:0","...:4:0","이래서 보이는 게 다가 아니라는 거지.:4:0","이미지로만 보면 무슨 나쁜 사람이랑 착한 사람이\n 있는 것 같아보이지만.:4:0","또 반대일 수 있다.:4:0"});
            talkData.Add(550, new string[]{"지금은 늦긴 했는데.:5:0","상담 필요해?:5:0"});
            talkData.Add(555, new string[]{"사실 상담이 남들보다 한참 뒤긴 하지.:5:0","보통은 9월 전에 끝내니까.:5:0","이미 전문대 쓰기로 했는데.:5:0","네가 아무 생각이 없는 것 같아서 상담 하려고 한거야.:5:0","무슨 생각이야?:5:0","대학에도 의지가 없고 전공에도 네 의지가 없잖아.:5:0","진지하게 시간들여서 고민을 많이 해봐야 돼.:5:0"});

            portraitData.Add(160+1, portraitArr[1]);
            portraitData.Add(165+1, portraitArr[1]);
            portraitData.Add(160+0, portraitArr[0]);
            portraitData.Add(165+3, portraitArr[3]);
            portraitData.Add(165+0, portraitArr[0]);
            portraitData.Add(165+2, portraitArr[2]);
            portraitData.Add(165+7, portraitArr[7]);
            
            portraitData.Add(260+2, portraitArr[2]);
            portraitData.Add(260+7, portraitArr[7]);
            portraitData.Add(265+2, portraitArr[2]);
            portraitData.Add(265+7, portraitArr[7]);
            portraitData.Add(360+3, portraitArr[3]);
            portraitData.Add(365+3, portraitArr[3]);
            portraitData.Add(365+8, portraitArr[8]);
            portraitData.Add(460+4, portraitArr[4]);
            portraitData.Add(465+4, portraitArr[4]);
            portraitData.Add(465+9, portraitArr[9]);
            portraitData.Add(550+5, portraitArr[5]);
            portraitData.Add(555+5, portraitArr[5]);

        }

        else if(chapter == 7){
            //톰과 제리
            talkData.Add(170, new string[]{"너 지윤이한테 뭐 잘못한 거 있어?:1:0"});
            talkData.Add(175, new string[]{"아 너 어제 하교할 때 봤냐고 하던데.:1:0","어제 하교할 때?:0:0","왜 잘못한 거 있냐고 물어본거지.:0:0","그러고보니 어디살아?:1:0","지윤이도 궁금해하던데.:1:0","너만 빼고 다 야자해서 알 일이 없었네.:1:0","이번에 이사해서 전학온거니까 그래도 가까울텐데.:1:0","다음에 초대해줘.:2:0"});
            talkData.Add(270, new string[]{"저 책 읽어봤어?:2:0"});
            talkData.Add(275, new string[]{"프로파일링 관련 책이야. 그런데 잘못 된 게 있는데:2:0","'시체의 부패는 대기 중에서 가장 느리며 물 속, 흙 속에서 빠르다.':2:0","아마 반대일거야. 일반적으로 생각해도 그렇지?:2:0","프로파일링에 관심 있어?:2:0","프로파일링이나 범죄심리학. 좀 흥미롭잖아.:2:0","토막살인사건도 뉴스에 나왔고.:2:0","보통 수감자 중에서 20퍼센트 정도가 사이코패스래.:2:0","그래서 내 생각엔 연쇄살인 정도가 아니라면:2:0","사이코패스라고 확신하기 어려워.:2:0","난 20퍼센트면 많다고 생각했는데.:0:0","뭐, 아무튼. 그래서 :2:0","그 테이프 연쇄살인의 범인은 사이코가 아닐까 싶어.:7:0","마음 속에 어떤 병이 있길래 그러는 걸까.:7:0","자극적인 경험에 중독되는 건가?:7:0","글쎄.:0:0","다 다르겠지만.:7:0","이번 건은 그런 살인으로 자신의 존재를 확인하고 싶은...:7:0","그런 류의 애정결핍이나 관종인거겠지.:2:0"});
            talkData.Add(370, new string[]{"너 큰일났다.:3:0","너 지윤이한테 물렸어.:3:0"});
            talkData.Add(375, new string[]{"걔 원래 지독한데.:3:0","내 생각엔 네가 자꾸\n 예전 일을 알려고 해서 그래.:3:0","예전에 지윤이 언니가 죽었던 사건.:3:0","그 선배가 지윤이를 좀 싫어하긴 했지. 사이도 안 좋고.:3:0","그 일 때문에 지윤이가 보통 귀찮았던 게 아니어서.:3:0","...:3:0","몰랐어..?:3:0","내가 말했다고 하지마.:8:0","조심해. 원래 지윤이는 물으면 안 놓거든.:3:0"});
            
            talkData.Add(470, new string[]{"그런데 지윤이 언니 얘기가 궁금해?:4:0"});
            talkData.Add(475, new string[]{"어떤 사람이었는지는 몰라.:4:0","특이한 타이밍에 죽은 것만 알아.:4:0","중간고사 중에 죽었거든.:4:0","시험 보다가 죽었다는 건 아니고.:9:0","시험 보는 4일 중 첫 날 저녁에 학교에서 떨어졌어.:9:0","시험 결과가 안 좋은 것 같긴 헀어.:2:0","말하지는 않지만 결과가 표정에 다 티나거든.:2:0","아.:4:0","야자 끝나고 집에 안 돌아가다가 떨어졌나봐.:2:0","난 그땐 2학년이어서 야자를 잘 하진 않았어서.:2:0","그 때 당시에 언니랑 친하진 않았지만.:2:0","야자를 같이 했으면 또 모르는 일이라고 생각하니:2:0","좀 죄책감이 들긴 하더라.:7:0"});
            //야자 참여한 사람
            
            portraitData.Add(170+1, portraitArr[1]);
            portraitData.Add(175+1, portraitArr[1]);
            portraitData.Add(175+2, portraitArr[2]);
            portraitData.Add(175+0, portraitArr[0]);
            portraitData.Add(270+2, portraitArr[2]);
            portraitData.Add(275+2, portraitArr[2]);
            portraitData.Add(275+7, portraitArr[7]);
            portraitData.Add(275+0, portraitArr[0]);
            portraitData.Add(370+3, portraitArr[3]);
            portraitData.Add(375+3, portraitArr[3]);
            portraitData.Add(375+8, portraitArr[8]);
            portraitData.Add(470+4, portraitArr[4]);
            portraitData.Add(475+4, portraitArr[4]);
            portraitData.Add(475+9, portraitArr[9]);
            portraitData.Add(475+7, portraitArr[7]);
            portraitData.Add(475+2, portraitArr[2]);
        }

        else if(chapter == 8){
            //마음 맞는 친구
            //같이 하교
            talkData.Add(180, new string[]{"저번에 집에 오고 싶어했는데 데려갈까?:0:0"});
            talkData.Add(185, new string[]{"오늘?:1:0","상관없어.:1:0","경찰차가 보인다.:0:0","결론이 난 것 같다.:0:0","인생이 타이밍이라.:0:0","이번엔 내가 이긴 모양이다.:0:0"});
            talkData.Add(280, new string[]{"저번에 집에 오고 싶어했는데 데려갈까?:0:0"});
            talkData.Add(285, new string[]{"경찰차가 보인다.:0:0","결론이 난 것 같다.:0:0","집에 빨리 가야할 수도 있겠는데?:0:0","아마 경찰차는 학교를 향할텐데.:0:0","집은 오히려 이미 늦었을 수도.:0:0","어떻게 해야하지?:0:0"});


            portraitData.Add(180+0, portraitArr[0]);
            portraitData.Add(185+1, portraitArr[1]);
            portraitData.Add(185+0, portraitArr[0]);
            portraitData.Add(280+0, portraitArr[0]);
            portraitData.Add(285+2, portraitArr[2]);
        }

        }
    public Sprite GetPortrait(int id, int portraitIndex){
        // Debug.Log(id+portraitIndex);
        return portraitData[id+portraitIndex];
}

    public string GetTalk(int talkIndex, int id){

        if(talkIndex == talkData[id].Length){
            return null;
        }
        else{
            return talkData[id][talkIndex];
        }
    }



}