using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour {

    public Projectile projectile;
    public Transform muzzle;
    public float bulletSpeed;
    //public float delayTime;
    private float delayCounter = 0.0F;
    private float reloadDelay = 1F;
    private float ammoLeft = 200;
    public int bullets = 7;
    private float fireRate = 0.3F;

    public AudioClip impact;
    AudioSource audio;

    void Start()
    {
        ammobombManager.ammo = 7;
        audio = GetComponent<AudioSource>();
    }


    void Update()
    {
        delayCounter -= Time.deltaTime;
        if (Input.GetMouseButton(0) && Time.time > delayCounter && bullets > 0)
        {
            ammobombManager.ammo -= 1;
            Shoot();
            //delayCounter = delayTime;
        }
        else if (Input.GetKeyDown("r") && ammoLeft > 0 && bullets < 7)
        {
            ammobombManager.ammo = bullets;
            bullets = 7;
            //ammoLeft -= 1;
            delayCounter = Time.time + reloadDelay;
        }
    }   

    private void Shoot()
    {
        Projectile bullet = Instantiate(projectile, muzzle.position, muzzle.rotation) as Projectile;
        bullet.SetSpeed (bulletSpeed);
        delayCounter = Time.time + fireRate;
        bullets -= 1;
        ammobombManager.ammo -= 1;
        audio.PlayOneShot(impact, 0.7F);
    }

}
