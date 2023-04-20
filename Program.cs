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
//Console.WriteLine(ContainsDuplicate(new int[]{1,2,3,4,2}));
/*
echo "# test" >> README.md
git init
git add README.md
git commit -m "first commit"
git branch -M main
git remote add origin https://github.com/chas2004/test.git
git push -u origin main
*/