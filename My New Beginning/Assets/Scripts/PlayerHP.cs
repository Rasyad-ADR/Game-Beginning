using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{

    public int hpNow;
    public int maxHp;

    public void ChangeHealth(int amount)
    {
        hpNow += amount;

        if (hpNow <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
