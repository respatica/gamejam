using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxes : MonoBehaviour
{
    public AudioSource audioSource;
    public float speed=0.012f;
    public float speedie=3f;
    public bool hit=false;
     SpriteRenderer m_SpriteRenderer;
    
    int grav=0;
    public GameObject box;
    public bool counted;

    // Start is called before the first frame update
    void Start()
    {
          counted = false;
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
           audioSource.Play();
           hit=true;

        }
        if (collision.transform.tag == "damage")
        {
           //m_SpriteRenderer.setActive(false);
            
        }
    }
}
