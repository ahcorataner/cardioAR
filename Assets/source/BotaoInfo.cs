using UnityEngine;

public class BotaoInfo : MonoBehaviour
{
    public GameObject painelInfo;

    public void ToggleInfo()
    {
        if (painelInfo != null)
        {
            painelInfo.SetActive(!painelInfo.activeSelf);
        }
    }
}
