using Godot;
using Godot.Collections;

public static class GodotArrayExtensions
{
	public static Variant PopFront(this Array array)
	{
		if (array.Count == 0)
			return default;

		var first = array[0];
		array.RemoveAt(0);
		return first;
	}

	public static bool IsEmpty(this Array array) => array.Count == 0;

	public static Variant PopBack(this Array array)
	{
		if (array.Count == 0)
		{
			return default;
		}
		int lastIndex = array.Count - 1;
		var last = array[lastIndex];
		array.RemoveAt(lastIndex);
		return last;
	}
}