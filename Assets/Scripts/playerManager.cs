using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerManager : MonoBehaviour
{
    // Player specific variables
<<<<<<< HEAD
    private int currentIndex;
    public PlayerInfo info;
=======
    private int health;
    private int score;
>>>>>>> parent of 4a880aa... Platformer lesson 1 Coins

    // Boolean values
    private bool isGamePaused = false;

    // UI stuff
    public Text healthText;
    public Text scoreText;
    public GameObject pauseMenu;
    public GameObject winMenu;
    public GameObject loseMenu;

    // Start is called before the first frame update
    void Start()
    {
        info = GameObject.FindGameObjectWithTag("Info").GetComponent<PlayerInfo>();
        foreach (Collectable item in info.inventory)
        {
            item.player = this.gameObject;
        }


        // Makes sure game is "unpaused"
        isGamePaused = false;
        Time.timeScale = 1.0f;

        // Make sure all menus are filled in
        FindAllMenus();

        //Start player with initial health and score
        //health = 100;
        //score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health: " + info.health.ToString();
        scoreText.text  = "Score:  " + info.score.ToString();
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
        }
        if (info.health <= 0)
        {
            LoseGame();
        }
    }

   void FindAllMenus()
    {
        if (healthText == null)
        {
            healthText = GameObject.Find("HealthText").GetComponent<Text>();
        }
        if (scoreText == null)
        {
            scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
        }
        if (winMenu == null)
        {
            winMenu = GameObject.Find("WinGameMenu");
            winMenu.SetActive(false);
        }
        if (loseMenu == null)
        {
            loseMenu = GameObject.Find("LoseGameMenu");
            loseMenu.SetActive(false);
        }
        if (pauseMenu == null)
        {
            pauseMenu = GameObject.Find("PauseGameMenu");
            pauseMenu.SetActive(false);
        }
    }

    public void WinGame()
    {
        Time.timeScale = 0.0f;
        winMenu.SetActive(true);
    }

    public void LoseGame()
    {
        Time.timeScale = 0.0f;
        loseMenu.SetActive(true);
    }

    public void PauseGame()
    {
        if (isGamePaused)
        {
            // Unpause game
            Time.timeScale = 1.0f;
            pauseMenu.SetActive(false);
            isGamePaused = false;
        }
        else
        {
            // Pause game
            Time.timeScale = 0.0f;
            pauseMenu.SetActive(true);
            isGamePaused = true;
        }
    }

    public void ChangeHealth(int value)
    {
        info.health += value;
    }

    public void ChangeScore(int value)
    {
        info.score += value;
    }

<<<<<<< HEAD
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Collectable>() != null)
        {
            collision.GetComponent<Collectable>().player = this.gameObject;
            collision.gameObject.transform.parent = null;
            info.inventory.Add(collision.GetComponent<Collectable>());
            collision.gameObject.SetActive(false);
        }
    }

    private void InventoryInput()
    {
        if (info.inventory.Count == 0)
        {
            currentItemText.text = "No Items";
            currentItemDescriptionText.text = "";
        }
        else
        {
            currentItemText.text = "Slot " +
                (currentIndex + 1).ToString() + " : " + info.inventory[currentIndex].collectableName;
            currentItemDescriptionText.text = "Press E to " + info.inventory[currentIndex].description;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (info.inventory.Count > 0)
            {
                info.inventory[currentIndex].Use();
                info.inventory.RemoveAt(currentIndex);
                if (info.inventory.Count == 0)
                {
                    currentIndex = 0;
                }
                else
                {
                    currentIndex = (currentIndex - 1) % info.inventory.Count;
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            if (info.inventory.Count > 0)
            {
                currentIndex = (currentIndex + 1) % info.inventory.Count;
            }
        }
        
    }

=======
>>>>>>> parent of 4a880aa... Platformer lesson 1 Coins
}
