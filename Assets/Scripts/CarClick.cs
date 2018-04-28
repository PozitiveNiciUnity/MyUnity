using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;


public class CarClick : MonoBehaviour
{
   

    public static int PassiveMoneyPerSecond = 0;


    public GameObject Car;

    public Slider SliderBonus;

    public Text MoneyText;

    public Text DPSMoneyText;

    public static int Money = 0;

    public static int MoneyBonus = 0;

    public static int MoneyDPS = 1;

    public Text MoneyDPSText;

    public int MoneyClickStandart = 1;

    public int SlideBonusValue = 1;

    public static int NitroBonus = 100;
    //Заставляет двигаться во время нажатия
    public void DownPointer()
    {
        Car.GetComponent<RectTransform>().sizeDelta = new Vector2(564, 258);
    }


    private void Start()
    {
        Money = PlayerPrefs.GetInt("Money");
        MoneyText.text = Money + "";

        PlayerPrefs.GetInt("MoneyBonus");
        MoneyBonus = PlayerPrefs.GetInt("MoneyBonus");

        PlayerPrefs.GetInt("MoneyClickStandart");
        MoneyClickStandart = PlayerPrefs.GetInt("MoneyClickStandart");

       

        

        PlayerPrefs.GetInt("PassiveMoneyPerSecond");
        PassiveMoneyPerSecond = PlayerPrefs.GetInt("PassiveMoneyPerSecond");

   

        SlideBonusValue = 1;

    
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

        SlideBonusValue++;


        SliderBonus.value = (SlideBonusValue);






        PlayerPrefs.SetInt("Money", Money);
        PlayerPrefs.SetInt("MoneyBonus", MoneyBonus);
        PlayerPrefs.SetInt("MoneyClickStandart", MoneyClickStandart);
        
    
        PlayerPrefs.SetInt("PassiveMoneyPerSecond", PassiveMoneyPerSecond);
       






    }



    public void Update()
    {
        int MoneyDps = MoneyBonus + MoneyClickStandart;
     
        MoneyDPSText.text = "Монеток за клик " + MoneyDps;

        MoneyText.text = Money + "";

        DPSMoneyText.text = "Монеток в с. " + PassiveMoneyPerSecond;







        if (SlideBonusValue == 100)
        {

            Money = Money + NitroBonus;

            SlideBonusValue = SlideBonusValue - 99;
        }


       




        PlayerPrefs.SetInt("Money" , Money);
        PlayerPrefs.SetInt("MoneyBonus", MoneyBonus);
        PlayerPrefs.SetInt("MoneyClickStandart", MoneyClickStandart);
       
     
        PlayerPrefs.SetInt("PassiveMoneyPerSecond", PassiveMoneyPerSecond);
   

    }



}
