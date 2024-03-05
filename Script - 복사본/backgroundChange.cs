using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundChange : MonoBehaviour
{

public GameObject startscene;

public GameObject gh;
public GameObject classes;
public GameObject mapbutton;
public GameObject before;

//맵 : startscene, endscene(받음)
public void Map(GameObject end){

    startscene.SetActive(false);
    end.SetActive(true);
    startscene = end;

}


//현재 장소 저장 -> 하교, 수업(랜덤한 장소에서 배경변화)
public void Ghome(){
    mapbutton.SetActive(false);
    startscene.SetActive(false);
    gh.SetActive(true);
    startscene = before;
}

public void study(){
    mapbutton.SetActive(false);
    startscene.SetActive(false);
    classes.SetActive(true);
    startscene = classes;
}



}
