﻿using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class camerasize : MonoBehaviour
{
    void Update() 
    { 
        var camera = GetComponent<Camera>(); 
        var r = camera.rect; 
        var scaleheight = ((float)Screen.width / Screen.height) / (720f / 1180f); 
        var scalewidth = 1f / scaleheight; 
        if (scaleheight < 1f) 
        { 
            r.height = scaleheight; 
            r.y = (1f - scaleheight) / 2f;
        } 
        else 
        { 
            r.width = scalewidth; 
            r.x = (1f - scalewidth) / 2f; 
        } 
        camera.rect = r; 
    }
    
}

