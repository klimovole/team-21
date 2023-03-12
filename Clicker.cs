using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clicker : MonoBehaviour
{
    public int money;
    public int moneyHondred;
    public Text textMoney;
    // Start is called before the first frame update
    void Start()
    {
        money = 0;
        moneyHondred = 0;
        textMoney.text = "Money: " + money;
    }

    // Update is called once per frame
    void Update()
    {
        textMoney.text = "Money: " + money;
        if (money > 999)
        {
            textMoney.text = "Money: " + money;
        }
    }

    public void Click()
    {
        money++;
    }
}
