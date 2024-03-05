using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TypeEffect : MonoBehaviour
{
    private string text;
    public TMP_Text targetText;
    private float delay = 0.05f;
    public bool effectend = false;

    public void SetMsg(string msg){
        effectend = false;
        Debug.Log(msg);
        text = msg;
        targetText.text = " ";
        EffectStart();
    }

    private void Awake(){
        targetText = GetComponent<TMP_Text>();
    }

    void EffectStart()
    {
        StartCoroutine(textPrint(delay));
    }

    IEnumerator textPrint(float d)
    {
        int count = 0;

        while (count != text.Length)
        {
            if (count < text.Length)
            {
                targetText.text += text[count].ToString();
                count++;
            }
            yield return new WaitForSeconds(delay);
        }
        effectend = true;
    }
}