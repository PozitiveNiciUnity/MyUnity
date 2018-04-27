
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopLogicBatton : MonoBehaviour
{

    public GameObject NoMoney;

    public  Text TextCost1;

    public static int CostShop1 = 20;

    public static int MultiplierShop1 = 1;

    public  Text TextCost2;

    public static int CostShop2 = 4000;

    public static int MultiplierShop2 = 10;


    public Text TextCost3;

    public static int CostShop3 = 100000;

    public static int MultiplierShop3 = 50;


    public Text TextCost4;

    public static int CostShop4 = 50000;

    public static int MultiplierShop4 = 2;


  

    void Start()
    {
        PlayerPrefs.GetInt("CostShop1", CostShop1);
        CostShop1 = PlayerPrefs.GetInt("CostShop1", CostShop1);

        PlayerPrefs.GetInt("MultiplierShop1", MultiplierShop1);
        MultiplierShop1 = PlayerPrefs.GetInt("MultiplierShop1", MultiplierShop1);




        PlayerPrefs.GetInt("CostShop2", CostShop2);
        CostShop2 = PlayerPrefs.GetInt("CostShop2", CostShop2);

        PlayerPrefs.GetInt("MultiplierShop2", MultiplierShop2);
        MultiplierShop2 = PlayerPrefs.GetInt("MultiplierShop2", MultiplierShop2);



        PlayerPrefs.GetInt("CostShop3", CostShop3);
        CostShop3 = PlayerPrefs.GetInt("CostShop3", CostShop3);

        PlayerPrefs.GetInt("MultiplierShop3", MultiplierShop3);
        MultiplierShop3 = PlayerPrefs.GetInt("MultiplierShop3", MultiplierShop3);



        PlayerPrefs.GetInt("CostShop4", CostShop4);
        CostShop4 = PlayerPrefs.GetInt("CostShop4", CostShop4);

        PlayerPrefs.GetInt("MultiplierShop4", MultiplierShop4);
        MultiplierShop4 = PlayerPrefs.GetInt("MultiplierShop4", MultiplierShop4);



       




        TextCost1.text = ("Прибавится к клику " + "" + MultiplierShop1 + "\n" + "Стоимость :" + "" + CostShop1);

        TextCost2.text = ("Прибавится к клику " + "" + MultiplierShop2 + "\n" + "Стоимость :" + "" + CostShop2);

        TextCost3.text = ("Прибавится к клику " + "" + MultiplierShop3 + "\n" + "Стоимость :" + "" + CostShop3);

        TextCost4.text = ("Удвоение прибыли с нитро x " + "" + MultiplierShop4 + "\n" + "Стоимость :" + "" + CostShop4);




    }







    public  void ESCNoMoney()
    {
        NoMoney.SetActive(false);
    }



    public void ShopBattonOne()
    {
        if (CarClick.Money < CostShop1)
        {
            NoMoney.SetActive(true);
        }

        if (CarClick.Money >= CostShop1)
        {

            CarClick.MoneyBonus = CarClick.MoneyBonus + MultiplierShop1;

            CarClick.Money = CarClick.Money - CostShop1;

            CostShop1 = CostShop1 * 2;

            PlayerPrefs.SetInt("CostShop1", CostShop1);

            PlayerPrefs.SetInt("MultiplierShop1", MultiplierShop1);




            TextCost1.text = "Прибавится к клику " + "" + MultiplierShop1 + "\n" + "Стоимость :" + "" + CostShop1;
        }
        
    }






    public void ShopBattonTwo()
    {
        if (CarClick.Money <= CostShop2)
        {
            NoMoney.SetActive(true);
        }

        if (CarClick.Money >= CostShop2)
        {
            CarClick.MoneyBonus = CarClick.MoneyBonus + MultiplierShop2;

            CarClick.Money = CarClick.Money - CostShop2;

            CostShop2 = CostShop2 * 2;

            PlayerPrefs.SetInt("MultiplierShop2", MultiplierShop2);

            PlayerPrefs.SetInt("CostShop2", CostShop2);


            TextCost2.text = "Прибавится к клику " + "" + MultiplierShop2 + "\n" + "Стоимость :" + "" + CostShop2;
        }



    }



    public void ShopBattonThree()
    {
        if (CarClick.Money <= CostShop3)
        {
            NoMoney.SetActive(true);
        }

        if (CarClick.Money >= CostShop3)
        {
            CarClick.MoneyBonus = CarClick.MoneyBonus + MultiplierShop3;

            CarClick.Money = CarClick.Money - CostShop3;

            CostShop3 = CostShop3 * 2;

            PlayerPrefs.SetInt("MultiplierShop3", MultiplierShop3);

            PlayerPrefs.SetInt("CostShop3", CostShop3);

            TextCost3.text = "Прибавится к клику " + "" + MultiplierShop3 + "\n" + "Стоимость :" + "" + CostShop3;
        }



    }


    public void ShopBattonFour()
    {
        if (CarClick.Money <= CostShop4)
        {
            NoMoney.SetActive(true);
        }

        if (CarClick.Money >= CostShop4)
        {
            CarClick.NitroBonus = CarClick.NitroBonus * MultiplierShop4;

            CarClick.Money = CarClick.Money - CostShop4;

            CostShop4 = CostShop4 * 2;

            PlayerPrefs.SetInt("MultiplierShop4", MultiplierShop4);

            PlayerPrefs.SetInt("CostShop4", CostShop4);

            TextCost4.text = "Удвоение прибыли с нитро " + "" + MultiplierShop4 + "\n" + "Стоимость :" + "" + CostShop4;
        }



    }
    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////SAVE/////////////////////////////////////////////////////
    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////




    void FixedUpdate()
    {
        PlayerPrefs.SetInt("MultiplierShop1", MultiplierShop1);
        PlayerPrefs.SetInt("CostShop1", CostShop1);



        PlayerPrefs.SetInt("MultiplierShop2", MultiplierShop2);
        PlayerPrefs.SetInt("CostShop2", CostShop2);


        PlayerPrefs.SetInt("MultiplierShop3", MultiplierShop3);
        PlayerPrefs.SetInt("CostShop3", CostShop3);







    }



}