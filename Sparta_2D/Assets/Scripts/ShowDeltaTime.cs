using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowDeltaTime : MonoBehaviour
{ 
    public Text TimeTxt;

    private void Update()
    {
        TimeTxt.text = DateTime.Now.ToString("HH:mm");
    }
    
}
