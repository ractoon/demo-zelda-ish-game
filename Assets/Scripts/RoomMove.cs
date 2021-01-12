using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomMove : MonoBehaviour
{
    public Vector2 cameraChangeMin;
    public Vector2 cameraChangeMax;
    public Vector3 playerChange;
    private CameraMovement cam;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main.GetComponent<CameraMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Player") {
            cam.minPosition.x = cameraChangeMin.x;
            cam.maxPosition.x = cameraChangeMax.x;
            cam.minPosition.y = cameraChangeMin.y;
            cam.maxPosition.y = cameraChangeMax.y;
            other.transform.position += playerChange;
        }
    }
}
