using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public uint attack = 0;
    public uint defence = 0;
    public uint hp = 0;
    public float attackDelay = 1.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void InitCardData( uint valueAttack, uint valueDefence, uint valueHp, float valueDelay  )
    {
        attack = valueAttack;
        defence = valueDefence;
        hp = valueHp;
        attackDelay = valueDelay;
    }

    void Attack()
    {

    }
}
