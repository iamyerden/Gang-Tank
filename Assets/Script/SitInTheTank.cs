using UnityEngine;

public class SitInTheTank : MonoBehaviour {

	public Camera tankCam;
	public static bool inTheTank;

	void Start () {
		inTheTank = false;
	}

	void OnTriggerStay (Collider other) {
		if (other.tag == "Player") {
			if (Input.GetKeyDown (KeyCode.F) && !inTheTank) {
				tankCam.gameObject.SetActive (true);
				Invoke ("Delegate", 1f);
				other.gameObject.SetActive (false);
				GetComponent <TankMove> ().enabled = true;
				inTheTank = true;
			}
		}
	}

	void Delegate () {
		tankCam.GetComponent <GetOutTheTank> ().enabled = true;
	}

}
