using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private GameManager gameManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "PlayerHostileProjectile")
        {
            gameManager.AddScore(1);
            Destroy(gameObject);
            Destroy(collider.gameObject);
        }
        else if (collider.tag == "Player")
        {
            gameManager.removeLives(1);
            Debug.Log("Enemy hit the player!");
        }
    }
}
