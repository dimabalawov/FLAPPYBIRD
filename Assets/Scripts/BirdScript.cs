using Unity.VisualScripting;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField]
    private float maxforce = 600f;
    [SerializeField]
    private float minforce = 250f;

    public static float health;

    private float healthTimeout = 100.0f; //100 sec

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        health = 1.0f;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * maxforce);
        }

        health -= Time.deltaTime / healthTimeout;
        this.transform.eulerAngles = new Vector3(0, 0, 3f*rb.linearVelocityY);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.tag);
        if (collision.CompareTag("Food"))
        {
            GameObject.Destroy(collision.gameObject);
            health = Mathf.Clamp01(health + 10f / healthTimeout);
            Debug.Log(health);
        }
        else if (collision.CompareTag("Fruit"))
        {
            GameObject.Destroy(collision.gameObject);
            health = Mathf.Clamp01(health + 15f / healthTimeout);
            Debug.Log(health);
        }
        else if (collision.CompareTag("Pipe"))
        {
            AlertScript.Show("FAIL", "You just hit an obstacle", "Try again");
        }
    }
}
