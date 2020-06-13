using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class UIMoney : MonoBehaviour
{
    private static int money;
    [SerializeField]
    public Text moneyText;

    // Update is called once per frame
    void Update()
    {
        money = DestroyObjectOnCollision.money;
        moneyText.text = "Monety: " + money;
    }
}
