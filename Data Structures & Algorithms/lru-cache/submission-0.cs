public class LRUCache {
    private LinkedList<(int,int)> ll;
    private Dictionary<int,LinkedListNode<(int,int)>> map;
    private int cap;
    public LRUCache(int capacity) {
        cap = capacity;
        ll = new();
        map = new();
    }
    
    public int Get(int key) {
        if(map.ContainsKey(key)){
            var node = map[key];
            ll.Remove(node);
            ll.AddLast(node);
            return map[key].Value.Item2;
        }
        return -1;
    }
    
    public void Put(int key, int value) {
        var node = new LinkedListNode<(int,int)>((key,value));
        if(map.ContainsKey(key)){
            ll.Remove(map[key]);
        }
        ll.AddLast(node);
        map[key]=node;
        if(map.Count > cap){
            var t = ll.First;
            ll.RemoveFirst();
            map.Remove(t.Value.Item1);
        }
        return;
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */