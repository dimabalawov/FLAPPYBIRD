using System.Security.Cryptography;
using UnityEngine;

public class AlertScript : MonoBehaviour
{
    private static TMPro.TextMeshProUGUI title;
    private static TMPro.TextMeshProUGUI message;
    private static TMPro.TextMeshProUGUI button;
    private static GameObject content;

    public static void Show(string t, string m, string b)
    {
        AlertScript.title.text = t;
        AlertScript.message.text = m;
        AlertScript.button.text = b;
        content.SetActive(true);
        Time.timeScale = 0.0f;
    }
    void Start()
    {
        Transform c = transform.Find("Content");
        title = c.Find("Title").GetComponent<TMPro.TextMeshProUGUI>();
        message = c.Find("Message").GetComponent<TMPro.TextMeshProUGUI>();
        button = c.Find("Button/Text").GetComponent<TMPro.TextMeshProUGUI>();
        content = c.gameObject;
        content.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OnActionButtonClick();
        }
    }

    public void OnActionButtonClick()
    {
        content.SetActive(false);
        Time.timeScale = 1.0f;
    }
}
