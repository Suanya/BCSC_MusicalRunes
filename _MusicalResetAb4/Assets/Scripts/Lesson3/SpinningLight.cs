using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningLight : MonoBehaviour
{

    [SerializeField]
    [Range(-90f, 90f)]
    private float spinningSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // transform.Rotate(0,0,2);

        transform.Rotate(Vector3.forward * spinningSpeed * Time.deltaTime);
    }
}
