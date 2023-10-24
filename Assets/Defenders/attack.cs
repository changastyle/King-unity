using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class attack : MonoBehaviour
{
    public float velocidadLanzamiento = 10.0f; // Velocidad de lanzamiento
    public float reloadTime = 1.0f; // Tiempo de recarga
    public float damage = 1.0f; // Daño que hace el ataque
    public int maxShots = 1; // Número máximo de disparos simultáneos

    public List<GameObject> targets; // Lista de disparadores


    // Update is called once per frame
    void Update()
    {
        // ManageShoters();
    }

    private void OnTriggerEnter(Collider other) {
        targets.Add(other.GameObject);
        
    }

    private void OnTriggerExit(Collider other) {
        
    }
}
