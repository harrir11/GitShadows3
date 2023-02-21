using UnityEngine;

public class IgnoreLight : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.material = new Material(Shader.Find("Sprites/Default"));
    }
}
