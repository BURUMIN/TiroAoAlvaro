using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorDeMoeda : MonoBehaviour
{
    public CircleCollider2D Collider2D;
    public GameObject Particula;
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            Pontuacao pontos = other.GetComponent<Pontuacao>();
            pontos.AddPoint();
            Destroy(this.gameObject);
            Instantiate (
                Particula,
                this.transform.position,
                Quaternion.Euler(0,0,0)
            );
        }
    }
}
