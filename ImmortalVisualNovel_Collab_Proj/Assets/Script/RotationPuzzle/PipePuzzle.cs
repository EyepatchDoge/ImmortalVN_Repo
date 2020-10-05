using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipePuzzle : MonoBehaviour
{
    public GameObject[] pipe;
    public bool levelCompleted;
    //public WaterManager waterMan;
    

    // Start is called before the first frame update
    void Start()
    {
        levelCompleted = false;
    }

    public void WinningConditions()
    {
        for (int i = 0; i < pipe.Length; i++)
        {
            var whatever = pipe[i].transform.localRotation.eulerAngles.z;
            Mathf.RoundToInt(whatever);
            if (Mathf.Abs( whatever )> -1 && Mathf.Abs(whatever) < 5)
            {
                levelCompleted = true;
                

            }

            else
            {
                levelCompleted = false;
                    break;
            }
        }

        if (levelCompleted)
        {
            Debug.Log("Yass");
           // waterMan.flushing.Play();
        }

        else{
            Debug.Log("Dam, keep going buddy");
        }
    }
}
