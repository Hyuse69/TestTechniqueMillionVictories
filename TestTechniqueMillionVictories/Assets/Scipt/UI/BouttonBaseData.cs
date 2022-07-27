using TMPro;
using UnityEngine;
using Button = UnityEngine.UI.Button;

public class BouttonBaseData : MonoBehaviour
{
    public Data ContenuDatas;
    public TextAsset json;

    public GameObject boutonPrefab;
    private GameObject scrollView;
    private Transform scrollViewContentTransform;
    private GameObject content;
    private GameObject quit;

    private void Awake()
    {
        ContenuDatas = JsonUtility.FromJson<Data>("{\"ContenuDatas\":" + json.text + "}");
    }
    private void Start()
    {
        transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = json.name;
        scrollView = transform.parent.GetChild(2).gameObject;
        content = transform.parent.GetChild(3).gameObject;
        quit = transform.parent.GetChild(4).gameObject;
        scrollViewContentTransform = transform.parent.GetChild(2).GetChild(0).GetChild(0);
    }

    public void OnClick()
    {
        if (!scrollView.activeSelf)
        {
            scrollView.SetActive(true);
            content.SetActive(true);
            quit.SetActive(true);
        }

        content.GetComponent<TextMeshProUGUI>().text = "";
        
        foreach (Transform i in scrollViewContentTransform)
        {
            Destroy(i.gameObject);
        }
        
        foreach (var i in ContenuDatas.ContenuDatas)
        {
            GameObject obj = Instantiate(boutonPrefab);
            obj.transform.SetParent(scrollViewContentTransform);
            obj.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>().text = i.title;
            obj.AddComponent<BouttonTitre>();
            obj.GetComponent<BouttonTitre>().json = json;
            obj.GetComponent<Button>().onClick.AddListener(obj.GetComponent<BouttonTitre>().OnClick);
        }
    }
}
