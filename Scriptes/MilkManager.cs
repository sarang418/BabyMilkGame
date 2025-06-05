using UnityEngine;

public class MilkManager : MonoBehaviour
{
    public Transform milkFill; // The white area that grows upward

    private float maxY = 0.5f;
    private float minY = -3.5f;
    private float currentY;

    void Start()
    {
        currentY = minY;
        if (milkFill != null)
            milkFill.localPosition = new Vector3(0, currentY, 0);
    }

    void OnMouseDown()
    {
        Debug.Log("you pick this one!!");
        if (currentY < maxY)
        {
            currentY += 0.2f;
            if (milkFill != null)
                milkFill.localPosition = new Vector3(0, currentY, 0);
        }
    }
}

