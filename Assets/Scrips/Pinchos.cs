using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pinchos : MonoBehaviour
{

    public float tiempoEntreDaño = 1f;
    private float tiempoSiguienteDaño;

    //Metodo para dañar al jugador
    private void OnTriggerStay(Collider other)
    {
        tiempoSiguienteDaño -= Time.deltaTime;
        if (tiempoSiguienteDaño <= 0)
        {
            other.GetComponent<Salud>().TomarDaño(5);
            tiempoSiguienteDaño = tiempoEntreDaño;
        }
    }


}
