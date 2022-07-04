using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoloRunner : MonoBehaviour
{

    public Transform Runner1;
    public Transform Point1;
    public Transform Point2;
    public Transform Point3;
    public Transform Point4;
    public Transform Point5;
    int i = 0;
    private bool forward = true;
     
   
    void Start()
    {

    }

    void Update()
    {
        
        Vector3[] points = new Vector3[5] { Point1.position, Point2.position, Point3.position, Point4.position, Point5.position };
        MoveForward(points);
        MoveBack(points);
        
    }

    public void MoveForward(Vector3[] pointsArr) 
    {
        if (forward == true)
        {
            transform.LookAt(pointsArr[i + 1]);
            transform.position = Vector3.MoveTowards(transform.position, pointsArr[i + 1], Time.deltaTime);
            if (transform.position == pointsArr[i + 1])
            {
                i++;
            }
            if (transform.position == pointsArr[4]) forward = false;
        }
    }
    public void MoveBack(Vector3[] pointsArr) 
    {
        if (forward == false)
        {
            transform.LookAt(pointsArr[i - 1]);
            transform.position = Vector3.MoveTowards(transform.position, pointsArr[i - 1], Time.deltaTime);
            if (transform.position == pointsArr[i - 1])
            {
                i--;
            }
            if (transform.position == pointsArr[0]) forward = true;
        }
    }
}
