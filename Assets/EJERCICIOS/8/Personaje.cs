using System.Collections;
using System.Collections.Generic;
using Unity.Burst.Intrinsics;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    private arma arma;
    private sistemadevidas sistemadevidas;
    private string nombre;
    public float vida;
    private float experiencia;

    public float ataque;
    public float velocidad;
    
    public Personaje objetivo;

    [SerializeField]
    private KeyCode teclaCura = KeyCode.H;

    [SerializeField]
    private KeyCode teclaDisparo = KeyCode.Space;

    [SerializeField]
    private KeyCode teclaRecarga = KeyCode.R;

    public bool miTurno;

    // Referencias a otros componentes
    public Personaje enemigo;
    public sistemadevidas miSistemaDeVida;
    public arma miArma;

    // Start is called before the first frame update
    void Start()
    {
        sistemadevidas = GetComponent<sistemadevidas>();
        arma = GetComponentInChildren<arma>();

        if (miSistemaDeVida == null)
        {
            miSistemaDeVida = GetComponent<sistemadevidas>();
        }

        if (miArma == null)
        {
            miArma = GetComponentInChildren<arma>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (miTurno)
        {
            if (Input.GetKeyDown(teclaCura))
            {
                miSistemaDeVida.RecibirCura(10f);
                FinDeTurno();
            }

            if (Input.GetKeyDown(teclaDisparo))
            {
                float resultadoDisparo = miArma.Disparar();
                if (resultadoDisparo == 0)
                {
                    float danho = Random.Range(miArma.ObtenerDanhoMinimo(), miArma.ObtenerDanhoMaximo());
                    enemigo.miSistemaDeVida.RecibirDanho(danho);
                }
                else if (resultadoDisparo == -1)
                {
                    Debug.Log("Reload!!!");
                }
                FinDeTurno();
            }

            if (Input.GetKeyDown(teclaRecarga))
            {
                float resultadoRecarga = miArma.Recargar();
                if (resultadoRecarga == -1)
                {
                    Debug.Log("Arma ya cargada.");
                }
                FinDeTurno();
            }
        }
    }


    public void RellenarStats(float atq, float vel, float hp)
    {
        ataque = atq;
        velocidad = vel;
        vida = hp;
    }

    public void MarcarObjetivo(Personaje objetivo)
    {
        this.objetivo = objetivo;
    }

    public void Atacar()
    {
        if (objetivo != null)
        {
            objetivo.vida -= ataque;
            Debug.Log($"{this} ataca a {objetivo} y le causa {ataque} de daño. Vida restante del objetivo: {objetivo.vida}");
        }
    }

    public override string ToString()
    {
        return $"Personaje (Ataque: {ataque}, Velocidad: {velocidad}, Vida: {vida})";
    }

    private void FinDeTurno()
    {
        GameManager.Instance.FinDeTurno(this);
    }

    public Personaje(string nombre, float vida, float experiencia)
    {
        this.nombre = nombre;
        this.vida = vida;
        this.experiencia = experiencia;
    }

    public float CalcularNivel()
    {
        return experiencia / 1000f;
    }

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public float Vida
    {
        get { return vida; }
        set { vida = value; }
    }

    public float Experiencia
    {
        get { return experiencia; }
        set { experiencia = value; }
    }


}
