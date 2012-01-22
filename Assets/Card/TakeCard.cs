using UnityEngine;
using System.Collections;

public class TakeCard : MonoBehaviour
{
	public Transform spawnPoint = null;
	public Vector3 pileOffset;

	void Start()
	{
		GoToPile();
	}

	/// <summary>
	/// GUI calls
	/// </summary>
	void OnGUI()
	{
		if (GUI.Button (new Rect(10,280,120,20), "Put Card Away"))
		{
			PutAway();
		}
	}

	/// <summary>
	/// takes a card from the pile and shows it to camera
	/// </summary>
	public void Take()
	{
		renderer.enabled = true;
		Vector3 cameraTransform = Camera.main.transform.position;
		Vector3 cameraForward = Camera.main.transform.forward;
		Hashtable hashToCam = new Hashtable() {
		{"position", cameraTransform+cameraForward*6.0f},
		{"looktarget", Camera.main.transform},
		{"time", 2.0f} };
		iTween.Stop();
		iTween.MoveTo(gameObject, hashToCam);
	}

	/// <summary>
	/// animates card away
	/// </summary>
	public void PutAway()
	{
		Debug.Log(spawnPoint.rotation);
		Hashtable hashToPile = new Hashtable() {
		{"position", spawnPoint.position + pileOffset},
		{"time", 2.0f}};
		Hashtable hashToPile_rot = new Hashtable() {
		{"rotation", spawnPoint},
		{"oncomplete", "GoToPile"},
		{"time", 2.0f}};
		iTween.Stop();
		iTween.MoveTo(gameObject, hashToPile);
		iTween.RotateTo(gameObject, hashToPile_rot);
	}

	/// <summary>
	/// immediately goes back to the pile and hides
	/// </summary>
	void GoToPile()
	{
		transform.position = spawnPoint.position + pileOffset;
		renderer.enabled = false;
	}
}
