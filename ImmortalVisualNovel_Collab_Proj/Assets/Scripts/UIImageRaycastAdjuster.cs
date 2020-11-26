using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIImageRaycastAdjuster : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        //make sure the image's read and write is enabled
        GetComponent<Image>().alphaHitTestMinimumThreshold = 0.5f;
    }

}
