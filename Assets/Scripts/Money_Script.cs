using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money_Script : MonoBehaviour
{
    public int money;
    public Text moneyTxt;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        moneyTxt.text = money.ToString() + " Chash Money";
    }


}
