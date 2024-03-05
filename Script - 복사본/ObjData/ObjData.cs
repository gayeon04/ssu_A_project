using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//objType
//npc (일상 or 비일상) 항상 상호작용 가능 턴 사용
//hint(event or chapter hint(비일상)) 상호작용 후 제거, 턴 쓰지 않음. 
//평범한 오브젝트(setActive(true)) 항상 상호작용 가능 턴 쓰지 않음

public interface IObjType{
    void printData();

}

public class ObjData : MonoBehaviour
{

    public string objname = "0";
    public int talkid;
    public bool isnpc = false;
    

}
