using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponAim : MonoBehaviour
{
    // Start is called before the first frame update
    public SpriteRenderer characterSprite, weaponSprite;
    // Update is called once per frame
    void Update()
    {
        Vector2 dir = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = rotation;

        Vector2 scale = transform.localScale;
        if (dir.x < 0)
        {
            scale.y = -1;
        } else if (dir.x >= 0) {
            scale.y = 1;
        }
        transform.localScale = scale;

        if (dir.y > 0)
        {
            weaponSprite.sortingOrder = characterSprite.sortingOrder - 1;

        }
        else
        {
            weaponSprite.sortingOrder = characterSprite.sortingOrder + 1;
        }
    }
}
