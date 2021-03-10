using UnityEngine;

public class EnemyAttacking : Projectile
{
    [SerializeField] float range;
    [SerializeField] float rotationSpeed;
    [SerializeField] float movementSpeed;
    [SerializeField] Transform player;

    private void Update()
    {
        DetectPlayer();
    }
    public void DetectPlayer()
    {
        if (player != null)
        {
            Vector3 distance = player.position - transform.position;
            if (distance.magnitude >= range)
            {
                Seek();
            }
            else
            {
                Jump();
            }
        }
    }
    public void Seek()
    {
       if (player != null)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation,
            Quaternion.LookRotation(player.position - transform.position),
            rotationSpeed * Time.deltaTime);
            transform.position += transform.forward * movementSpeed * Time.deltaTime;
        }
    }

    public void Jump()
    {
        FireProjectile(this.gameObject.transform.position, player.position, this.gameObject);
    }
}
