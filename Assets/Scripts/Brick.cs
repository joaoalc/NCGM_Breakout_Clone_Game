using UnityEngine;

public class Brick : MonoBehaviour {

    private int lifePoints;
    private SpriteRenderer spriteRenderer;
    public Sprite[] spriteSheet = new Sprite[1];

    void Start()
    {
        lifePoints = spriteSheet.Length - 1;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (--lifePoints < 0)
            Destroy(this.gameObject);

        spriteRenderer.sprite = spriteSheet[lifePoints];
    }
}
