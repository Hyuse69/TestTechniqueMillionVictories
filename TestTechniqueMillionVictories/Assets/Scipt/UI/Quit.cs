using TMPro;
using UnityEngine;

public class Quit : MonoBehaviour
{
    private GameObject scrollView;
    private Transform scrollViewContentTransform;
    private GameObject content;

    private void Awake()
    {
        scrollView = transform.parent.GetChild(2).gameObject;
        scrollViewContentTransform = transform.parent.GetChild(2).GetChild(0).GetChild(0);
        content = transform.parent.GetChild(3).gameObject;
    }

    public void OnClick()
    {
        content.GetComponent<TextMeshProUGUI>().text = "";
        content.SetActive(false);
        
        foreach (Transform i in scrollViewContentTransform)
        {
            Destroy(i.gameObject);
        }
        scrollView.SetActive(false);
        gameObject.SetActive(false);
    }
}
