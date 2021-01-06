using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement: MonoBehaviour
{
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveCam = speed * Input.GetAxis("Vertical") * Time.deltaTime;
        transform.Translate(0, 0, moveCam);

        float rotateCam = 0;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            --rotateCam;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            ++rotateCam;
        }
        transform.Rotate(0, rotateCam, 0);
    }
}
