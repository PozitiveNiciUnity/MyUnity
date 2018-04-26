using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattonMenu : MonoBehaviour {


    public GameObject panelmain;

    public GameObject panelshop;

    public GameObject paneltaxipark;

    public GameObject NoMoney;




    private void Start()
    {
        panelmain.SetActive(true);
        panelshop.SetActive(false);
        paneltaxipark.SetActive(false);
        NoMoney.SetActive(false);

    }


    public void ShopClick()
    {
        panelmain.SetActive(false);

        panelshop.SetActive(true);

        paneltaxipark.SetActive(false);

        NoMoney.SetActive(false);
    }

    public void MainClick()
    {
        panelmain.SetActive(true);

        panelshop.SetActive(false);

        paneltaxipark.SetActive(false);

        NoMoney.SetActive(false);
    }

    public void TaxiParkClick()
    {
        panelmain.SetActive(false);

        panelshop.SetActive(false);

        paneltaxipark.SetActive(true);

        NoMoney.SetActive(false);
    }
}
