using UnityEngine;
using System.Collections;

public class EnemyShooting : MonoBehaviour {

    public EnemyProjectile enemyProjectile;
    public Transform muzzle;
    public float bulletSpeed = 10;
    //public float delayTime;
    private float delayCounter = 0.0F;
    private float reloadDelay = 1.5F;
    //private float ammoLeft = 200;
    private float bullets = 7;
    private float fireRate = 1F;
    public float minimumDamage = 20f;
    public float maximumDamage = 60f;
    public bool playerInSight;

    private GameObject Player;
    private CapsuleCollider col;
    private Transform player;
    private PlayerHealth playerHealth;
    //private EnemyAI enemyAI;
    private bool shooting;
    private float scaledDamage;
    //private float nextFire = 0.0F;

    //public AudioClip impact;
    //AudioSource audio;

    void Start()
    {
        //audio = GetComponent<AudioSource>();
        Destroy(gameObject, 45f);
    }

    void Awake()
    {
        col = GetComponent<CapsuleCollider>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        playerHealth = player.gameObject.GetComponent<PlayerHealth>();

        scaledDamage = maximumDamage - minimumDamage;
    
    }

    void Update()
    {
        delayCounter -= Time.deltaTime;
    }

        void OnTriggerStay(Collider other)
    { 
        if (other.CompareTag("Player"))
        {
            if (Time.time > delayCounter && bullets > 0 && !shooting)
            {
                //transform.LookAt(_PlayerObj.transform.position);
                Shoot();
                //delayCounter = delayTime;
            }
            else if (Time.time < delayCounter)
            {
                shooting = false;
            }

            else if (bullets < 1)
            {
                delayCounter = Time.time + reloadDelay;
                bullets = 7;
                shooting = false;
            }
        }
    }

    void Shoot()
    {
        shooting = true;
        bullets -= 1;
        EnemyProjectile bullet = Instantiate(enemyProjectile, muzzle.position, muzzle.rotation) as EnemyProjectile;
        //audio.PlayOneShot(impact, 0.7F);
        bullet.SetSpeed(bulletSpeed);
        delayCounter = Time.time + fireRate;
    }
}
