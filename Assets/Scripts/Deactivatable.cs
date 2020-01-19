using UnityEngine;

public class Deactivatable : MonoBehaviour
{
    public void Deactivate()
    {
        gameObject.SetActive(false);
    }
}
