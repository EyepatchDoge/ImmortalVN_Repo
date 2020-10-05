using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeRotation : MonoBehaviour
{
    public PipePuzzle pP;

    private void Awake()
    {
        pP = GetComponent<PipePuzzle>();
    }
    public void RotatePipe(GameObject pipe)
    {

        pipe.transform.localRotation = Quaternion.Euler( new Vector3(0,0, pipe.transform.localRotation.eulerAngles.z + 90));
        //pipe.transform.Rotate(new Vector3(0, 0, pipe.transform.localRotation.eulerAngles.z + 90));
        pP.WinningConditions();
    }
}
