using UnityEngine;

public class GirarObjeto : MonoBehaviour
{
    public float velocidade = 3000f;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            float rotacaoX = Input.GetAxis("Mouse X") * velocidade * Time.deltaTime;
            transform.Rotate(Vector3.up, -rotacaoX, Space.World);
        }
    }
}
