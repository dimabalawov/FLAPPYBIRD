using UnityEngine;

public class SpawnedScript : MonoBehaviour
{
    private TMPro.TextMeshProUGUI pipe;
    private float pipeCount;
    private float foodCount;
    private float fruitCount;
    void Start()
    {
        pipeCount = 0f;
        foodCount = 0f;
        fruitCount = 0f;
        pipe = GetComponent<TMPro.TextMeshProUGUI>();
    }

    void Update()
    {
        
    }
}
