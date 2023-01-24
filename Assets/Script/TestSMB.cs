/* Created by and for usage of FF Studios (2021). */

using UnityEngine;
using Sirenix.OdinInspector;

public class TestSMB : SerializedMonoBehaviour
{
	[ SerializeField ] ISomeInterface[] interface_array;

	void Start()
	{
		foreach( var interf in interface_array )
			interf.Execute();
	}
}

public interface ISomeInterface
{
	void Execute();
}