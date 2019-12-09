﻿using UnityEngine;

public class White : MonoBehaviour
{
    #region 練習區域 - 在此區域內練習

    [Header("子彈")]
    public GameObject Bullet;
    [Header("子彈發射位置")]
    public Transform Point;
    [Header("音效區域")]
    public AudioSource Aud;
    public AudioClip SoundShoot;

    private void sss()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            print("射擊");
            Instantiate(Bullet);
            Aud.PlayOneShot(SoundShoot);
            
        }
    }
    

    #endregion

    #region KID 區域 - 不要偷看 @3@
    [Header("移動速度"), Range(0f, 100f)]
    public float speed = 1.5f;

    private Rigidbody2D rig;

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Move();
        sss();
        
    }

    /// <summary>
    /// 移動
    /// </summary>
    private void Move()
    {
        rig.AddForce(transform.right * Input.GetAxisRaw("Horizontal") * speed);
    }
    #endregion

}
