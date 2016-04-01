using UnityEngine;
using System.Collections;

public class PlayerDeath : MonoBehaviour
{

    [HideInInspector]
    public bool isDeath;

    public void OnDeath()
    {
        isDeath = true;
        if (isDeath)
        {

        }
    }
}
