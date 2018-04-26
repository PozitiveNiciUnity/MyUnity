using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickThreeBattonShop : MonoBehaviour
{

    public GameObject NoMoney;

    public Text textcost3;

    public static int costshop3 = 50000;

    public static int multipliershop3 = 100;

    void Start()
    {
        NoMoney.SetActive(false);

    }





    void Update()
    {

    }


    public void EscNoMoney()
    {
        NoMoney.SetActive(false);
    }




    public void ShopbattonThree()
    {
        if (CarClick.money <= costshop3)
        {
            NoMoney.SetActive(true);
        }

        if (CarClick.money >= costshop3)
        {
            CarClick.moneyBonus = CarClick.moneyBonus + multipliershop3;

            CarClick.money = CarClick.money - costshop3;

            costshop3 = costshop3 * 2;

            textcost3.text = "Прибавится к клику " + "" + multipliershop3 + "\n" + "Стоимость :" + "" + costshop3;
        }



    }
}
