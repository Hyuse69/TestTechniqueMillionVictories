using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;

public class BouttonBaseData : MonoBehaviour
{
    public static Data ContenuDatas;
    public TextAsset json;

    public GameObject boutonPrefab;

    private void Awake()
    {
        ContenuDatas = JsonUtility.FromJson<Data>("{\"ContenuDatas\":" + json.text + "}");
    }
    private void Start()
    {
        transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = json.name;
    }

    public void OnClick()
    {
        if (!transform.parent.GetChild(2).gameObject.activeSelf)
        {
            transform.parent.GetChild(2).gameObject.SetActive(true);
            transform.parent.GetChild(3).gameObject.SetActive(true);
            transform.parent.GetChild(4).gameObject.SetActive(true);
        }
        
        foreach (Transform i in transform.parent.GetChild(2).GetChild(0).GetChild(0))
        {
            //a corriger
            Destroy(i.gameObject);
        }

        foreach (var i in ContenuDatas.ContenuDatas)
        {
            GameObject obj = Instantiate(boutonPrefab);
            obj.transform.SetParent(transform.parent.GetChild(2).GetChild(0).GetChild(0));
            obj.AddComponent<BouttonTitre>();
            obj.GetComponent<BouttonTitre>().json = json;
            obj.GetComponent<Button>().onClick.AddListener(obj.GetComponent<BouttonTitre>().OnClick);
        }
    }
}
