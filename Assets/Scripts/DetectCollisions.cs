using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "PlayerHostileProjectile")
        {
            Destroy(gameObject);
            Destroy(collider.gameObject);
        }
        else if (collider.tag == "Player")
        {
            Debug.Log("Enemy hit the player!");
        }
    }
}
