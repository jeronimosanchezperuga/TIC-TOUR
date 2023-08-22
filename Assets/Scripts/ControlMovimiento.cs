using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMovimiento : MonoBehaviour
{
    public float movementSpeed = 4;
    public float rotationSpeed = 200;
    public KeyCode teclaAvanzar =  KeyCode.W;
    public KeyCode teclaRetroceder = KeyCode.S;
    public KeyCode teclaGirarIzq = KeyCode.A;
    public KeyCode teclaGirarDer = KeyCode.D;


    void Update()
    {
        if (Input.GetKey(teclaAvanzar))
        {
            transform.Translate(0, 0, movementSpeed * Time.deltaTime);
        }
        if (Input.GetKey(teclaRetroceder))
        {
            transform.Translate(0, 0, -movementSpeed * Time.deltaTime);
        }
        
        if (Input.GetKey(teclaGirarDer))
        {
            transform.Rotate(0, rotationSpeed * Time.deltaTime,0);
        }
        if (Input.GetKey(teclaGirarIzq))
        {
            transform.Rotate(0, -rotationSpeed * Time.deltaTime, 0);
        }
    }
}
