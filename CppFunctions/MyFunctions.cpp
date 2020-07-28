#define MyFunctions _declspec(dllexport)
// you could in
struct MyStruct
{
	int a, b;
};

extern "C" {

	MyFunctions int AddNumbers(MyStruct vals)
	{
		return vals.a + vals.b;
	}

	MyFunctions int SubtractNumbers(MyStruct vals)
	{
		return vals.a - vals.b;
	}
}