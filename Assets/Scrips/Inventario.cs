using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Inventario : MonoBehaviour
{
    //Script para almacenar los objetos

    public bool Vela = false;
    public bool Daga = false;
    public bool copa = false;

    private void Update()
    {
        if(Vela && Daga && copa)
        {
            SceneManager.LoadScene(0);
        }
    }
}
