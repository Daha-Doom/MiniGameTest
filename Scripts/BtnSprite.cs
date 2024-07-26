using UnityEngine;

public class BtnSprite : MonoBehaviour
{
    SpriteRenderer spriteRenderer;

    [SerializeField]
    protected Sprite btnOverSprite, btnDefaultSprite, btnDownSprite;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnMouseOver()
    {
        spriteRenderer.sprite = btnOverSprite;
    }

    private void OnMouseExit()
    {
        spriteRenderer.sprite = btnDefaultSprite;
    }

    private void OnMouseDown()
    {
        spriteRenderer.sprite = btnDownSprite;
    }
}
