using UnityEngine;

public class PlaceDestroyer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
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
