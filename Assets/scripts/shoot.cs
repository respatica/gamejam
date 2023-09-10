using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public GameObject arrow;
    public float launchForce;
    public Transform shotPoint;

    public GameObject point;
    GameObject[] points;
    public int numberOfPoints;
    public float spaceBetweenPoint;
    Vector2 direct;
    // Start is called before the first frame update
    void Start()
    {
        points=new GameObject[numberOfPoints];
        for (int i =0;i<numberOfPoints;i++){
            points[i]=Instantiate(point,shotPoint.position,Quaternion.identity);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 bowPos=transform.position;
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float distace=Mathf.Sqrt(Mathf.Pow(mousePosition.x-bowPos.x,2)+Mathf.Pow(mousePosition.y-bowPos.y,2));
        //numberOfPoints=Mathf.RoundToInt(distace)*5;
        //spaceBetweenPoint=0.05f/distace;
        direct=mousePosition - bowPos;
        transform.right=direct;
        if (Input.GetMouseButtonDown(0)){
            Shoot();
        }
        for(int i =0;i<numberOfPoints;i++){
            points[i].transform.position=PointPosition(i*spaceBetweenPoint);
        }
    }
    void Shoot(){
        GameObject newArrow = Instantiate(arrow,shotPoint.position,shotPoint.rotation);
        newArrow.GetComponent<Rigidbody2D>().velocity=transform.right*launchForce;
    }

    public Vector2 PointPosition(float f){
        Vector2 position= (Vector2) shotPoint.position + (direct.normalized * launchForce*f)+0.5f* Physics2D.gravity*(f*f);
        return position;
    }
}
