using UnityEditor;
using UnityEngine;

public class BuildingPrefabInstance : MonoBehaviour
{
    public GameObject mainPlayer;
    public GameObject BuildingPrefab;

    GameObject BuildingPrefabClone;
    public Animator charAnimator;

    public void dialogAsk()
    {
        if (EditorUtility.DisplayDialog("Купуване", "Сигурен ли си, че сакаш да купиш те тоя имот?", "Да", "Не"))
        {
            Debug.Log("сакам");
        }
        else
        {
            Debug.Log("не сакам");
        }
    }

    private void createPrefab()
    {
        var pos = mainPlayer.transform.position + new Vector3(2, 0, 0);
        BuildingPrefabClone = Instantiate(BuildingPrefab, pos, Quaternion.identity) as GameObject;
    }
}
