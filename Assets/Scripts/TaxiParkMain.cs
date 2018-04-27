using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaxiParkMain : MonoBehaviour {



    public Text TextFirstBuyPlace;

    public Text TextFirstBuyCar;

    public GameObject BattonFirstByuPlace;

    public GameObject BattonFirstByuCar;

    public GameObject BackGroundFirstByuPlace;

    public GameObject CarPanel;

    public GameObject UpLvlBatton;

    public GameObject NoMoney;

 


        public  void Start()
        {
            TextFirstBuyPlace.text = "Купить место под новую машину  Стоимость : 10000";

            TextFirstBuyCar.text = "Купить машину на это место Стоимость : 10000";

            BattonFirstByuCar.SetActive(false);

            BackGroundFirstByuPlace.SetActive(false);

            CarPanel.SetActive(false);

            UpLvlBatton.SetActive(false);
        }



    











    public void FirstBuyPlace()
    {
        if (CarClick.Money <= 100)
        {
            NoMoney.SetActive(true);
        }

        if (CarClick.Money >= 100)
        {
            CarClick.Money = CarClick.Money - 100;


            BattonFirstByuPlace.SetActive(false);

            BattonFirstByuCar.SetActive(true);

            BackGroundFirstByuPlace.SetActive(true);

        }

        

    }


    public void FirstBuyCar()
    {
        if (CarClick.Money <= 100)
        {
            NoMoney.SetActive(true);
        }

        if (CarClick.Money >= 100)
        {
            CarClick.Money = CarClick.Money - 100;


            BattonFirstByuPlace.SetActive(false);

            BattonFirstByuCar.SetActive(false);

            CarPanel.SetActive(true);

            UpLvlBatton.SetActive(true);
        }



    }
}
