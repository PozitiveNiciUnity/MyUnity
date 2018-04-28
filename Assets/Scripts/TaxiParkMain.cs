using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaxiParkMain : MonoBehaviour {

    public static int DPSMoney;

    public Text TextFirstBuyPlace;

    public Text TextFirstBuyCar;

    public Text TextFirstUpCar;

    public GameObject BattonFirstByuPlace;

    public GameObject BattonFirstByuCar;

    public GameObject BackGroundFirstByuPlace;

    public GameObject CarPanel;

    public GameObject UpLvlBatton;

    public GameObject NoMoney;

    public static int MultiplierCar1 = 10;

    public static int herna;

    public int CostUp1 = 1000;

    public  void Start()
        {

            DPSMoney = PlayerPrefs.GetInt("DPSMoney", DPSMoney);
      
        

            MultiplierCar1 = PlayerPrefs.GetInt("MultiplierCar1", MultiplierCar1);
       


            herna = PlayerPrefs.GetInt("herna", herna);



            CostUp1 = PlayerPrefs.GetInt("CostUp1", CostUp1);




            TextFirstBuyPlace.text = "Купить место под новую машину  Стоимость : 1000";

            TextFirstBuyCar.text = "Купить машину на это место Стоимость : 1000";

            TextFirstUpCar.text = "Улучшить машину " + "Стоимость :" + CostUp1;


            BattonFirstByuCar.SetActive(true);

            BackGroundFirstByuPlace.SetActive(false);

            CarPanel.SetActive(false);

            UpLvlBatton.SetActive(false);

        DPSMoney = DPSMoney + MultiplierCar1;

    }


   
        void FixedUpdate()
    {
        PlayerPrefs.SetInt("DPSMoney", DPSMoney);
        PlayerPrefs.SetInt("MultiplierCar1", MultiplierCar1);
        PlayerPrefs.SetInt("herna", herna);
        PlayerPrefs.SetInt("CostUp1", CostUp1);
       
    }

    


   








    public void FirstBuyPlace()
    {
        if (CarClick.Money < 1000)
        {
            NoMoney.SetActive(true);
        }

        if (CarClick.Money >= 1000)
        {

            BattonFirstByuPlace.SetActive(false);

            BattonFirstByuCar.SetActive(true);

            BackGroundFirstByuPlace.SetActive(true);

            CarClick.Money = CarClick.Money - 1000;


            BattonFirstByuPlace.SetActive(false);

            BattonFirstByuCar.SetActive(true);

            BackGroundFirstByuPlace.SetActive(true);

        }

        

    }


    public void FirstBuyCar()
    {
        if (CarClick.Money < 1000)
        {
            NoMoney.SetActive(true);
        }

        if (CarClick.Money >= 1000)
        {
            CarClick.Money = CarClick.Money - 1000;

           

            CarClick.PassiveMoneyPerSecond = CarClick.PassiveMoneyPerSecond + MultiplierCar1;

            

            BattonFirstByuCar.SetActive(false);

            CarPanel.SetActive(true);

            UpLvlBatton.SetActive(true);

            BackGroundFirstByuPlace.SetActive(true);


            herna = herna + MultiplierCar1;


            DPSMoney = DPSMoney + MultiplierCar1;
        }

        






    }

    public void UpLvl()
    {

        if (CarClick.Money < CostUp1)
        {
            NoMoney.SetActive(true);
        }

        if (CarClick.Money >= CostUp1)
        {
            CarClick.Money = CarClick.Money - CostUp1;


            CarClick.PassiveMoneyPerSecond = CarClick.PassiveMoneyPerSecond + MultiplierCar1;


            CostUp1 = CostUp1 * 2;

            TextFirstUpCar.text = "Улучшить машину " +  "Стоимость :" + CostUp1;


            DPSMoney = DPSMoney + MultiplierCar1;



        }




        
    }



}
