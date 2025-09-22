
using UnityEngine;


public class Fruit : MonoBehaviour
{
    public float destroyDelay = 8f;

    void Start()
    {
        Destroy(gameObject, destroyDelay);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Sword"))
        {
            Debug.Log("Fruit Sliced");
            Destroy(gameObject);
        }
        else if (collision.gameObject.CompareTag("Floor"))
        {
            Debug.Log("Fruit Missed");
            Destroy(gameObject);
        }
    }
}

