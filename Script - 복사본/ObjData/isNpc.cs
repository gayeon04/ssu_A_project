using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isNpc : ObjData, IObjType
{

    //npc id 
    // 챕터와 관련있는 경우 : 100
    // 일상대화 : 10000

    // object에 name이라는 속성이 이미 있기 때문.
    public void printData(){
        Debug.Log("Type : npc" + objname);
    }
}
