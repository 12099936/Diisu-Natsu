using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{

    public float curHealth;
    public float maxHealth;

    public Slider healthBar;
    // Start is called before the first frame update
    void Start()
    {
        curHealth = maxHealth;
        healthBar.value = curHealth;
        healthBar.maxValue = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {

            SendDamage(Random.Range(10, 2));
        }
    }

    public void SendDamage(float damageValue)
    {
        curHealth -= damageValue;
        healthBar.value = curHealth;
    }
}
