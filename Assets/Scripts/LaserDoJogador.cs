using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserDoJogador : MonoBehaviour
{
    public GameObject impactoDoLaserDoJogador;

    public float velocidadeDoLaser;
    public int danoParaDar;

    void Update()
    {
        MovimentarLaser();
    }

    private void MovimentarLaser()
    {
        // Move o laser SEM depender da rotação — sempre para a direita
        transform.Translate(Vector3.right * velocidadeDoLaser * Time.deltaTime, Space.World);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Inimigo"))
        {
            // O inimigo recebe dano
            other.gameObject.GetComponent<Inimigos>().MachucarInimigo(danoParaDar);

            // Cria efeito visual do impacto
            Instantiate(impactoDoLaserDoJogador, transform.position, transform.rotation);

            // Som do impacto
            EfeitosSonoros.instance.somDeImpacto.Play();

            // Remove o laser
            Destroy(this.gameObject);
        }
    }
}