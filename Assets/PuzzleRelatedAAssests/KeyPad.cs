using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Keypad : MonoBehaviour
{
    public TMP_InputField codeDisplay; // InputField to display entered code
    private string enteredCode = ""; // Stores entered numbers
    public string correctCode = "1234"; // Correct code

    public GameObject keypadPanel; // Assign the Keypad UI in the Inspector
    public GameObject unlockableObject; // Assign object that should unlock

    private FPcontroller player; // Reference to the player movement script

    void Start()
    {
        player = FindObjectOfType<FPcontroller>(); // Find the Player movement script in the scene
    }

    public void OpenKeypad()
    {
        keypadPanel.SetActive(true); // Show the keypad UI
        Time.timeScale = 0f; // Pause the game (optional)
        
        // Disable Player Movement & Look
        if (player != null)
        {
            player.canMove = false;
            Cursor.lockState = CursorLockMode.None; // Unlock cursor
            Cursor.visible = true; // Show cursor for input
        }
    }

    public void CloseKeypad()
    {
        keypadPanel.SetActive(false); // Hide the keypad UI
        Time.timeScale = 1f; // Resume game
        
        // Enable Player Movement & Look
        if (player != null)
        {
            player.canMove = true;
            Cursor.lockState = CursorLockMode.Locked; // Lock cursor back
            Cursor.visible = false; // Hide cursor
        }
    }

    public void AddDigit(string digit)
    {
        if (enteredCode.Length < 4)
        {
            enteredCode += digit;
            codeDisplay.text = enteredCode; // Update display
        }
    }

    public void SubmitCode()
    {
        if (enteredCode == correctCode)
        {
            Debug.Log("Correct Code! Puzzle Solved!");

            if (unlockableObject != null)
            {
                unlockableObject.SetActive(false); // Unlock the object (e.g., a door)
            }

            CloseKeypad(); // Hide keypad and re-enable movement
        }
        else
        {
            Debug.Log("Wrong Code! Try Again.");
            enteredCode = "";
            codeDisplay.text = "";
        }
    }
}