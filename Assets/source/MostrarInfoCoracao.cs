using UnityEngine;
using TMPro;

public class MostrarInfoCoracao : MonoBehaviour
{
    public GameObject panelInfo;
    public TextMeshProUGUI textoInfo;
    [TextArea] public string descricao;
    public Color corDestaque = Color.yellow;

    private Color corOriginal;
    private Renderer rend;

    // 🔴 REFERÊNCIA GLOBAL (a parte atualmente selecionada)
    private static MostrarInfoCoracao parteSelecionadaAtual;

    void Start()
    {
        rend = GetComponent<Renderer>();
        if (rend != null)
            corOriginal = rend.material.color;
    }

    void OnMouseDown()
    {
        // 🔁 Se outra parte estava selecionada, desativa ela
        if (parteSelecionadaAtual != null && parteSelecionadaAtual != this)
        {
            parteSelecionadaAtual.Deselecionar();
        }

        // 👉 Seleciona esta parte
        Selecionar();
        parteSelecionadaAtual = this;
    }

    void Selecionar()
    {
        if (rend != null)
            rend.material.color = corDestaque;

        if (panelInfo != null && textoInfo != null)
        {
            panelInfo.SetActive(true);
            textoInfo.text = descricao;
        }
    }

    public void Deselecionar()
    {
        if (rend != null)
            rend.material.color = corOriginal;

        if (panelInfo != null)
            panelInfo.SetActive(false);
    }
}
