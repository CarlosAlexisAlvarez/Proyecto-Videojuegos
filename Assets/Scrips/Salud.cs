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

   //Metodo para da�ar al jugador
   public void TomarDa�o(int da�o)
    {
        vida -= da�o;
        if(vida <= 0)
        {
            this.transform.position = new Vector3(3.32f, 15.12f, 53.66f);
        }
    }
}
