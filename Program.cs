bool ContainsDuplicate(int[] nums){
    HashSet<int> set = new HashSet<int>();
    foreach(int num in nums){
        if(set.Contains(num))
            return true;
        set.Add(num);
    }
    return false;

}
Console.WriteLine(ContainsDuplicate(new int[]{1,2,3,1}));
Console.WriteLine(ContainsDuplicate(new int[]{1,2,3,4}));
