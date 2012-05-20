using UnityEngine;

public class FollowCamera : MonoBehaviour 
{
	/*
	 * Class members
	 */
	public Transform _target;
	public float _distance = 10.0f;
	public float _height = 1.0f;
	public float _damping = 5.0f;
	public float _rotationDamping = 10.0f;
	
	
	/*
	 *  Update class function
	 */
	private void FixedUpdate()
	{
		// Calculate and set camera position
		Vector3 desiredPosition = this._target.TransformPoint(0, this._height, -this._distance);
		this.transform.position = Vector3.Lerp(this.transform.position, desiredPosition, Time.deltaTime * this._damping);
		
		// Calculate and set camera rotation
		Quaternion desiredRotation = Quaternion.LookRotation(this._target.position - this.transform.position);//, this._target.up);  //todo--reorient to player.up when player moves
		this.transform.rotation = Quaternion.Slerp(this.transform.rotation, desiredRotation, Time.deltaTime * this._rotationDamping);
	}
}
