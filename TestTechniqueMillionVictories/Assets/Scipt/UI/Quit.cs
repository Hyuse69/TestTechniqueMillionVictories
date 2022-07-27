using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Quit : MonoBehaviour
{
    public void OnClick()
    {
        transform.parent.GetChild(3).GetComponent<TextMeshProUGUI>().text = "";
        transform.parent.GetChild(3).gameObject.SetActive(false);
        
        foreach (Transform i in transform.parent.GetChild(2).GetChild(0).GetChild(0))
        {
            Destroy(i.gameObject);
        }
        transform.parent.GetChild(2).gameObject.SetActive(false);
        gameObject.SetActive(false);
    }
}
