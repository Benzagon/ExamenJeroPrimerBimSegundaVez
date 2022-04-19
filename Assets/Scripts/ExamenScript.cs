using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExamenScript : MonoBehaviour
{
    public string codigoGusto;
    public float gramos;

    void Start()
    {
        if (gramos < 250 || gramos > 3000)
        {
            Debug.Log("Porfavor ingrese una cantidad de gramos válida");
        }
        else
        {
            float monto = gramos / 1000 * 500;

            switch (codigoGusto)
            {
                case "CHO":
                    Debug.Log("El monto total del Chocolate es de $" + monto);
                    break;

                case "DDL":
                    Debug.Log("El monto total del Dulce de Leche es de $" + monto);
                    break;

                case "FRU":
                    Debug.Log("El monto total de la Frutilla es de $" + (monto - (monto / 100 * 10)));
                    break;

                default:
                    Debug.Log("Porfavor ingrese un código de gusto válido");
                    break;
            }
        }
    }
}
