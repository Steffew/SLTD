using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class CameraViewSwitch : MonoBehaviour
{
    static bool topViewMode = false;
    public GameObject topViewObject;
    public GameObject regularViewObject;
    public GameObject BuyMenu;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            if (!topViewMode)
            {
                MouseLook.SetCursorLock(false);
                topViewMode = true;
                topViewObject.SetActive(true);
                BuyMenu.SetActive(true);
                regularViewObject.SetActive(false);
            }
            else
            {
                MouseLook.SetCursorLock(true);
                topViewMode = false;
                regularViewObject.SetActive(true);
                BuyMenu.SetActive(false);
                topViewObject.SetActive(false);
            }
            
        }
    }
}
