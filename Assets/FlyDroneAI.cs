using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyDroneAI : MonoBehaviour
{
    public float speed; 
    // Start is called before the first frame update
    void Start()
    {
        speed = 0.05f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0.2f,0 * speed * Time.deltaTime);
    }
}
