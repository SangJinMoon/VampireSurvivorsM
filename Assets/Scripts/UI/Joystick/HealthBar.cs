using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField]
    private Slider hpBar;

    private float maxHp = 100f;
    private float curHp = 100f;
    
    // Start is called before the first frame update
    void Start()
    {
        hpBar.value = (float)curHp / (float)maxHp;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            curHp -= 10;
        }
        HandleHp();
    }
    private void HandleHp()
    {
        hpBar.value = (float)curHp / (float)maxHp;

    }
}
