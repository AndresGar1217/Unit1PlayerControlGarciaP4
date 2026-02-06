using UnityEngine;

public class spinyay : MonoBehaviour
{
    public float spin;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * spin * Time.deltaTime);
    }
}
