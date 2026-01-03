using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player; // Reference to the player object
    public Vector3 offset = new Vector3(0, 5, -7); // Offset between the camera and the player

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    //LateUpdate is used here to prevent jittering issues when following objects moved during Update
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
