using UnityEngine;

public class Script : MonoBehaviour
{
    public GameObject Object1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print("Hello, World!");
        Destroy(Object1);
        // Debug.Log("ooooo");
    }

    // Update is called once per frame
    void Update()
    {
        // print("Crickets");

    }
}
