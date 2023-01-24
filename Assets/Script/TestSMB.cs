/* Created by and for usage of FF Studios (2021). */

using UnityEngine;
using Sirenix.OdinInspector;

public class TestSMB : SerializedMonoBehaviour
{
	[ SerializeField ] ISomeInterface[] interface_array;
    [ SerializeField ] TestSSO testSSO;

	void Start()
	{
		foreach( var interf in interface_array )
			interf.Execute();
            
        FFStudio.FFLogger.Log( name + ": TestSMB will now invoke Execute() on elements of TestSSO's interface_array.", this );
        
		foreach( var interf in testSSO.interface_array )
			interf.Execute();
	}
}

public interface ISomeInterface
{
	void Execute();
}