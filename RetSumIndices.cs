public int[] RetSumIndices(int target, int[] arr)
{
	int[] indices = new int[2];
	Dictionary<int, int> arrDict = new Dictionary<int, int>();

	for(int i=0; i<arr.Length; i++)
	{
		arrDict.Add(arr[i], i);
	}

	foreach(KeyValuePair<int, int> entry in arrDict)
	{
		if(arrDict.TryGetValue(target-entry.Key, out indices[0]) && indices[0] != entry.Value)
		{
			indices[1] = entry.Value;
			return indices;
		}
    else
    {
      indices[0] = 0;
    }
	}

	return indices;
}
