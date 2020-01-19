using UnityEngine;

public class Coin : Deactivatable
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Player player))
        {
            player.PickUpCoin();
            Deactivate();
        }
    }
}
