using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  ChptHint : ObjData, IObjType
{

    // 상호작용 후 gameObjec.setActive(false);
    //event인 경우와 챕터와 관련있는 hint인 경우
    

    public void printData(){
        Debug.Log("Type : npc" + objname);
    }
    public int chpt = 0;
}
