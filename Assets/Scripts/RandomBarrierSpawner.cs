using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class RandomBarrierSpawner : MonoBehaviour
{
    public float maxTime = 1;
    private float timer = 0;
    public GameObject barrier;
    public float height;


    void Start()
    {
        GameObject newbarrier = Instantiate(barrier);
        newbarrier.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }

    void Update()
    {
    if(timer > maxTime)
        {
            GameObject newbarrier = Instantiate(barrier);
            newbarrier.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newbarrier, 15);
            timer = 0;
        }
        timer += Time.deltaTime;
    }


}