using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyMenu : MonoBehaviour
{
    public GameObject machineTurret;
    public void BuyMachineTurret()
    {
        if (PlayerStats.Money >= 250)
        {
            PlayerStats.Money -= 250;
            print("nice");
            machineTurret.SetActive(true);
        }
    }
}
