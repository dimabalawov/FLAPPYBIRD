using UnityEngine;

public class DestroyerScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.name);
        Transform parent = other.transform.parent;
        GameObject.Destroy(other.gameObject);
        if (parent != null)
        {
            GameObject.Destroy(parent.gameObject);
        }
    }
}
