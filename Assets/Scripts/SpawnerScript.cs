using TMPro;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SpawnerScript : MonoBehaviour
{
    [SerializeField]
    private GameObject pipePrefab;
    [SerializeField]
    private GameObject foodPrefab;
    [SerializeField]
    private GameObject fruitPrefab;



    private float pipeOffsetMax = 4.0f;
    private float foodOffsetMax = 3.0f;
    private float period = 1.5f;
    private float timeout;
    private float foodTimeout;

    static public int pipeCount = 0;
    static public int foodCount = 0;
    static public int fruitCount = 0;

    void Start()
    {
        timeout = 0f;
        foodTimeout = period * period;
        
    }

    void Update()
    {
        timeout -= Time.deltaTime;
        if (timeout <= 0)
        {
            timeout = period;
            SpawnPipe();
        }

        foodTimeout -= Time.deltaTime;
        if (foodTimeout <= 0)
        {
            foodTimeout = period;
            SpawnFood();
        }
    }

    private void SpawnPipe()
    {
        GameObject pipe = Instantiate(pipePrefab);
        pipe.transform.position = transform.position + Random.Range(-pipeOffsetMax, pipeOffsetMax) * Vector3.up;
        pipeCount++;
    }

    private void SpawnFood()
    {
        int rndFood = Random.Range(0, 4);
        GameObject food = null;

        switch (rndFood)
        {
            case 0:
                food = Instantiate(foodPrefab);
                foodCount++;
                break;
            case 1:
                food = Instantiate(fruitPrefab);
                fruitCount++;
                break;
        }

        if (food == null)
            return;

        food.transform.position = transform.position + Random.Range(-foodOffsetMax, foodOffsetMax) * Vector3.up;
        food.transform.Rotate(0, 0, Random.Range(0, 360));

    }

   
}
