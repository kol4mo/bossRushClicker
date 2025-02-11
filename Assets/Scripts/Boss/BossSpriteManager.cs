using UnityEngine;
using UnityEngine.UI;

public class BossSpriteManager : MonoBehaviour
{
    [Header("Boss Sprite")]
    public Image spriteRenderer;
    public Sprite[] bossSprites; // Array of sprites for different bosses
    public static BossSpriteManager instance {get; private set;}

	private void Awake() {
		instance = this;
	}

	// This function can be called to change the sprite based on a boss type or selection
	public void SetSprite(int index)
    {
        if (index >= 0 && index < bossSprites.Length)
        {
            spriteRenderer.sprite = bossSprites[index];
        }
        else
        {
            Debug.LogWarning("Invalid sprite index! No sprite set.");
        }
    }
}
