using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction : MonoBehaviour
{
    public GameObject scanObject;
    public Textbar textbar;

    private void OnMouseDown(){
        if(scanObject != null){
            textbar.Action(scanObject);
            SpriteRenderer spriteRenderer = scanObject.GetComponent<SpriteRenderer>();
            spriteRenderer.color = new Color(1,1,1,0);
            }
        else{
            Debug.Log("scanObject : null");
        }

    }
}
