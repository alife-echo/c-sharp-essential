SortedDictionary<int,string> dict = new SortedDictionary<int,string>();

dict.Add(1, "one");
dict.Add(2, "two");
dict.Add(3, "three");

var dict2 = new SortedDictionary<int,string>()
{
    {3,"one"},
    {1,"two"},
    {2,"three"},
};