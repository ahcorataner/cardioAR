using UnityEngine;

public class BotaoEntrar : MonoBehaviour
{
    public GameObject telaEntrada;
    public GameObject telaInicial;

    public void Entrar()
    {
        telaEntrada.SetActive(false);
        telaInicial.SetActive(true);
    }
}
