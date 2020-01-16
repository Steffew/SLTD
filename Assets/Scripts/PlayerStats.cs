using UnityEngine;
using System.Collections;
using TMPro;

public class PlayerStats : MonoBehaviour {

	public static int Money;
	public int startMoney = 200;
    public TextMeshProUGUI MoneyBalance;

    public static int Lives;
	public int startLives = 10;
    public TextMeshProUGUI HealthState;

    public static int rounds;

	void Start ()
	{
		Money = startMoney;
		Lives = startLives;

		rounds = 0;
	}

    private void Update()
    {
        MoneyBalance.text = "€" + Money;
        HealthState.text = " Lives: " + Lives;  
    }
}
