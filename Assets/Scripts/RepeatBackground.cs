using UnityEngine;
using UnityEngine.UIElements;

public class RepeatBackground : MonoBehaviour
{
    private float repeatwidth = 56.4f;
    private Vector3 startPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    
   
    { if (transform.position.x < startPos.x - repeatwidth)
            transform.position = startPos;
    }
}