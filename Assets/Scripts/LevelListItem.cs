using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class LevelListItem : MonoBehaviour, IPointerClickHandler {

	public Text nameText;
	public LevelListManager lManager;
	public GameManager gManager;

	private string name;
	public string url;
	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SetData(string n, string u)
	{
		name = n;
		url = u;
		nameText.text = name;
	}

	#region IPointerClickHandler implementation
	public void OnPointerClick (PointerEventData eventData)
	{
		lManager.chosenLevelUrl = this.url;
		gManager.ChangeScene ("DesainLevel");
	}
	#endregion
}
