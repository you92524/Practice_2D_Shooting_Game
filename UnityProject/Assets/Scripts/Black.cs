using UnityEngine;
using UnityEngine.UI;

public class Black : MonoBehaviour
{
    #region 練習區域 - 在此區域內練習
    [Header("血量")]
    public int hp = 10;
    [Header("血量介面")]
    public Text textHp;
    [Header("音效區域")]
    public AudioSource aud;
    public AudioClip soundHit;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "子彈")
        {
            Hit();
        }
    }

    /// <summary>
    /// 受傷
    /// </summary>
    private void Hit()
    {
        aud.PlayOneShot(soundHit, 1.2f);
        hp--;
        textHp.text = hp.ToString();

        if (hp == 0) Destroy(gameObject, 0.1f);
    }
    #endregion
}
