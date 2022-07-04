using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Relay : MonoBehaviour
{

    public Transform Runner1;
    public Transform Runner2;
    public Transform Runner3;
    public Transform Runner4;
    public Transform Point1;
    public Transform Point2;
    public Transform Point3;
    public Transform Point4;
    
    int i = 0;
    int j = 0;

    
    void Start()
    {

    }

  
    void Update()
    {
        
        Vector3[] points = new Vector3[4] { Point1.position, Point2.position, Point3.position, Point4.position };
        Transform[] runners = new Transform[4] { Runner1, Runner2, Runner3, Runner4 };
        MoveNext(points[i], runners[j]);
        if ((runners[j].position-points[i]).magnitude<1) 
        {
            i++;
            j++;
        }

    }

    public void MoveNext(Vector3 point,Transform runner)
    {
       runner.LookAt(point);
        runner.position=Vector3.MoveTowards(runner.position,point,Time.deltaTime);
    
    }
    
}
