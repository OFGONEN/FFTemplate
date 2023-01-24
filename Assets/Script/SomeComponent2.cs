/* Created by and for usage of FF Studios (2021). */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeComponent2 : MonoBehaviour, ISomeInterface
{
    void ISomeInterface.Execute()
    {
		transform.localRotation = Quaternion.Euler( 0, 0, 45 );
	}
}
