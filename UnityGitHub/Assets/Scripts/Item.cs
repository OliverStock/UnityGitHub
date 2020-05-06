using UnityEngine;
using UnityEditor.UI;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/InventoryItem", order = 1)]
public class Item : ScriptableObject
{
    public GameObject _GameObject;
    public Texture2D InventoryPicture;

    public Item[] CanCombineWith;
    public GameObject[] InteractionWith;

    public bool Consumable;
}
