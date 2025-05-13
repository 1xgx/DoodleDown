using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] private TypeOfObject _type;
    public TypeOfObject Type => _type;

}
