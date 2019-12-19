using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Sniper : MonoBehaviour
{
    public Transform unscopedPos, scopedPos;
    Transform targetPos;
    public bool repeatable = false;
    public float speed = 1f;
    bool inTransition = false;
    public float sniperTransparency = 0f;
    public GameObject PostProcessVolume;
    public GameObject SniperScope;

    void Start()
    {
        SetTarget(unscopedPos);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, targetPos.position, 5f * Time.deltaTime);

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

        // TEST
        if (Input.GetKeyDown(KeyCode.P))
        {
            PostProcessVolume.GetComponent<Volume>().enabled = false;
        }
    }

    void FinishedTransition()
    {
        if(Vector3.Distance(transform.position, scopedPos.position) < 0.1f)
        {
            print("scoped");
            gameObject.GetComponent<MeshRenderer>().enabled = false; // Hide sniper when scoped in.
            SniperScope.SetActive(true);
        }
        else
        {
            gameObject.GetComponent<MeshRenderer>().enabled = true; // Show sniper when not scoped in, this doesn't mean fully unscoped though.
            SniperScope.SetActive(false);
        }

        if(Vector3.Distance(transform.position, unscopedPos.position) < 0.1f)
        {
            print("unscoped");
        }
    }

    void SetTarget(Transform t)
    {
        targetPos = t;
        inTransition = true;
    }
}
