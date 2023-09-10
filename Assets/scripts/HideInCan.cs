using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideInCan : MonoBehaviour
{
    private Animator anim;
    private LookAtPointer LA;
    private shoot shooter;

    private void Start()
    {
        anim = this.gameObject.GetComponent<Animator>();
        LA = this.gameObject.GetComponent<LookAtPointer>();
        shooter = GameObject.FindWithTag("player").GetComponent<shoot>();

    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            anim.SetBool("hide", true);
            LA.enabled = false;
            shooter.enabled = false;
        }

        if (Input.GetMouseButtonUp(1))
        {
            anim.SetBool("hide", false);
            LA.enabled = true;
            shooter.enabled = true;
        }
    }
}
