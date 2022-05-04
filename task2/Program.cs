using task2;


Branch branch = new Branch("level 1");
branch.AddBranch(new Branch("level 2"));
branch.AddBranch(new Branch("level 2"));
branch.AddBranch(new Branch("level 2"));
branch.children[0].AddBranch(new Branch("level 3"));
branch.children[1].AddBranch(new Branch("level 3"));
branch.children[2].AddBranch(new Branch("level 3"));
branch.children[1].children[0].AddBranch(new Branch("level 4"));
branch.children[0].children[0].AddBranch(new Branch("level 4"));
branch.children[1].children[0].children[0].AddBranch(new Branch("level 5"));


int Depth(Branch branch, int depth)
{
    var maxDepth = depth;
    branch.Callme();

    foreach (var item in branch.children)
    {
        maxDepth = Math.Max(maxDepth, Depth(item, depth + 1));
    }

    return maxDepth;
}
 
var maximumDepth = Depth(branch, 1);

Console.WriteLine($"The maximum depth is: {maximumDepth}");