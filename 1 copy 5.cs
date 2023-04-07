using UnityEngine;
using TMPro;
using Valve.VR.InteractionSystem;

public class SnapToGrid : MonoBehaviour
{
    public Canvas canvas;
    public TextMeshProUGUI gridCell;
    public float gridSize = 0.0625f;

    private Rigidbody rb;
    private Vector2 gridOffset;
    private Interactable interactable;
    private bool isBeingHeld;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        gridOffset = new Vector2(gridSize * gridCell.fontSize / 2f, gridSize * gridCell.fontSize / 2f);
        interactable = GetComponent<Interactable>();
    }

    void FixedUpdate()
    {
        if (interactable != null && interactable.attachedToHand != null)
        {
            // The object is being held by a hand
            isBeingHeld = true;
        }
        else
        {
            // The object is not being held by a hand
            isBeingHeld = false;
        }

        if (!isBeingHeld)
        {
            // Snap to the grid if the object is not being held
            Vector2 pos = canvas.WorldToScreenPoint(rb.position);
            pos -= gridOffset;
            pos /= gridSize;
            pos = new Vector2(Mathf.Round(pos.x), Mathf.Round(pos.y));
            pos *= gridSize;
            pos += gridOffset;
            rb.MovePosition(canvas.ScreenToWorldPoint(pos));
        }
    }
}