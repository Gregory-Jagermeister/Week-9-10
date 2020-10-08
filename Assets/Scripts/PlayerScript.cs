using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed = 10;

    private float xSpeed;
    private float ySpeed;

    void Start()
    {
        xSpeed = speed;
        ySpeed = speed;
    }

    
    void Update()
    {
        // Movement Left and Right
        float xTranslation = Input.GetAxis("Horizontal") * xSpeed;
        xTranslation *= Time.deltaTime;   
        transform.Translate (xTranslation, 0, 0);

        // Movement Up and Down
        float yTranslation = Input.GetAxis("Vertical") * ySpeed;
        yTranslation *= Time.deltaTime;
        transform.Translate (0, yTranslation, 0);
    }
}
