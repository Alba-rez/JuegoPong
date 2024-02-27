using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class ControllerScript : MonoBehaviour
{
    [SerializeField] float speed = 0.1f;
    const float MAX_Y = 5.4f;
    const float MIN_Y = -5.4f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.CompareTag("Pala2"))
        {
            if (Input.GetKey("up") && transform.position.y < MAX_Y)
            {
                transform.Translate(Vector3.up * speed);


            }
            if (Input.GetKey("down") && transform.position.y > MIN_Y)
            {
                transform.Translate(Vector3.down * speed);

            }
        }
        else if (gameObject.CompareTag("Pala1"))
        {
            if (Input.GetKey("w") && transform.position.y < MAX_Y)
            {
                transform.Translate(Vector3.up * speed);

            }

            if (Input.GetKey("s") && transform.position.y > MIN_Y)
            {
                transform.Translate(Vector3.down * speed);

            }

        }

        
    }
}
