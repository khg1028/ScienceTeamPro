using System;
using UnityEngine;

public class KTH_HealthSystem : MonoBehaviour
{
    [SerializeField]private int health;
    private int maxHealth;

    public Action OnDeath;
    public Action<int,int> OnHealthChange;
    
    private void Awake()
    {
        maxHealth = health;
    }

    public void TakeDamage(int damage)
    {
        health=Mathf.Max(health-damage,0);
        OnHealthChange?.Invoke(health,maxHealth);

        if (health <= 0)
        {
            OnDeath?.Invoke();
        }
    }

    public void Heal(int heal)
    {
        if(health==0)return;
        health=Mathf.Min(health+heal,maxHealth);
        OnHealthChange?.Invoke(health,maxHealth);
    }
}
