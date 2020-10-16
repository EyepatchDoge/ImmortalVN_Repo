using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    //personality points
    public int kind = 0;
    public int playful = 0;
    public int aggressive = 0;

    //careers
    public bool isFarmer = false;
    public bool isCrafter = false;
    public bool isButcher = false;

    //increment personality points
    void IncrementKind()
    {
        kind++;
        Debug.Log("Kind points: " + kind);
    }
    void IncrementPlayful()
    {
        playful++;
        Debug.Log("Playful points: " + playful);
    }
    void IncrementAggressive()
    {
        aggressive++;
        Debug.Log("Aggressive points: " + aggressive);
    }
}
