using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickFourBattonShop : MonoBehaviour
{

    public GameObject NoMoney;

    public Text textcost4;

    public static int costshop4 = 250000;

    public static int multipliershop4 = 200;

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




    public void ShopbattonFour()
    {
        if (CarClick.money <= costshop4)
        {
            NoMoney.SetActive(true);
        }

        if (CarClick.money >= costshop4)
        {
            CarClick.moneyBonus = CarClick.moneyBonus + multipliershop4;

            CarClick.money = CarClick.money - costshop4;

            costshop4 = costshop4 * 2;

            textcost4.text = "Прибавится к клику " + "" + multipliershop4 + "\n" + "Стоимость :" + "" + costshop4;
        }



    }
}