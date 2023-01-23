// Think of a real world scenario for following:

// Class 1 should has some fields and methods
// Class 2 inherits Class 1
// Class 3 has some fields on it
// Interface 1 have some method definitions
// Class 2 and Class 3 implements Interface 1

//class Mobile
//{
// public int name;
// double price;
// bool isSuitable;
//double noOfItems;


class A
{
    public int x;
}

class B : A // Single, A is base/parent/super and B is derived/child/sub
{
    public string y;
}

class C : B      // Multi-Level
{
    public byte z;
    public void Test() { }
}

interface ID
{

}


// Multiple
class E : B, ID   // Class E inherits B and implements ID
{

}
