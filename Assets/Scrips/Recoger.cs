using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recoger : MonoBehaviour
{
    public Inventario inventario;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            inventario = other.GetComponent<Inventario>();
            if(this.tag == "Copa")
            {
                inventario.copa = true;
                Destroy(gameObject);
            }
            if(this.tag == "Daga")
            {
                inventario.Daga = true;
                Destroy(gameObject);
            }
            inventario.Vela = true;
            Destroy(gameObject);
        }
    }
}
