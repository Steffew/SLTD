using UnityEngine;
using System.Collections;
using TMPro;

public class PlayerStats : MonoBehaviour {

	public static int Money;
	public int startMoney = 400;
    public TextMeshProUGUI MoneyBalance;

    public static int Lives;
	public int startLives = 20;
    public TextMeshProUGUI HealthState;

    public static int Rounds;

	void Start ()
	{
		Money = startMoney;
		Lives = startLives;

		Rounds = 0;
	}

    private void Update()
    {
        MoneyBalance.text = "$ " + startMoney;
        HealthState.text = " Lives: " + Lives;
    }
}
