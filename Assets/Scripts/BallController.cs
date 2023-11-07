using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour
{
    [SerializeField] private int NextLvlId;
    private void Start()
    {
        if(GameManager.Skin != null)
            this.gameObject.GetComponent<SpriteRenderer>().sprite = GameManager.Skin;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Finish")
        {
            PlayerPrefs.SetInt($"AvailableLvl_{NextLvlId}", 1);
            GameManager.Money += 1000;
            Debug.Log("Уровень пройден");
            SceneManager.LoadScene("MainMenu");
        }
    }
}
