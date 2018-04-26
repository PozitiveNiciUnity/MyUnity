using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickFirstBattonClicc : MonoBehaviour {

    public GameObject NoMoney ;

    public Text textcost1;

    public static int costshop1 = 20;
    
    public static int multipliershop1 = 3;

   

    // Use this for initialization
    void Start () {
        NoMoney.SetActive(false);
   
    }





    // Update is called once per frame
    void Update () {
       
    }
    

    public void EscNoMoney()
    {
        NoMoney.SetActive(false);
    }



    public void Shopbattonone()
    {
        if (CarClick.money <= costshop1 )
        {
            NoMoney.SetActive(true);
        }

        if (CarClick.money >= costshop1)
        {
            CarClick.moneyBonus = CarClick.moneyBonus + multipliershop1;

            CarClick.money = CarClick.money - costshop1;

            costshop1 = costshop1 * 2;

            textcost1.text = "Прибавится к клику " +"" + multipliershop1 + "\n" + "Стоимость :" + "" + costshop1;
        }

       

    }

  



}
