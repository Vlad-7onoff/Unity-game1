using UnityEngine;

public class Destroyer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.TryGetComponent(out Place place))
        {
            place.Deactivate();
        }
        else if (collision.gameObject.TryGetComponent(out Coin coin))
        {
            coin.Deactivate();
        }
    }
}
