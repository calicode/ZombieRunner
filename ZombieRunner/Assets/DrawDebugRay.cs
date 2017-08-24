using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawDebugRay : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, Vector3.up * 100, Color.red);
    }
}
