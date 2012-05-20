using UnityEngine;
using System.Collections;

public class WasdController : MonoBehaviour
{

  PlayerGravityBody player;
  Cycler attractors;
  private Locomotor locomotor;

  void Start()
  {
    locomotor = GetComponent<Locomotor>();
    player = GetComponent<PlayerGravityBody>();
    attractors = new Cycler(FindObjectsOfType(typeof(GravityAttractor)));
  }

  void Update()
  {
    if (Input.GetKey(KeyCode.W)) {
      locomotor.GoForward();
    }

    if (Input.GetKey(KeyCode.S)) {
      locomotor.GoBackward();
    }

    if (Input.GetKey(KeyCode.A)) {
      locomotor.TurnLeft();
    }

    if (Input.GetKey(KeyCode.D)) {
      locomotor.TurnRight();
    }
    
    if (Input.GetKeyDown(KeyCode.Space))
    {
      if (Input.GetKey(KeyCode.LeftShift))
        player.attractor = attractors.Next() as GravityAttractor;
      else
        player.Jump();
    }
  }

}
