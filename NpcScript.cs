using UnityEngine;

public class NpcScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int Health = 5;
    public int Level = 1;
    public float Speed = 1.2f;

    void Start()
    {
        Health += Level;
        print(Health);

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += Speed * Time.deltaTime;
        transform.position = newPosition;

    }
}
