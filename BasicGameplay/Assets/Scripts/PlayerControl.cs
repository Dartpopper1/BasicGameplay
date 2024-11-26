using Unity.VisualScripting;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float horizontailInput;
    public float speed = 10.0f;
    public float xRange = 10.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        horizontailInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontailInput * Time.deltaTime * speed);
    }
}
