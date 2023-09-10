using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropHouseController : MonoBehaviour
{
    public string sceneName;
    private Animator anim;
    [SerializeField] private GameObject room1;
    [SerializeField] private GameObject room2;
    [SerializeField] private GameObject room3;
    [SerializeField] private GameObject room4;

    public AudioSource audioSource;
    public AudioClip impact;
    public float waitTime=3.0f;
    private float timer = 0.0f;

    private void Start()
    {
        anim = this.gameObject.GetComponent<Animator>();
        room1.SetActive(false);
        room2.SetActive(false);
        room3.SetActive(false);
        room4.SetActive(false);
        

        switch (sceneName)
        {
            case "level1":
                room1.SetActive(true);
                anim.Play("dropRoom1");
                
                break;
            case "level2":
                room1.SetActive(true);
                room2.SetActive(true);
                anim.Play("dropRoom2");
                //room2.SetActive(true);
                break;
            case "level3":
                room1.SetActive(true);
                room2.SetActive(true);
                room3.SetActive(true);
                anim.Play("dropRoom3");
                break;
            case "level4":
                room1.SetActive(true);
                room2.SetActive(true);
                room3.SetActive(true);
                room4.SetActive(true);
                anim.Play("dropRoom4");
                break;
        }
        
    }
     void Update()
    {
        timer += Time.deltaTime;
        if (timer == waitTime)
        {
             audioSource.PlayOneShot(impact, 0.7F);
        }   
    }
    
}