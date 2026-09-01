using UnityEngine;

public class Coin : MonoBehaviour
{
  [SerializeField]
    private int coinValue = 10;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PLayerScript playerScore = other.GetComponent<PLayerScript>();

            if (playerScore != null)
            {
                playerScore.AddScore(coinValue);
            }

            Destroy(gameObject);
        }
    }
}
