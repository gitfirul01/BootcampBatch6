// Enumerator
class Program {
    static void Main() {	
		//
    }
}

class MyCollection : IEnumerator<int>
{
	public int currentIndex = -1;
	public int[] myInt = new int[5];
	
	public object Current => myInt[currentIndex];

	// BEGIN: implementation
    int IEnumerator<int>.Current => throw new NotImplementedException();

    public void Dispose()
    {
        throw new NotImplementedException();
    }
	// END: impementation

    public bool MoveNext()
	{
		if(currentIndex+1 < myInt.Length) {
			currentIndex++;
			return true;
			}
		else {
			Reset();
			return false;
		}
	}

	public void Reset()
    {
        currentIndex = -1;
    }
}
