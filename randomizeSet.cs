Please use this Google doc to code during your interview. To free your hands for coding, we recommend that you use a headset or a phone with speaker option.

Design a Set-like data structure, that supports these three operations:
insert,  remove and getRandom,
it needs to behave like a set(no duplicate elems), and support getting a random element.

class RandomizedSet {
	//Declare class vars here
List<int> setList;
Dictionary<int,int> dict;
int rand;
    /** Initialize your data structure here. */
    public RandomizedSet() {
         setList = new List<int>;
   dict = new Dictionary<int, int> (); 
   var rand = new Random();
    }
    
    /** Inserts a value to the set. Returns true if the set did not already contain the specified element. */
    public boolean insert(int val) {
        if (dict.containsKey(val))
		return false;
	setList.Add(val);
	dict.set(val, setList.size()-1);
    }
    
    /** Removes a value from the set. Returns true if the set contained the specified element. */
    public boolean remove(int val) {
        // setup
	  if (!dict.containsKey(val))
		return false;
	dict.remove(val);

// swaps
var last = setList.Size() - 1;
var index = dict(val);
setList[index] = setList[last];

	setList.remove(setList.Size() - 1);
	// update hash table index value
	dict.set(setList[index], index);
    }
    
    /** Get a random element from the set. */
    public int getRandom() {
        
	int index = rand.limit(setList.Size()) // gives a number from 0 to size of list
	return setList[index];
	 
    }
}


