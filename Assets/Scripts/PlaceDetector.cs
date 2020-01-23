using UnityEngine.Events;
using UnityEngine;

public class PlaceDetector : MonoBehaviour
{
    public event UnityAction<Place> PlaceDetecting;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Place place))
        {
            PlaceDetecting?.Invoke(place);
        }
    }
}
