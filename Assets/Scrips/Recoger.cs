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
            if(this.tag == "Copa" && !inventario.copa)
            {
                inventario.copa = true;
                this.transform.position = new Vector3(-2.598f, 15.187f, 68.343f);
            }
            if(this.tag == "Daga" && !inventario.Daga)
            {
                inventario.Daga = true;
                this.transform.position = new Vector3(-4.2449f, 16.807f, 70.75f);
            }
            if (this.tag == "Vela" && !inventario.Vela)
            {
                inventario.Vela = true;
                this.transform.position = new Vector3(-1.297f, 16.53f, 69.843f);
            }
        }
    }
}
