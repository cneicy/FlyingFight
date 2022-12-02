using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnermyControler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 60);
    }
    private float Hp = 100f;
    // Update is called once per frame
    void Update()
    {
        
    }
    public void Hurt()
    {
        Hp -= 25f;
        if (Hp <= 0f)
        {
            Destroy(gameObject);
        }
    }

}
