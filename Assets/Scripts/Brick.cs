using UnityEngine;

public class Brick : MonoBehaviour {
    private int lifePoints;

    public Sprite[] spriteSheet = new Sprite[1];

    void Start()
    {
        lifePoints = spriteSheet.Length;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (--lifePoints < 0)
            Destroy(this.gameObject);

        this.GetComponent<SpriteRenderer>().sprite = spriteSheet[lifePoints];
    }
}
