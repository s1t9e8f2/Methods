static int[] ParseInputLine(string str)
{
	string[] splitedString = str.Split(' ');
	int[] result = new int[splitedString.Length];
	for (int i = 0; i < splitedString.Length; i++)
	{
		result[i] = int.Parse(splitedString[i]);
	}

	return result;
}