using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickSecondBattonShop : MonoBehaviour {

    public GameObject NoMoney;

    public Text textcost2;

    public static int costshop2 = 2000;

    public static int multipliershop2 = 20;

    void Start () {
        NoMoney.SetActive(false);

    }




   
    void Update () {
		
	}


    public void EscNoMoney()
    {
        NoMoney.SetActive(false);
    }




    public void ShopbattonTwo()
    {
        if (CarClick.money <= costshop2)
        {
            NoMoney.SetActive(true);
        }

        if (CarClick.money >= costshop2)
        {
            CarClick.moneyBonus = CarClick.moneyBonus + multipliershop2;

            CarClick.money = CarClick.money - costshop2;

            costshop2 = costshop2 * 2;

            textcost2.text = "Прибавится к клику " + "" + multipliershop2 + "\n" + "Стоимость :" + "" + costshop2;
        }



    }
}
