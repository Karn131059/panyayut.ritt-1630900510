using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PickItem : MonoBehaviour
{
    private int score = 0;
    public Text scoreText;
    private AudioSource audioSource;
    public AudioClip itemSound;
   

    int itemCount;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        itemCount = GameObject.FindGameObjectsWithTag("Item").Length;
        scoreText.text = "Item =  " + score.ToString() + "/" + itemCount.ToString();
        
    }
    private void OnTriggerEnter(Collider target)
    {
        if (target.gameObject.tag.Equals("Item"))
        {
            Destroy(target.gameObject);

            score += 1;
            scoreText.text = "Item =  " + score.ToString() + "/" + itemCount.ToString();
            audioSource.PlayOneShot(itemSound);
        }
    }
    

}
