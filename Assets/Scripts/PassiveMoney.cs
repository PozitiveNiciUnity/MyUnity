using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PassiveMoney : MonoBehaviour {



    public int a;

    public int b;

    public int c;

    private void Start()
    {
        StartCoroutine(PassiveMoneyIE());
    }

    private void Update()
    {
        a = CarClick.PassiveMoneyPerSecond;

        c = CarClick.Money;


               

       
    }

    public IEnumerator PassiveMoneyIE()
    {
        while (true)
        {

            c = c + a;

            yield return new WaitForSeconds(1);

            c = c + a;

            Debug.Log(c);

            CarClick.Money = c;
        }
    }






}
