using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soldier 
{
    //Change material
    public MeshRenderer soldierMeshRenderer;
    //Move soldier
    public Transform soldierTrans;
    //Speed of soldier
    protected float walkSpeed;
    public Soldier previousSoldier;
    public Soldier nextSoldier; 

    //The enemy doesnt need any outside info
    public virtual void Move()
    { }

    public virtual void Move(Soldier soldier)
    { }
}
