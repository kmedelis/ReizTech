using System;
namespace task2
{
	public class Branch
	{
		public List<Branch> children;
		public string Data { get; set; }


		public Branch(string data)
		{
			Data = data;
			children = new List<Branch>();
		}

		public void AddBranch(Branch branch)
        {
			children.Add(branch);
        }

		public void Callme()
        {
			Console.WriteLine(Data);
        }
	}
}

