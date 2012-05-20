using UnityEngine;
using System.Collections;

public class Locomotor : MonoBehaviour {
  public float velocity = 10f;
  public float turnRate = 100;
  public float jumpForce = 10f;

  public void GoForward() {
    transform.Translate(Vector3.forward * velocity * Time.deltaTime);
  }

  public void GoBackward() {
    transform.Translate(Vector3.forward * velocity * Time.deltaTime * -1);
  }

  public void TurnRight() {
    transform.Rotate(new Vector3(0, 1, 0), turnRate * Time.deltaTime);
  }

  public void TurnLeft() {
    transform.Rotate(new Vector3(0, -1, 0), turnRate * Time.deltaTime);
  }

  public void Jump() {
    rigidbody.AddForce(transform.up * jumpForce);
  }
}
