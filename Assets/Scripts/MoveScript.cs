using UnityEngine;

public class MoveScript : MonoBehaviour
{
    [SerializeField]
    private float maxspeed = 7f;
    [SerializeField]
    private float minspeed = 1.5f;

    void Update()
    {
        this.transform.Translate(maxspeed * Time.deltaTime * Vector3.left);
    }
}
