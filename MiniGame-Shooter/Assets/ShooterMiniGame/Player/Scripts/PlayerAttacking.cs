using UnityEngine;

public class PlayerAttacking : Projectile
{
    [Header("Bullet Settings")]

    [SerializeField] GameObject bulletPrefab;
    [SerializeField] GameObject bulletSpawnPos;
    GameObject bullet;
    [SerializeField] float thrust;
    [SerializeField] float timeToDestroy;

    [Header("Raycast Settings")]

    RaycastHit rayCastHit;
    Vector3 currentTarget;
    [SerializeField] float interactionDistance;
    bool enemyIsFound;
    private void Update()
    {
        GetEnemyPosition();
    }
    public void CreateBullet()
    {
        bullet = Instantiate(bulletPrefab, bulletSpawnPos.transform);
    }
    public void DestroyBullet()
    {
        Destroy(bullet, timeToDestroy);
    }
    public void ShootBullets()
    {
        CreateBullet();
        bullet.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, 1) * thrust, ForceMode.Impulse);
        DestroyBullet();
    }
    public void GetEnemyPosition()
    {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * interactionDistance, Color.yellow);
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out rayCastHit, interactionDistance))
            {
                if (rayCastHit.collider.gameObject.CompareTag(GameTags.EnemyTag))
                {
                     currentTarget = rayCastHit.collider.gameObject.transform.position;
                     enemyIsFound = true;
                }
            }
    }
    public void ThrowBullet()
    {
        if(enemyIsFound)
        {
            CreateBullet();
            FireProjectile(bulletSpawnPos.transform.position, currentTarget, bullet);
            DestroyBullet();
        }
        else
        {
            Debug.Log("Enemy is not found!");
        }
    }
}
