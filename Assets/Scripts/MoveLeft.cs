using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 15.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.Translate(Vector3.left * Time.deltaTime * speed); 
       transform.Translate(Vector3.left * Time.deltaTime * speed); 
    }
}
