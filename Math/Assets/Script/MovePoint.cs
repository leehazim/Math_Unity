using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePoint : MonoBehaviour
{
    [SerializeField] public Transform target;
    [SerializeField] public Transform[] Points;

    public int index;
    public bool isMoveNomarize = true;
     
    void Start()
    {
        index = 0;
        target = Points[index];
    }

    void Update()
    {
        if(target != null) {
            if (Input.GetKeyDown(KeyCode.Space)) {
                isMoveNomarize = !isMoveNomarize;
            }

            Vector3 dirVec = ( target.position - transform.position );
            float length = dirVec.magnitude;
            if(length <= 2.0f) {
                index++;
                index = ( index >= Points.Length ) ? 0 : index;

                target = Points[index];
            }

            if (isMoveNomarize) dirVec = dirVec.normalized;
            transform.position += dirVec * 2f * Time.deltaTime;

            Debug.Log("dirVec" + dirVec);

            float rot = Mathf.Atan(dirVec.y / dirVec.x);
            float degree = rot * Mathf.Rad2Deg;

            Debug.Log("Rot : " + rot);
            Debug.Log("Degree" + degree);
            //if(target.position.x < transform.position.x)
                if(dirVec.x < 0) 
                     degree = 180 + degree;
            
            transform.rotation = Quaternion.Euler(0, 0, degree);
            
        }        
    }
}
