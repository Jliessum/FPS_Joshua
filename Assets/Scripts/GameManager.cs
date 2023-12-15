using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static int killCount = 0; // Static variable to store kill count
    public Text killCountText; // Reference to a UI text element to display the kill count

    void Start()
    {
        UpdateKillCountText(); // Initialize UI text
    }

    public void IncrementKillCount()
    {
        killCount++;
        UpdateKillCountText();
    }

    void UpdateKillCountText()
    {
        if (killCountText != null)
        {
            killCountText.text = "Kill Count: " + killCount.ToString();
        }
    }
}