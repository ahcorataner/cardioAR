using UnityEngine;

public class BotaoEstudo : MonoBehaviour
{
    public GameObject telaInicial;
    public GameObject telaEstudo;
    public GameObject painelInfo; // ← painel lateral

    public void AbrirEstudo()
    {
        telaInicial.SetActive(false);
        telaEstudo.SetActive(true);

        if (painelInfo != null)
            painelInfo.SetActive(false); // ESCONDE painel lateral
    }

    public void Voltar()
    {
        telaEstudo.SetActive(false);
        telaInicial.SetActive(true);
    }
}
