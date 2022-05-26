using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DegreeComponent : MonoBehaviour
{
    /*[Range(1,4)]*/
    public float scalar = 0.0f;
    /*[Range(0,360)]*/
    public float degress = 0.0f;

    float dTime;

    void Start()
    {
        
    }

    void Update()
    {
        dTime += Time.deltaTime;
        float delta = scalar * Mathf.Sin(dTime);

        // πÊ«‚(x, y)
        float x = delta * Mathf.Cos(Degrees2Rad(degress));
        float y = delta * Mathf.Sin(Degrees2Rad(degress));

        Vector3 dirVec = new Vector3(x, y, 0);

        transform.position = dirVec;
    }

    float Degrees2Rad(float degree) {
        return degree * 3.14f/ 180;
    }
}
