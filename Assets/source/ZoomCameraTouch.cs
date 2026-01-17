using UnityEngine;

public class ZoomCameraTouch : MonoBehaviour
{
    public float velocidadeZoom = 0.5f;
    public float minZoom = 20f;
    public float maxZoom = 60f;

    private Camera cam;

    void Start()
    {
        cam = GetComponent<Camera>();
    }

    void Update()
    {
        // Detecta se há dois dedos na tela
        if (Input.touchCount == 2)
        {
            Touch toque1 = Input.GetTouch(0);
            Touch toque2 = Input.GetTouch(1);

            // Posições atuais e anteriores dos dedos
            Vector2 toque1Anterior = toque1.position - toque1.deltaPosition;
            Vector2 toque2Anterior = toque2.position - toque2.deltaPosition;

            float distanciaAnterior = (toque1Anterior - toque2Anterior).magnitude;
            float distanciaAtual = (toque1.position - toque2.position).magnitude;

            // Diferença entre as distâncias
            float diferenca = distanciaAnterior - distanciaAtual;

            // Aplica zoom
            cam.fieldOfView += diferenca * velocidadeZoom;
            cam.fieldOfView = Mathf.Clamp(cam.fieldOfView, minZoom, maxZoom);
        }
    }
}
