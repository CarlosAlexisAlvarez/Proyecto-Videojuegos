using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salud : MonoBehaviour
{

    public int vida;
    public int maximoVida;

    // Start is called before the first frame update
    void Start()
    {

        vida = maximoVida;

    }

   //Metodo para dañar al jugador
   public void TomarDaño(int daño)
    {
        vida -= daño;
        if(vida <= 0)
        {
            Destroy(gameObject);
        }
    }
}
