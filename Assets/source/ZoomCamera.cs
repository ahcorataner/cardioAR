using UnityEngine;

public class ZoomCamera : MonoBehaviour
{
    public float velocidadeZoom = 10f;
    public float minZoom = 20f;
    public float maxZoom = 60f;

    private Camera cam;

    void Start()
    {
        cam = GetComponent<Camera>();
    }

    void Update()
    {
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        if (scroll != 0f)
        {
            cam.fieldOfView -= scroll * velocidadeZoom;
            cam.fieldOfView = Mathf.Clamp(cam.fieldOfView, minZoom, maxZoom);
        }
    }
}
