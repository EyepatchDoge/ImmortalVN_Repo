using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditAnimation : MonoBehaviour
{
    public Animator animator;
    public GameObject returnBtn;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

   public void CreditsOn()
    {
        animator.SetBool("isCreditsOn", true);
        Debug.Log("credits are rolling");
    }

    public void CreditsOff()
    {
        animator.SetBool("isCreditsOn", false);
        Debug.Log("credits have finished");
        returnBtn.SetActive(true);
    }
}
