using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerGo : MonoBehaviour {
    
    public float speed;
    public SpriteRenderer sr;
    public float jumpForce;
    
    public Vector2 moveVector ;
    private Rigidbody2D rb;
    
    public float normalSpeed;







    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        speed = 0;
        
    }
   
    void Update()
    {
       
        Ded();
        
        
    }
   private void FixedUpdate()
    {
        rb.velocity = new Vector2(speed, rb.velocity.y);
    }
  
   
    

public void OnLeftButtonDown()
    {
        if (speed>=0f)
        {
            speed = -normalSpeed;
            Vector3 theScale = transform.localScale;
            theScale.x = -0.5347f;
            transform.localScale = theScale;
            
            
        }
        
    }

    public void OnRightButtonDown()
    {
        if (speed <= 0f)
        {
            speed = normalSpeed;
            Vector3 theScale = transform.localScale;
            theScale.x = 0.5347f;
            transform.localScale = theScale;
           
            
        }
        
    }
   

    public void OnButtonUp()
    {
        speed = 0;
    }
    public void OnButtonJump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
       if (other.tag == "Respawn")
       {
            
            //MoneyText.Coins = 0;

            
           
           
            HP.HPcount -= 1;
            StartCoroutine(Tik());
            



        }
        if (other.tag == "шип левл 2")
       {
          
            transform.position = new Vector2(66,0);
            MoneyText2lvl.Coins2lvl = MoneyText.Coins;
            
            attempText2lvl.PlayerGo += 1;

           

        }
        if (other.tag == "Rocet")
       {
            transform.position = new Vector2(66, 0);
            MoneyText2lvl.Coins2lvl = MoneyText.Coins;
            attempText2lvl.PlayerGo += 1;

            
        }
       if (other.tag == "mob")
        {
            SceneManager.LoadScene(2);
            MoneyText2lvl.Coins2lvl = Cheackpoint.score;
            attempText2lvl.PlayerGo += 1;
            
        }

        if (other.tag == "шип2€р")
        {
            MoneyText2lvl.Coins2lvl = Cheackpoint.score ;
            SceneManager.LoadScene(2);
            attempText2lvl.PlayerGo += 1;

        }
    }
   public void Ded()
    {
        if (HP.HPcount == 0)
        {
            transform.position = new Vector2(30, 3);
            attempText.PlayerGo += 1;
            HP.HPcount = 3;
        }
    }
    public IEnumerator Tik()
    {
        speed = speed*-1;
        yield return new WaitForSeconds(0.5f);
        speed = 0;



    }
   
}




 