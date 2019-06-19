using System.Collections.Generic;

namespace interfaces {
    class FishbowlCollection {
        public List<SmallFishBowl> AllContainers = new List<SmallFishBowl>();
        public SmallFishBowl AddSmallFishbowl(){
            SmallFishBowl fishbowl = new SmallFishBowl();
            AllContainers.Add(fishbowl);
            return fishbowl;
        }
    }
}