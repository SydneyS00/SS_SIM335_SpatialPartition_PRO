using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Soldier
{
    //the position to head towards
    Vector3 currentTarget;
    //the position the soldier had before it moved
    Vector3 oldPos;
    //the width of the map to generate random coords within it
    float mapWidth;
    //our grid
    Grid grid;

    public Enemy(GameObject soldierObj, float mapWidth, Grid grid)
    {
        //Save what we need to save
        this.soldierTrans = soldierObj.transform;

        this.soldierMeshRenderer = soldierObj.GetComponent<MeshRenderer>();

        this.mapWidth = mapWidth;

        this.grid = grid;

        //Add this unit to the grid
        grid.Add(this);

        //Init the old pos
        oldPos = soldierTrans.position;

        this.walkSpeed = 5f;

        //Give it a random coordinate to move towards
        GetNewTarget();
    }


    //Move the cube randomly across the map
    public override void Move()
    {
        //Move towards the target
        soldierTrans.Translate(Vector3.forward * Time.deltaTime * walkSpeed);

        //See if the the cube has moved to another cell
        grid.Move(this, oldPos);

        //Save the old position
        oldPos = soldierTrans.position;

        //If the soldier has reached the target, find a new target
        if ((soldierTrans.position - currentTarget).magnitude < 1f)
        {
            GetNewTarget();
        }
    }


    //Give the enemy a new target to move towards and rotate towards that target
    void GetNewTarget()
    {
        currentTarget = new Vector3(Random.Range(0f, mapWidth), 0.5f, Random.Range(0f, mapWidth));

        //Rotate towards the target
        soldierTrans.rotation = Quaternion.LookRotation(currentTarget - soldierTrans.position);
    }
}

