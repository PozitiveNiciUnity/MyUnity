
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopLogicBatton : MonoBehaviour
{

    public GameObject NoMoney;

    public  Text TextCost1;

    public static int CostShop1 = 20;

    public static int MultiplierShop1 = 3;

    public  Text TextCost2;

    public static int CostShop2 = 2000;

    public static int MultiplierShop2 = 20;


    public Text TextCost3;

    public static int CostShop3 = 500;

    public static int MultiplierShop3 = 100;



    // Use this for initialization
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








        TextCost1.text = ("Прибавится к клику " + "" + MultiplierShop1 + "\n" + "Стоимость :" + "" + CostShop1);

        TextCost2.text = ("Прибавится к клику " + "" + MultiplierShop2 + "\n" + "Стоимость :" + "" + CostShop2);

        TextCost3.text = ("Прибавится к клику " + "" + MultiplierShop3 + "\n" + "Стоимость :" + "" + CostShop3);

    }




    // Update is called once per frame



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