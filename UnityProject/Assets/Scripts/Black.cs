using UnityEngine;
using UnityEngine.UI;

public class Black : MonoBehaviour
{
    #region 練習區域 - 在此區域內練習
    [Header("血量")]
    public int HP=10;
    [Header("血量介面")]
    public Text TextHP;
    [Header("音效區域")]
    public AudioSource Aud;
    public AudioClip SoundHit;
    
    

    public void hhh()
    {
       
        if (gameObject.tag=="子彈")
        {
            HP = HP - 1;
            TextHP.text = HP.ToString();
            Aud.PlayOneShot(SoundHit);
        }

    }
   
    private void FixedUpdate()
    {
        hhh();
      

    }

    #endregion
}
