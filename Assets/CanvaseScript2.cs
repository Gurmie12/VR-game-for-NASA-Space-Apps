using UnityEngine;
using UnityEngine.UI;
public class CanvaseScript2 : MonoBehaviour
{
	public Text canvasText1;
	void Start()
	{
		Invoke("DisableText", 100f);//invoke after 5 seconds
	}
	void DisableText()
	{
		canvasText1.enabled = false;
	}
}