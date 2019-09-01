using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animateSkull : MonoBehaviour
{
    private Animator Anim;
    // Start is called before the first frame update
    void Start()
    {
        Anim = GetComponent<Animator> ();
    }

    public void AnimateSkull()
    {
        gameObject.GetComponent<Animator>().enabled = true;
        Anim.Play("skull");
    }
}
