using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballons : MonoBehaviour
{
    public float waitTime=2.0f;
    private float timer = 0.0f;
    [SerializeField] private GameObject levelloader;
    [SerializeField] private GameObject house;

    public GameObject[] box;
    public int numSelectors = 3;
    public Transform origin;
    public int numberofboxes;
    public int deliver=5;
    public int score;
    public int fallen=0;

    public bool isLevel4;
    
    // Start is called before the first frame update
    void Start()
    {
        //box=new GameObject[numSelectors];
        waitTime+=Random.Range(-0.80f, 1.0f);
        deliver+=Mathf.RoundToInt(Random.Range(-2.0f, 3.0f));
        levelloader.SetActive(false);
        StartCoroutine(WaitForAnimation());
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
        waitTime=Random.Range(1.45f, 6.0f);
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
        int i= Random.Range(0, numSelectors);
        GameObject newBox = Instantiate(box[i],origin.position,origin.rotation);
        
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
        

        if(numberofboxes>=deliver){
            if (score>=Mathf.RoundToInt(deliver*0.8f)){
                Debug.Log("win");LevelOver();
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

        if (!isLevel4)
        {
            levelloader.GetComponent<transitionCue>().updatePoints();
        }

        house.GetComponent<objectCounter>().EnableAtEnd();
    }

    private IEnumerator WaitForAnimation()
    {
        yield return new WaitForSeconds(2);
    }
}
