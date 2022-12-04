using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierMove : MonoBehaviour
{
    public float barrierspeed;
    
    void Update()
    {
        transform.position += Vector3.left * barrierspeed * Time.deltaTime;
    }
}
