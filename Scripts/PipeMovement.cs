using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{

    public float pipeSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentPosition = transform.position;

        transform.position = new Vector3(currentPosition.x - pipeSpeed * Time.deltaTime, currentPosition.y, currentPosition.z);

        if (transform.position.x < -30)
        {
            Destroy(gameObject);
        }
    }
}
