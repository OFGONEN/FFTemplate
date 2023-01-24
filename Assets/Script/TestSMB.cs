/* Created by and for usage of FF Studios (2021). */

using UnityEngine;
using System.Collections.Generic;
using Sirenix.OdinInspector;

public class TestSMB : SerializedMonoBehaviour
{
	[ SerializeField ] ISomeInterface[] interface_array;
    [ SerializeField ] TestSSO testSSO;
    [ SerializeField ] Dictionary< int, int > dictionary;

	void Start()
	{
		foreach( var interf in interface_array )
			interf.Execute();
            
        Debug.Log( name + ": TestSMB will now invoke Execute() on elements of TestSSO's interface_array.", this );
        
		foreach( var interf in testSSO.interface_array )
			interf.Execute();

		Debug.Log( "Will log the dictionary now:" );
		foreach( var kvp in dictionary )
        {
			Debug.Log( kvp );
		}
	}
}

public interface ISomeInterface
{
	void Execute();
}