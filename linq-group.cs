void Main()
{
	var ids = new List<int>() 
	{
		21, 33, 45, 21, 784, 24, 55, 68, 87,
		21, 33, 45, 21, 784, 24, 55, 68, 87,
		21, 33, 45, 21, 784, 24, 55, 68, 87,
		21, 33, 45, 21, 784, 24, 55, 68, 87,
		21, 33, 45, 21, 784, 24, 55, 68, 87,
		21, 33, 45, 21, 784, 24, 55, 68, 87,
		21, 33, 45, 21, 784, 24, 55, 68, 87,
		21, 33, 45, 21, 784, 24, 55, 68, 87,
		21, 33, 45, 21, 784, 24, 55, 68, 87,
	};
	var result = ids.Select((value, index) => new { PairNum = index % 30, value })
					.GroupBy(pair => pair.PairNum)
					.Select(grp => grp.Select(g => g.value).ToList())
					.ToList();
	result.Dump();
}