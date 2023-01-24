using Sirenix.OdinInspector;
using UnityEngine;

public class SomeComponent : SerializedMonoBehaviour
{
	public ISomeInterface field;
	
	void Start()
	{
		field.Execute();
	}
}

public interface ISomeInterface
{
	void Execute();
}