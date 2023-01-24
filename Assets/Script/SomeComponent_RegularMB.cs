using Sirenix.OdinInspector;
using UnityEngine;

public class SomeComponent_RegularMB : MonoBehaviour
{
	public ISomeInterface field;
	
	void Start()
	{
		field.Execute();
	}
}