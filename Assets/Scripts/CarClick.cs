using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;


public class CarClick : MonoBehaviour
{

    public GameObject Car;

    public Text MoneyText;

    public static int Money = 0;

    public static int MoneyBonus = 0;

    public static int MoneyDPS = 1;

    public Text MoneyDPSText;

    public int MoneyClickStandart = 1;


    //Заставляет двигаться во время нажатия
    public void DownPointer()
    {
        Car.GetComponent<RectTransform>().sizeDelta = new Vector2(564, 258);
    }


    private void Start()
    {
        Money = PlayerPrefs.GetInt("Money");
        MoneyText.text = Money + "";

        PlayerPrefs.GetInt("MoneyBonus", MoneyBonus);
        MoneyBonus = PlayerPrefs.GetInt("MoneyBonus", MoneyBonus);

        PlayerPrefs.GetInt("MoneyDPS", MoneyDPS);
        MoneyDPS = PlayerPrefs.GetInt("MoneyDPS", MoneyDPS);




    }






    //Заставляет двигаться  после отпуска 
    public void UpPointer()
    {
        Car.GetComponent<RectTransform>().sizeDelta = new Vector2(613, 308);
    }


    public void OnClick()
    {

        Money = Money + MoneyBonus + 1;
        MoneyText.text = Money + " ";

        PlayerPrefs.SetInt("Money", Money);
        PlayerPrefs.SetInt("MoneyBonus", MoneyBonus);
        PlayerPrefs.SetInt("MoneyDPS", MoneyDPS);

    }



    public void Update()
    {
        int MoneyDps = MoneyBonus + MoneyClickStandart;
     
        MoneyDPSText.text = "Монеток за клик " + MoneyDps;

        MoneyText.text = Money + "";

        PlayerPrefs.SetInt("Money" , Money);
        PlayerPrefs.SetInt("MoneyBonus", MoneyBonus);
        PlayerPrefs.SetInt("MoneyDPS", MoneyDPS);


    }



}
