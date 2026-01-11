using UnityEngine;
using UnityEngine.UI;

public class AnimalHealth : MonoBehaviour
{
    private GameManager gameManager;

    [Header("Health")]
    public float maxHealth = 5f;
    public float currentHealth = 0f;

    [Header("UI")]
    public Slider healthSlider;
    public Canvas healthCanvas;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        healthSlider.maxValue = maxHealth;
        healthSlider.value = currentHealth;
        healthSlider.fillRect.gameObject.SetActive(false);
        healthCanvas = GetComponentInChildren<Canvas>();
        UpdateHealthBar();
    }

    // Update is called once per frame
    void Update()
    {
        //Always faces the camera
        if(healthCanvas)
        {
            healthCanvas.transform.LookAt(Camera.main.transform);
        }
    }

    private void UpdateHealthBar()
    {
        healthSlider.fillRect.gameObject.SetActive(true);
        healthSlider.value = currentHealth;
    }

    public void HealAnimal(float amount)
    {
        currentHealth += amount;
        if(currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        UpdateHealthBar();
    }
}
