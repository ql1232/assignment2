using UnityEngine;
using UnityEngine.Events;

 public class BallController : MonoBehaviour
 {
[SerializeField] private Transform ballAnchor;

 [SerializeField] private bool clicked = false;
 [SerializeField] private InputManager inputManager;
[SerializeField] private Transform launchIndicator;


	private Rigidbody ballRB;
 	void Start()
 	{
 	//Grabbing a reference to RigidBody
 	ballRB = GetComponent<Rigidbody>();

	 // Add a listener to the OnSpacePressed event.
 	// When the space key is pressed the
 	// LaunchBall method will be called.
 		inputManager.OnSpacePressed.AddListener(LaunchBall);
	transform.parent = ballAnchor;
	 transform.localPosition = Vector3.zero;
	ballRB.isKinematic=true;
	ResetBall();

	 }

		
public void ResetBall()
{
 clicked = false;

 //We are setting the ball to be a Kinematic Body
 ballRB.isKinematic = true;

 launchIndicator.gameObject.SetActive(true);
 transform.parent = ballAnchor;
 transform.localPosition = Vector3.zero;
 }

	private void LaunchBall()

	{
	if(!clicked){
clicked=true;
launchIndicator.gameObject.SetActive(false);
transform.parent = null; ballRB.isKinematic=false;
ballRB.AddForce(launchIndicator.forward * 15, ForceMode.Impulse);

}
	}
}
