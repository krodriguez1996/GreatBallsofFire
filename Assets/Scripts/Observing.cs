using UnityEngine;
using System.Collections;
[System.Serializable]
public abstract class SphereBehavior  {

	// Use this for initialization
	public abstract void move (Transform t);

};

[System.Serializable]
public class MonoAngle : SphereBehavior
{
	public override void move(Transform t)
	{
		
		t.position = t.position + t.right * 0.1f;
	}
};
[System.Serializable]
public class ChangeAngle: SphereBehavior
{
	public override void move(Transform t)
	{
		
		t.position = t.position + t.right * 0.1f;

		Vector3 va = new Vector3(0.0f,0.0f,0.0f);
		Vector3 v = t.rotation.eulerAngles;

		va.x = UnityEngine.Random.Range (-3f, 3f);
		va.y = UnityEngine.Random.Range (-3f, 3f);
		va.z = UnityEngine.Random.Range (-3f, 3f);
		t.rotation = Quaternion.Euler(va.x+v.x, va.y+v.y, va.z+v.z);

	}
};
[System.Serializable]
public class JitterAngle: SphereBehavior
{
	public override void move(Transform t)
	{
		t.position = t.position + t.right * 0.1f;
		t.up = t.up + t.up * UnityEngine.Random.Range (-.3f, .3f);
		Vector3 ve = t.rotation.eulerAngles;

		ve.x = UnityEngine.Random.Range (-.3f, .3f);
		ve.y = UnityEngine.Random.Range (-.3f, .3f);
		ve.z = UnityEngine.Random.Range (-.3f, .3f);
		Vector3 change = new Vector3 (ve.x, ve.y, ve.z);
		t.position = t.position + change;


}
};
//using UnityEngine;
//using System.Collections;

public class Observing : MonoBehaviour {

	public SphereBehavior myBehaviour;

	// Update is called once per frame
	void FixedUpdate () {
		myBehaviour.move (transform);
	}
		
};
	