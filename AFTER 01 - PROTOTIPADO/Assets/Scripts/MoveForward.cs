using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = transform.position + ...
        transform.position +=  Vector3.left * 5 * Time.deltaTime;
        //transform.position +=  Vector3.left + new Vector3(5f, 0f,0f) * Time.deltaTime;
    }
}
