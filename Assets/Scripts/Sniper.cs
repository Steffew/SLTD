using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sniper : MonoBehaviour
{
    public Transform unscopedPos, scopedPos;
    Transform targetPos;
    public bool repeatable = false;
    public float speed = 1f;
    bool inTransition = false;

    void Start()
    {
        SetTarget(unscopedPos);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, targetPos.position, 7.5f * Time.deltaTime);

        if (inTransition && Vector3.Distance(transform.position, targetPos.position) < 0.1f)
        {
            inTransition = false;
            FinishedTransition();
        }

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            SetTarget(scopedPos);
        }
        if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            SetTarget(unscopedPos);
        }
    }

    void FinishedTransition()
    {
        if(Vector3.Distance(transform.position, scopedPos.position) < 0.1f)
        {
            //Do the stuff
            print("scoped");
        }

        if(Vector3.Distance(transform.position, unscopedPos.position) < 0.1f)
        {
            //Do other stuff
            print("unscoped");
        }
    }

    void SetTarget(Transform t)
    {
        targetPos = t;
        inTransition = true;
    }
}
