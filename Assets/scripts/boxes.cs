using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxes : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip impact;
    public AudioClip pop;
    public AudioClip fall;
    public float speed=0.012f;
    public float speedie=3f;
    public bool hit=false;
     SpriteRenderer m_SpriteRenderer;
    
    int grav=0;
    public GameObject box;
    public bool counted;
    public bool fail=false;
    public bool succ=false;

    // Start is called before the first frame update
    void Start()
    {
         speed=0.012f;
         audioSource = GetComponent<AudioSource>();
         m_SpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
         box.GetComponent<Rigidbody2D>().gravityScale=grav;
         if (!hit){
            this.transform.position=new Vector2(this.transform.position.x+speed,(this.transform.position.y*Mathf.Cos(Time.deltaTime*speedie)));
         }
         
    }
    
    void  OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("HIT!");
             grav=1;
        if (collision.transform.tag == "arrow")
        {
           m_SpriteRenderer.sprite=null;
           //audioSource.Play();
           
           if(!hit){
           audioSource.PlayOneShot(pop, 0.7F);
           audioSource.PlayOneShot(fall, 0.9F);
           hit=true; 
           }
           


        }
        if (collision.transform.tag == "damage")
        {
           audioSource.PlayOneShot(impact, 0.7F);
           fail=true;
           span();
           
            
        }
        if (collision.transform.tag == "floor")
        {
           audioSource.PlayOneShot(impact, 0.7F);
           succ=true;
            span();
        }
    }
    void span(){
        box.GetComponent<Rigidbody2D>().constraints=RigidbodyConstraints2D.FreezeAll;
        box.GetComponent<BoxCollider2D>().enabled=false;
    }
}
