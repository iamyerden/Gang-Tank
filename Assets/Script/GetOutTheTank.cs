using UnityEngine;

public class GetOutTheTank : MonoBehaviour {

	public GameObject player, spawn;

	void Update () {
		if (Input.GetKeyDown (KeyCode.F) && SitInTheTank.inTheTank) {	
			player.transform.position = spawn.transform.position;
			player.SetActive (true);
			transform.GetComponentInParent <TankMove> ().enabled = false;
			this.enabled = false;
			SitInTheTank.inTheTank = false;
			gameObject.SetActive (false);
		}
	}

}
