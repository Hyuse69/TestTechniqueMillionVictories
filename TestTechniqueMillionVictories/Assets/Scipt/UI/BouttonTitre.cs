using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BouttonTitre : MonoBehaviour
{
    public static Data ContenuDatas;
    public TextAsset json;
    
    private void Start()
    {
        ContenuDatas = JsonUtility.FromJson<Data>("{\"ContenuDatas\":" + json.text + "}");
        Debug.Log(transform.GetSiblingIndex());
        transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = ContenuDatas.ContenuDatas[transform.GetSiblingIndex()].title;
    }

    // Update is called once per frame
    public void OnClick()
    {
        transform.parent.parent.parent.parent.GetChild(3).gameObject.GetComponent<TextMeshProUGUI>().text = "";
        transform.parent.parent.parent.parent.GetChild(3).gameObject.GetComponent<TextMeshProUGUI>().text = ContenuDatas.ContenuDatas[transform.GetSiblingIndex()].content;
    }
}
