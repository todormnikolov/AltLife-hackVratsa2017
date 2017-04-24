using System;
using UnityEngine;
using UnityEngine.UI;

public class BuildingPrefabInstance : MonoBehaviour
{
    public GameObject mainPlayer;
    public GameObject BuildingPrefab;
    public GameObject BuyDialog;

    private GameObject BuildingPrefabClone;
    public Animator charAnimator;
    public AudioSource woohooAudio;
    public AudioSource cachingAudio;
    public AudioSource nomoneyAudio;
    public Text moneyText;

    public void loadScene()
    {
        Application.LoadLevel("MapScene");
    }

    public void createPrefab()
    {
  
        if (moneyText.text == "0€")
        {
            nomoneyAudio.Play();
        }
        else
        {
            var pos = mainPlayer.transform.position + new Vector3(0, 0, -5);
            BuildingPrefabClone = Instantiate(BuildingPrefab, pos, Quaternion.identity) as GameObject;
            charAnimator.Play(Animator.StringToHash("Base Layer.TURN"));
            cachingAudio.Play(0);
            woohooAudio.Play(30000);
            moneyText.text ="0€";
        }
    }
}
