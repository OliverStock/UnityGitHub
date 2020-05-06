using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemIn3D : MonoBehaviour
{
    public Item MyItem;
    //public UiLeiste DieUILeiste; 
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnMouseUp()
    {
        // Erzeuge ein neues Ui-Object in der UI-Leiste
        // Diesem Object muss das SO übergeben werden
        // UiLeiste.NewItem(MyItem);

        // Ich werde aufgesammelt und verschwinde
        // Destroy(gameObject);
    }
}
