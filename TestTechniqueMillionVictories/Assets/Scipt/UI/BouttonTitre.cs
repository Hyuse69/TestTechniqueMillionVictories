using TMPro;
using UnityEngine;

public class BouttonTitre : MonoBehaviour
{
    public static Data ContenuDatas;
    public TextAsset json;
    
    private GameObject content;
    
    private void Start()
    {
        ContenuDatas = JsonUtility.FromJson<Data>("{\"ContenuDatas\":" + json.text + "}");
        content = transform.parent.parent.parent.parent.GetChild(3).gameObject;
    }

    // Update is called once per frame
    public void OnClick()
    {
        content.GetComponent<TextMeshProUGUI>().text = "";
        content.GetComponent<TextMeshProUGUI>().text = ContenuDatas.ContenuDatas[transform.GetSiblingIndex()].content;
    }
}
