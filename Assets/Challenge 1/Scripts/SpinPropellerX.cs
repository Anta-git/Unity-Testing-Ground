using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 1000f; // Degrees per second - tweak in Inspector

    private void Update()
    {
        // Rotate around Y axis every frame - smooth across framerates
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }
}
