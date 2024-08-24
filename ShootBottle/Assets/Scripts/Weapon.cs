using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public float bulletVelocity = 30;
    public float bulletPrefablifeTime = 3f;
    public AudioSource audioS;

     void Start()
    {
        audioS = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            FireWeapon();
        }
    }
    private void FireWeapon()//fired
    {
        //bullet rotation
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawn.position, Quaternion.identity);
        bullet.GetComponent<Rigidbody>().AddForce(bulletSpawn.forward.normalized * bulletVelocity, ForceMode.Impulse);
        audioS.Play();
        StartCoroutine(DestroyBullet(bullet, bulletPrefablifeTime));

    }
    private IEnumerator DestroyBullet(GameObject bullet,float delay)//after 3 second,bull is destroy
    {
        yield return new WaitForSeconds(delay);
        Destroy(bullet);
    }

}
