using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraViewSwitch : MonoBehaviour
{
    static bool topViewMode = false;
    public GameObject topViewObject;
    public GameObject regularViewObject;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        print(topViewMode);
        if (Input.GetKeyUp(KeyCode.Space))
        {
            if (!topViewMode)
            {
                topViewMode = true;
                topViewObject.SetActive(true);
                regularViewObject.SetActive(false);
            }
            else
            {
                topViewMode = false;
                regularViewObject.SetActive(true);
                topViewObject.SetActive(false);
            }
            
        }
    }
}
