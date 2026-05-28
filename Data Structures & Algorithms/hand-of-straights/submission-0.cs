public class Solution {
    public bool IsNStraightHand(int[] hand, int groupSize) {
        Array.Sort(hand);
        var map = new Dictionary<int,int>();
        foreach(int e in hand){
            if(!map.ContainsKey(e)) map[e]=1;
            else map[e]++;
        }
        foreach(int e in hand){
            if(map.ContainsKey(e)){
                int ele = e;
                for(int i=0; i<groupSize; i++){
                    if(map.ContainsKey(ele)){
                        map[ele]--;
                        if(map[ele]==0) map.Remove(ele);
                        ele++;
                    }
                    else{
                        return false;
                    }
                }
            }
        }
        return true;
    }
}