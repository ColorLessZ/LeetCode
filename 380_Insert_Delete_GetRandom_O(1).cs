public class RandomizedSet {

    private Dictionary<int, int> _location;
    private List<int> _list;
    private Random _rnd;
    
    /** Initialize your data structure here. */
    public RandomizedSet() {
        _location = new Dictionary<int, int>();
        _list = new List<int>();
        _rnd = new Random();
    }
    
    /** Inserts a value to the set. Returns true if the set did not already contain the specified element. */
    public bool Insert(int val) {
        if (!_location.ContainsKey(val)){
            _location.Add(val, _list.Count);
            _list.Add(val);
            return true;
        }
        
        return false;
    }
    
    /** Removes a value from the set. Returns true if the set contained the specified element. */
    public bool Remove(int val) {
        if (_location.ContainsKey(val)){
            var index = _location[val];
            var lastEle = _list[_list.Count - 1];
            _list[index] = lastEle;
            _location[lastEle] = index;
            _location.Remove(val);
            _list.RemoveAt(_list.Count - 1);
            return true;
        }
        
        return false;
    }
    
    /** Get a random element from the set. */
    public int GetRandom() {
        var index = _rnd.Next(0, _list.Count);
        return _list[index];
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */