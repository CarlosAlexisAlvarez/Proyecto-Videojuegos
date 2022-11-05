using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pinchos : MonoBehaviour
{

    public float tiempoEntreDa�o = 1f;
    private float tiempoSiguienteDa�o;

    //Metodo para da�ar al jugador
    private void OnTriggerStay(Collider other)
    {
        tiempoSiguienteDa�o -= Time.deltaTime;
        if (tiempoSiguienteDa�o <= 0)
        {
            other.GetComponent<Salud>().TomarDa�o(5);
            tiempoSiguienteDa�o = tiempoEntreDa�o;
        }
    }


}
