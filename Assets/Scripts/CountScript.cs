using TMPro;
using UnityEngine;

public class CountScript : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI pipeCountText;
    [SerializeField] private TextMeshProUGUI foodCountText;
    [SerializeField] private TextMeshProUGUI fruitCountText;
    void Start()
    {
        
    }

    void Update()
    {
        pipeCountText.text = $"{SpawnerScript.pipeCount}";
        foodCountText.text =$"{SpawnerScript.foodCount}";
        fruitCountText.text = $"{SpawnerScript.fruitCount}";
    }
}
