using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyMenu : MonoBehaviour
{
    public GameObject machineTurret;
    public GameObject machineTurretButton;
    public GameObject sniperTurret;
    public GameObject sniperTurretButton;
    public GameObject plasmaTurret;
    public GameObject plasmaTurretButton;

    public void BuyPlasmaTurret()
    {
        if (PlayerStats.Money >= 250)
        {
            PlayerStats.Money -= 250;
            plasmaTurret.SetActive(true);
            plasmaTurretButton.SetActive(false);
        }
    }
    public void BuyMachineTurret()
    {
        if (PlayerStats.Money >= 350)
        {
            PlayerStats.Money -= 350;
            machineTurret.SetActive(true);
            machineTurretButton.SetActive(false);
        }
    }
    public void BuySniperTurret()
    {
        if (PlayerStats.Money >= 400)
        {
            PlayerStats.Money -= 400;
            sniperTurret.SetActive(true);
            sniperTurretButton.SetActive(false);
        }
    }
}
