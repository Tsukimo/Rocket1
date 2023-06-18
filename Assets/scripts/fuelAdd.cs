using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fuelAdd : MonoBehaviour
{
    private Fuelmanager _fuelManager;
    public fuelAdd(Fuelmanager Fuelmanager)
    {
        _fuelManager = Fuelmanager;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("lol");
            Destroy(gameObject);
            _fuelManager.fuelAdd = 25;
        }
    }
}
