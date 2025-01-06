using UnityEngine;

public class Pickup : MonoBehaviour
{
    public float speed = 360;
    public AudioClip clink;
    public GameScore score;

    void Start()
    {
        score.AddCoin();
    }

    void Update()
    {
        transform.Rotate(0, speed * Time.deltaTime, 0, Space.World);
    }

    void OnTriggerEnter(Collider other)
    {
        gameObject.SetActive(false);
        Cat cat = other.GetComponent<Cat>();
        if (cat != null)
        {
           AudioSource.PlayClipAtPoint(clink, Camera.main.transform.position);
           cat.CollectCoin();
           gameObject.SetActive(false);
        }
    }
}
