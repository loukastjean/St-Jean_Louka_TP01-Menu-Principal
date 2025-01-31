using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicLayerOrder : MonoBehaviour
{
    SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        // R�cup�rer le SpriteRenderer
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        // � chaque modification des valeurs du Transform
        if (transform.hasChanged)
        {
            // Modifier le LayerOrder
            spriteRenderer.sortingOrder = Mathf.RoundToInt(transform.position.y * 10f) * -1;
            transform.hasChanged = false;
        }
        
    }
}
