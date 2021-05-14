using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Player;
    public float minXClamp;
    public float maxXClamp;
    public float minYClamp;
    public float maxYClamp;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Player)
        {
            //create a variable to store the camera's x, y and z position
            Vector3 cameraTransform;

            //take my position values and put them in the variable
            cameraTransform = transform.position;

            cameraTransform.x = Player.transform.position.x - 0.5f;
            cameraTransform.x = Mathf.Clamp(cameraTransform.x, minXClamp, maxXClamp);
            cameraTransform.y = Player.transform.position.y - 0.5f;
            cameraTransform.y = Mathf.Clamp(cameraTransform.y, minYClamp, maxYClamp);
            transform.position = cameraTransform;
        }
    }
}
