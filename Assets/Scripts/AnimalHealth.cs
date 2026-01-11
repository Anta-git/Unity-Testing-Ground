using UnityEngine;
using UnityEngine.UI;

public class AnimalHealth : MonoBehaviour
{
    [Header("Health")]
    public float maxHealth = 5f;
    public float currentHealth = 0f;

    [Header("UI")]
    public Image healthFill;
    public Canvas healthCanvas;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        healthCanvas = GetComponentInChildren<Canvas>();
        healthFill = healthCanvas.gameObject.GetComponentInChildren<Image>();
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
        
        healthFill.fillAmount = currentHealth / maxHealth;
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
