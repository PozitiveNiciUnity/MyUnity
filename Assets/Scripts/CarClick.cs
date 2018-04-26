using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarClick : MonoBehaviour {

    public GameObject car;

    public Text MoneyText;

    public static int money = 0;

    public static int moneyBonus = 0;

    public int MoneyBunusShopOne = 0;

    public Text Moneypertouch;


    public int moneydps;

    public int moneyclickstandart = 1;









    //Заставляет двигаться во время нажатия
    public void DownPointer()
    {
        car.GetComponent<RectTransform>().sizeDelta = new Vector2(564, 258);
    }









    //Заставляет двигаться  после отпуска 
    public void UpPointer()
    {
        car.GetComponent<RectTransform>().sizeDelta = new Vector2(613, 308);
    }








    public void OnClick()
    {

        money = money + 1 + moneyBonus;
        MoneyText.text = money + " ";
    }







    public void Update()
    {

        int moneydps = moneyBonus + moneyclickstandart;
        MoneyText.text = money + "";
        Moneypertouch.text = "Монеток за клик " + moneydps;




    }

}
    





