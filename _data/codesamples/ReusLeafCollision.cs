void OnTriggerEnter2D(Collider2D other)
{
    //If this leaf is boosting and hits a player, de-register player colliding and stop boosting. OnTriggerStay2D takes over.
    if (other.tag.Equals("Player") && doBoost)
    {
        other.gameObject.GetComponent<PlayerBlobPolygonWorldSpace>().IsColliding = false;
        doBoost = false;
        boostTimer = 0;
    }
}
 
void OnTriggerStay2D(Collider2D other)
{
    if (other.tag.Equals("Player"))
    {
        //Stopped colliding timer is used to keep leaves into place for a short moment when stepped off of.
        stoppedColliding = false;
        collisionStoppedTimer = 0f;
   
        //When this leaf hits a player that is already on a leaf, pass through with increased speed (boost)
        if (other.gameObject.GetComponent<PlayerBlobPolygonWorldSpace>().IsColliding && speedVector.y > 0)
        {
            ignoreCollisions = true;
            doBoost = true;
        }
        //If the player hit isn't on a leaf yet, stop this leaf and set player colliding to active.
        else
        {
            other.gameObject.GetComponent<PlayerBlobPolygonWorldSpace>().IsColliding = true;
            speedVector = Vector3.zero;
        }
    }
    //When hitting another leaf, while moving and not yet boosting; boost.
    else if (other.tag.Equals("Leaf") && !doBoost && speedVector.y != 0f)
    {
        //Check to prevent leaves from constantly boosting each other.
        if(!other.GetComponent<SimpleLeaf>().DoBoost)
            doBoost = true;
    }
}
 
void OnTriggerExit2D(Collider2D other)
{
    if (other.tag.Equals("Player"))
    {
        stoppedColliding = true;
 
        //When a player exits this leaf, de-register player from colliding. In both cases start leaf collision logic again.
        if (!ignoreCollisions)
            other.gameObject.GetComponent<PlayerBlobPolygonWorldSpace>().IsColliding = false;
        else
        {
            ignoreCollisions = false;
            other.gameObject.GetComponent<PlayerBlobPolygonWorldSpace>().IsColliding = false;
        }                
    }
}