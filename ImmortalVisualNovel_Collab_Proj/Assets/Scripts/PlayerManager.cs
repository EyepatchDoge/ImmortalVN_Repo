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

    //relationships
    public int brotherPoints = 0;
    public bool doesBrotherTrust = false;

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

    //set career
    void SetFarmer()
    {
        isFarmer = true;
    }
    void SetCrafter()
    {
        isCrafter = true;
    }
    void SetButcher()
    {
        isButcher = true;
    }

    //brother trust
    void AddBrotherTrust()
    {
        brotherPoints++;
    }
    void CheckBrotherTrust()
    {
        if(brotherPoints >= 2)
        {
            doesBrotherTrust = true;
        }
    }
}
