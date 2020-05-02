﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdgeController : MonoBehaviour {
    public float damage = 1f;
    public string attackedBy;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("trigger");
        string otherTag = other.gameObject.tag;
        if(attackedBy.Equals("Player") && otherTag.Equals("Enemy")) {
            // if(otherTag.Equals("Enemy")) {
                other.GetComponent<EnemyHealth>().addDamage(damage);
                gameObject.SetActive(false);
            // }
        }
        if(attackedBy.Equals("Enemy") && otherTag.Equals("Player")) {
            // if(otherTag.Equals("Player")) {
                other.GetComponent<PlayerHealth>().addDamage(damage);
                gameObject.SetActive(false);
            // }
        }
    }
}
