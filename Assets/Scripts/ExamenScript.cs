using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExamenScript : MonoBehaviour
{
    public string codGusto;
    public float gramos;

    void Start()
    {
        if (gramos < 250 || gramos > 3000)
        {
            Debug.Log("Porfavor ingrese una cantidad de gramos válida");
        }
        else
        {
            switch (codGusto)
            {
                case "CHO":
                    Debug.Log("El monto total es de $"+ gramos / 1000 * 500);
                    break;

                case "DDL":
                    Debug.Log("El monto totat es de $" + gramos / 1000 * 500);
                    break;

                case "FRU":
                    float monto = gramos / 1000 * 500;
                    Debug.Log("El monto totat es de $" + (monto - (monto / 100 * 10)));
                    break;

                default:
                    Debug.Log("Porfavor ingrese un código de gusto válido");
                    break;
            }
        }
    }
      
}
