 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointMovement : MonoBehaviour
{
    public GameObject[] checkPoints;
    int current = 0;
    
    public float speed;
    float CPradius = 1;




    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(checkPoints[current].transform.position, transform.position) < CPradius)
        {
            current++;
            if (current >= checkPoints.Length)
            {
                current = 0;
            }
        }

        transform.position = Vector3.MoveTowards(transform.position, checkPoints[current].transform.position, Time.deltaTime * speed);
        //transform.position += difference(Vector3.MoveTowards(transform.position, checkPoints[current].transform.position, Time.deltaTime * speed)) * Time.deltaTime * seconds;
    }
}





