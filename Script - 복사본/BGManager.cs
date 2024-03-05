using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGManager : MonoBehaviour
{

    Dictionary<int, Sprite> BGData;
    
    public Sprite[] BGArr;

    void Awake()
    {
        BGData = new Dictionary<int, Sprite>();

        GenerateData(0);
    }

    public void GenerateData(int chapter){
        if(chapter == 0){
            BGData.Add(100+0, BGArr[0]);
            BGData.Add(105+0, BGArr[0]);
            BGData.Add(105+8, BGArr[8]);        
            BGData.Add(200+0, BGArr[0]);
            BGData.Add(205+0, BGArr[0]);
            BGData.Add(205+9, BGArr[9]);
            BGData.Add(300+0, BGArr[0]);
            BGData.Add(305+0, BGArr[0]);
            BGData.Add(400+0, BGArr[0]);
            BGData.Add(405+0, BGArr[0]);        
            BGData.Add(500+0, BGArr[0]);
            BGData.Add(505+0, BGArr[0]);


            BGData.Add(11000+0, BGArr[0]);
            BGData.Add(11005+0, BGArr[0]);
            BGData.Add(11010+0, BGArr[0]);
            BGData.Add(11015+0, BGArr[0]);
            BGData.Add(11020+0, BGArr[0]);
            BGData.Add(11025+0, BGArr[0]);
            BGData.Add(11030+0, BGArr[0]);
            BGData.Add(11035+0, BGArr[0]);
            BGData.Add(11040+0, BGArr[0]);
            BGData.Add(11045+0, BGArr[0]);
            
            BGData.Add(12000+0, BGArr[0]);
            BGData.Add(12005+0, BGArr[0]);
            BGData.Add(12010+0, BGArr[0]);
            BGData.Add(12015+0, BGArr[0]);
            BGData.Add(12020+0, BGArr[0]);
            BGData.Add(12025+0, BGArr[0]);
            BGData.Add(12030+0, BGArr[0]);
            BGData.Add(12035+0, BGArr[0]);
            BGData.Add(12040+0, BGArr[0]);
            BGData.Add(12045+0, BGArr[0]);
            BGData.Add(12050+0, BGArr[0]);
            BGData.Add(12055+0, BGArr[0]);

            BGData.Add(13000+0, BGArr[0]);
            BGData.Add(13005+0, BGArr[0]);
            BGData.Add(13010+0, BGArr[0]);
            BGData.Add(13015+0, BGArr[0]);
            BGData.Add(13020+0, BGArr[0]);
            BGData.Add(13025+0, BGArr[0]);
            BGData.Add(13030+0, BGArr[0]);
            BGData.Add(13035+0, BGArr[0]);
            BGData.Add(13040+0, BGArr[0]);
            BGData.Add(13045+0, BGArr[0]);
            BGData.Add(13050+0, BGArr[0]);
            BGData.Add(13055+0, BGArr[0]);    

            BGData.Add(14000+0, BGArr[0]);
            BGData.Add(14005+0, BGArr[0]);
            BGData.Add(14010+0, BGArr[0]);
            BGData.Add(14015+0, BGArr[0]);
            BGData.Add(14020+0, BGArr[0]);
            BGData.Add(14025+0, BGArr[0]);
            BGData.Add(14030+0, BGArr[0]);
            BGData.Add(14035+0, BGArr[0]);
            BGData.Add(14040+0, BGArr[0]);
            BGData.Add(14045+0, BGArr[0]);
            BGData.Add(14050+0, BGArr[0]);
            BGData.Add(14055+0, BGArr[0]);  


            BGData.Add(15000+0, BGArr[0]);
            BGData.Add(15005+0, BGArr[0]);
            BGData.Add(15010+0, BGArr[0]);
            BGData.Add(15015+0, BGArr[0]);
            BGData.Add(15020+0, BGArr[0]);
            BGData.Add(15025+0, BGArr[0]);
            BGData.Add(15030+0, BGArr[0]);
            BGData.Add(15035+0, BGArr[0]);
            BGData.Add(15040+0, BGArr[0]);
            BGData.Add(15045+0, BGArr[0]);
            BGData.Add(15050+0, BGArr[0]);
            BGData.Add(15055+0, BGArr[0]);  


        }

        else if(chapter == 1){
            BGData.Add(110+0, BGArr[0]);
            BGData.Add(115+0, BGArr[0]);
            BGData.Add(210+0, BGArr[0]);
            BGData.Add(215+0, BGArr[0]); 
            BGData.Add(310+0, BGArr[0]);
            BGData.Add(315+0, BGArr[0]);
            BGData.Add(410+0, BGArr[0]);
            BGData.Add(415+0, BGArr[0]);
            BGData.Add(510+0, BGArr[0]);
            BGData.Add(515+0, BGArr[0]);           
        }

        else if(chapter == 2){
            BGData.Add(120+0, BGArr[0]);
            BGData.Add(125+0, BGArr[0]);
            BGData.Add(220+0, BGArr[0]);
            BGData.Add(225+0, BGArr[0]);
            BGData.Add(320+0, BGArr[0]);
            BGData.Add(420+0, BGArr[0]);
            BGData.Add(425+0, BGArr[0]);
            BGData.Add(425+11, BGArr[11]);
            BGData.Add(425+12, BGArr[12]);
            BGData.Add(520+0, BGArr[0]);
            BGData.Add(525+0, BGArr[0]);
        }

        else if(chapter == 3){
            BGData.Add(130+0, BGArr[0]);
            BGData.Add(135+0, BGArr[0]);
            BGData.Add(230+0, BGData[0]);
            BGData.Add(235+0, BGData[0]); 
            BGData.Add(330+0, BGData[0]);
            BGData.Add(335+0, BGData[0]);
            BGData.Add(430+0, BGData[0]);
            BGData.Add(435+0, BGData[0]);          
        }

        else if(chapter == 4){
            
            BGData.Add(140+0, BGArr[0]);
            BGData.Add(145+0, BGArr[0]);
            BGData.Add(240+0, BGData[0]);
            BGData.Add(245+0, BGData[0]); 
            BGData.Add(340+0, BGData[0]);
            BGData.Add(345+0, BGData[0]);
            BGData.Add(440+0, BGData[0]);
            BGData.Add(445+0, BGData[0]);  
            BGData.Add(535+0, BGData[0]);        
        }

        else if(chapter == 5){
            
            BGData.Add(150+0, BGArr[0]);
            BGData.Add(155+0, BGArr[0]);
            BGData.Add(250+0, BGData[0]);
            BGData.Add(255+0, BGData[0]); 
            BGData.Add(350+0, BGData[0]);
            BGData.Add(355+0, BGData[0]);
            BGData.Add(450+0, BGData[0]);
            BGData.Add(455+0, BGData[0]); 
            BGData.Add(540+0, BGData[0]);
            BGData.Add(545+0, BGData[0]);
                     
        }

        else if(chapter == 6){
            
            BGData.Add(160+0, BGArr[0]);
            BGData.Add(165+0, BGArr[0]);
            BGData.Add(260+0, BGData[0]);
            BGData.Add(265+0, BGData[0]); 
            BGData.Add(360+0, BGData[0]);
            BGData.Add(365+0, BGData[0]);
            BGData.Add(460+0, BGData[0]);
            BGData.Add(465+0, BGData[0]); 

                     
        }
        else if(chapter == 7){
            
            BGData.Add(170+0, BGArr[0]);
            BGData.Add(175+0, BGArr[0]);
            BGData.Add(270+0, BGData[0]);
            BGData.Add(275+0, BGData[0]); 
            BGData.Add(370+0, BGData[0]);
            BGData.Add(375+0, BGData[0]);
            BGData.Add(470+0, BGData[0]);
            BGData.Add(475+0, BGData[0]); 
                     
        }        
        else if(chapter == 8){
            
            BGData.Add(180+0, BGArr[0]);
            BGData.Add(185+0, BGArr[0]);
            BGData.Add(280+0, BGData[0]);
            BGData.Add(285+0, BGData[0]); 
            BGData.Add(380+0, BGData[0]);
            BGData.Add(385+0, BGData[0]);
            BGData.Add(480+0, BGData[0]);
            BGData.Add(485+0, BGData[0]); 
                     
        } 
    
    }


    public Sprite GetBG(int id, int BGIndex){
        return BGData[id+BGIndex];
    }
}
