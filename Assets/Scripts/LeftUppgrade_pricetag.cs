using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeftUppgrade_pricetag : MonoBehaviour
{

    public GameObject player;
    public Text text;
    public int num;

    // Update is called once per frame
    void Update()
    {
        if(num == 1)
        {
            text.text = "Price: " + player.GetComponent<Combat>().leftUppgradePrice;
        }else if(num == 2)
        {
            text.text = "Price: " + player.GetComponent<Combat>().middleUppgradePrice;
        }else if(num == 3)
        {
            text.text = "Price: " + player.GetComponent<Combat>().rightUppgradePrice;
        }
        
    }
}
