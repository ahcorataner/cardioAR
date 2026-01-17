using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class BotaoARSimples : MonoBehaviour
{
    public ARCameraBackground arBackground;

    private bool arLigado = false;

    void Start()
    {
        if (arBackground != null)
            arBackground.enabled = false; // começa desligado
    }

    public void ToggleAR()
    {
        if (arBackground == null) return;

        arLigado = !arLigado;
        arBackground.enabled = arLigado;
    }
}

