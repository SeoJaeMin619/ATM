using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextScripts2 : MonoBehaviour
{
    public Text ScriptTxt;
    int Gold = 100000;

    void Start()
    {
        ScriptTxt.text = "100000";
    }

    // Update is called once per frame
    public void GoldPlus()
    {
        Gold -= 50000;
        ScriptTxt.text = Gold.ToString();
    }
}
