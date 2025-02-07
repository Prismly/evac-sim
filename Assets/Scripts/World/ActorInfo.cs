using System;

[Serializable]
public class ActorInfo

{
    [Serializable]
    public struct Relationship
    {
        public string type;
        public string with;
        public int valence;
    }
    [Serializable]
    public struct Motive
    {
        public float accomplishment;
        public float social;
        public float physical;
        public float emotional;
        public float financial;
    }

    public string name;
    public Motive motive;
    public string currentLocation;
    public string destination;
    public int occupiedCounter;
    public string currentAction;
    public Relationship[] relationships;
}
