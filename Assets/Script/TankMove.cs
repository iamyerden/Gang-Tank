using UnityEngine;

public class TankMove : MonoBehaviour {

	[SerializeField]
	private float speed = 10f;
	[SerializeField]
	private float lookSpeed = 30f;

	void Update () {
		float xMov = Input.GetAxisRaw ("Horizontal");
		float zMov = Input.GetAxisRaw ("Vertical");

		transform.Translate (Vector3.right * zMov * speed * Time.deltaTime);
		transform.Rotate (Vector3.up * xMov * lookSpeed * Time.deltaTime, Space.World);
	}

}
