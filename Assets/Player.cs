
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private PlayerInput playerInput;
    [SerializeField] private float velocidad;

    private Vector2 direccionDeInput;
    Transform jugador;
    
    void Start()
    {
        jugador = GetComponent<Transform>();


    }
    public void OnMoverse (InputValue valor)
    {
       direccionDeInput = (Vector2)valor.Get();
    }
    private void Update()
    {
        Mover();
    }
    private void Mover()
    {
        jugador.Translate(Vector3.right * this.direccionDeInput.x * Time.deltaTime * this.velocidad, Space.Self);
        jugador.Translate(Vector3.up * this.direccionDeInput.y * Time.deltaTime * this.velocidad, Space.Self);
     
        
    }


}
