using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballons : MonoBehaviour
{
    public float waitTime=2.0f;
    private float timer = 0.0f;
    [SerializeField] private GameObject levelloader;

    public GameObject box;
    public Transform origin;
    public int numberofboxes;
    public int deliver=5;
    public int score;
    public int fallen=0;
    
    // Start is called before the first frame update
    void Start()
    {
        waitTime+=Random.Range(-0.80f, 1.0f);
        deliver+=Mathf.RoundToInt(Random.Range(-2.0f, 3.0f));
        levelloader.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (numberofboxes<deliver){
        timer += Time.deltaTime;
        if (timer > waitTime)
        {
        boxe();
        timer=0f;
        //Debug.Log(timer);
        numberofboxes++;
        waitTime+=Random.Range(-0.02f, 4.0f);
        }
        }else{
            
        timer += Time.deltaTime;
        
            if (timer > 5f){
              win();
            }
        }
        
        
;
    }
    void boxe(){
        GameObject newBox = Instantiate(box,origin.position,origin.rotation);
        
    }
    public void AddPoint()
    {
        score++;
    }
    public void AddCollide()
    {
        fallen++;
    }

    public void win()
    {
        LevelOver();

        if(numberofboxes>=deliver){
            if (score>=Mathf.RoundToInt(deliver*0.8f)){
                Debug.Log("win");
            }else if(score<=Mathf.RoundToInt(deliver*0.4f)){
                Debug.Log("fail");
            }
            else {
            if (timer > 25f){
                Debug.Log("so close");
                }
            }
            
        }
    }

    private void LevelOver()
    {
        levelloader.SetActive(true);
        levelloader.GetComponent<transitionCue>().updatePoints();
    }
}
