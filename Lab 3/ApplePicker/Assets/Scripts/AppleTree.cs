using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    public GameObject apple;
    public float speed = 2f;
    public float leftAndRightEdge = 10f;
    public float chanceOfDirectionChange = 0.1f; // 10% change to change direction
    public float appleDropFrequency = 2; // 2 apples drop per second

    //private float FPS = 1f / Time.
    //private float speedInMPerFramel

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move
        // Check for direction change and change direction if neccessary.
        // Check for apple drop
    }

    private void FixedUpdate()
    {
        
    }
}
