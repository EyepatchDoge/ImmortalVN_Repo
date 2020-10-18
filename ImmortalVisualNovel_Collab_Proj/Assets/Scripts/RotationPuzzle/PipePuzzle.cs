using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PipePuzzle : MonoBehaviour
{
    //array of pipe tiles
    public Button[] pipe;

    public Button skipBtn;
    public Button endPuzzle;

    //bool to check that puzzle has been complete
    public bool puzzleCompleted;
    
    

    // Start is called before the first frame update
    void Start()
    {
       puzzleCompleted = false;
    }

    //check to make sure pipes are facing the same way
    public void WinningConditions()
    {
        //does a check of the pipes to make sure the rotation is facing the correct way
        for (int i = 0; i < pipe.Length; i++)
        {
            var currentPipes = pipe[i].transform.localRotation.eulerAngles.z;
            //rounds the int in case the number is off
            Mathf.RoundToInt(currentPipes);

            //29 is equal to the ammount of pipes that need to be correctly rotated
            if (Mathf.Abs(currentPipes) > -1 && Mathf.Abs(currentPipes) < pipe.Length)
            {
                puzzleCompleted = true;
                //OnWin();
            }

            //if puzzles are not facing the right direction then do not complete puzzle
            else
            {
                puzzleCompleted = false;
                    break;
            }
        }

        //if puzzle completed, we will change the story interger to reflect a new ending
        if (puzzleCompleted)
        {
            Debug.Log("Puzzle has been completed");
            OnWin();
            skipBtn.gameObject.SetActive(false);
            endPuzzle.gameObject.SetActive(true);
          
        }

        //if not it won't do anything
        else{
            Debug.Log("Puzzle is not complete");
        }
    }

    public void OnWin()
    {
        for (int t = 0; t < pipe.Length; t++)
        {
            pipe[t].interactable = false;
        }
    }
}
