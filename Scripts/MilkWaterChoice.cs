using UnityEngine;
using UnityEngine.SceneManagement;

public class MilkWaterChoice : MonoBehaviour
{
    public bool isCorrect = false;

    void OnMouseDown()
    {
        if (isCorrect)
        {
            Debug.Log("Correct! Proceeding to the milk making scene.");
            SceneManager.LoadScene("MainGame"); // Load milk making scene
        }
        else
        {
            Debug.Log("Wrong choice! This water is not suitable for the baby.");
            // You can add failure effects or retry logic here
        }
    }
}
