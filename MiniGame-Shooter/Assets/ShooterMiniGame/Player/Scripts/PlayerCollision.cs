using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] SO.Events.EventSO OnPlayerDies;
    [SerializeField] GameObject playerExplode;

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.CompareTag(GameTags.EnemyTag))
        {
            OnPlayerDies.Raise();
            // Destroy(this.gameObject,0.5f);
            this.gameObject.SetActive(false);
        }
    }
    public void Explode()
    {
        Destroy(Instantiate(playerExplode, transform.position, Quaternion.identity), 1f);
    }
  
}
