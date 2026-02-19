using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;


public class ViewChanging : MonoBehaviour
{
    public Transform player;          
    public Transform outsidePoint;

    public GameObject restartButton;
    public GameObject winText;

    private bool skullGateDone = false;
    private bool axeGateDone = false;

    private bool hasWon = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        winText.SetActive(false);
        restartButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MarkSkullGateDone()
    {
        skullGateDone = true;
        CheckWin();
    }

    public void MarkAxeGateDone()
    {
        axeGateDone = true;
        CheckWin();
    }

    private void CheckWin()
    {
        if (hasWon) return;
        if (skullGateDone && axeGateDone)
        {
            TriggerWin();
        }
    }
    public void TriggerWin()
    {
        if (hasWon) return;
        hasWon = true;

        // player position moved to outside point
        player.position = outsidePoint.position;
        player.rotation = outsidePoint.rotation;

        // show win text
        if (winText != null)
        {
            winText.SetActive(true);
            restartButton.SetActive(true);

        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
