using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorMove : MonoBehaviour
{
    public Transform target;
    [Range(1, 100)]
    public float speed = 1.0f;

    public bool isMoveNomarize = false;

    void Start()
    {
        
    }

    
    void Update()
    {
        if(target != null) {
            if (Input.GetKeyDown(KeyCode.Space)) {
                isMoveNomarize = !isMoveNomarize;
            }

            Vector3 dirVec = target.position - transform.position;

            if (isMoveNomarize) {
                dirVec.Normalize();
                dirVec = dirVec / dirVec.magnitude;
            }
            transform.position += dirVec * speed * Time.deltaTime;
        }    
    }
}
