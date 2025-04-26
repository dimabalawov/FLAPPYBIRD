using UnityEngine;

public class BirdScript : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField]
    private float maxforce = 600f;
    [SerializeField]
    private float minforce = 250f;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * maxforce);
        }
    }
}
