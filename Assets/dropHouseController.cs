using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropHouseController : MonoBehaviour
{
    public string sceneName;
    private Animator anim;

    private void Start()
    {
        anim = this.gameObject.GetComponent<Animator>();

        switch (sceneName)
        {
            case "level1":
                anim.Play("dropRoom1");
                break;
            case "level2":
                anim.Play("dropRoom2");
                break;
            case "level3":
                anim.Play("dropRoom3");
                break;
            case "level4":
                anim.Play("dropRoom4");
                break;
        }
    }
}