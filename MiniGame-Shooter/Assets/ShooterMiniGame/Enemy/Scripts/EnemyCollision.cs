using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag(GameTags.BulletTag))
        {
            //Destroy(this.gameObject, 0.5f);
            this.gameObject.SetActive(false);
        }
    }
}
